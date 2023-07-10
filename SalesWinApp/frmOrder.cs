using BusinessObject;
using DataAccess.Repository;
using System.Diagnostics.Metrics;

namespace SalesWinApp;

public partial class frmOrder : Form
{
    public frmOrder()
    {
        InitializeComponent();
    }

    private void label7_Click(object sender, EventArgs e)
    {

    }

    IOrderRepository orderRepository = new OrderRepository();

    BindingSource source;

    private void frmOrder_Load(object sender, EventArgs e)
    {
        btnDelete.Enabled = false;

        dgvOrderList.CellDoubleClick += DgvOrderList_CellDoubleClick;
    }

    //private void DgvOrderList_CellDoubleClick(object sender, EventArgs e)
    //{
    //    if (dgvOrderList.SelectedRows.Count > 0)
    //    {
    //        OrderObject selectedOrder = dgvOrderList.SelectedRows[0].DataBoundItem as OrderObject;
    //        if (selectedOrder != null)
    //        {
    //            txtOrderID.Text = selectedOrder.OrderID.ToString();
    //            txtMemberID.Text = selectedOrder.MemberID.ToString();
    //            txtOrderDate.Text = selectedOrder.OrderDate.ToString();
    //            txtRequiredDate.Text = selectedOrder.RequiredDate.ToString();
    //            txtShippedDate.Text = selectedOrder.ShippedDate.ToString();
    //            txtFreight.Text = selectedOrder.Freight.ToString();
    //        }
    //    }
    //}


    private void ClearText()
    {
        txtOrderID.Text = string.Empty;
        txtMemberID.Text = string.Empty;
        txtOrderDate.Text = string.Empty;
        txtRequiredDate.Text = string.Empty;
        txtShippedDate.Text = string.Empty;
        txtFreight.Text = string.Empty;
    }

    private OrderObject GetOrderObject()
    {
        OrderObject order = null;
        try
        {
            order = new OrderObject
            {
                //MemberID = int.Parse(txtMemberID.Text),
                //Email = txtEmail.Text,
                //CompanyName = txtCompanyName.Text,
                //City = txtCity.Text,
                //Country = txtCountry.Text,
                //Password = txtPassword.Text
                OrderID = int.Parse(txtOrderID.Text),
                MemberID = int.Parse(txtMemberID.Text),
                OrderDate = DateTime.Parse(txtOrderDate.Text),
                RequiredDate = DateTime.Parse(txtRequiredDate.Text),
                ShippedDate = DateTime.Parse(txtShippedDate.Text),
                Freight = int.Parse(txtFreight.Text)
            };
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Get Order");
        }
        return order;
    }

    public void LoadOrderList()
    {
        var order = orderRepository.GetOrder();
        try
        {
            source = new BindingSource();
            source.DataSource = order;

            dgvOrderList.DataSource = null;
            dgvOrderList.DataSource = source;
            if (order.Count() == 0)
            {
                ClearText();
                btnDelete.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
            }
        }
        catch (Exception ex)
        {

            MessageBox.Show(ex.Message, "Load Order list");
        }
    }

    private void btnLoad_Click(object sender, EventArgs e)
    {
        LoadOrderList();
    }

    private void btnClearText_Click(object sender, EventArgs e)
    {
        ClearText();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        /*
         *         try
        {
            if (dgvMemberList.SelectedRows.Count > 0)
            {
                int memberID = (int)dgvMemberList.SelectedRows[0].Cells["MemberID"].Value;
                memberRepository.DeleteMember(memberID);
                LoadMemberList();
            }
            else
            {
                MessageBox.Show("Please select a member to delete.", "Delete Member");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Delete Member");
        }
         */
        try
        {
            if (dgvOrderList.SelectedRows.Count > 0)
            {
                int orderID = (int)dgvOrderList.SelectedRows[0].Cells["OrderID"].Value;
                orderRepository.DeleteOrder(orderID);
                LoadOrderList();
            }
            else
            {
                MessageBox.Show("Please select a Order to delete.", "Delete Order");
            }
        }
        catch (Exception ex)
        {

            MessageBox.Show(ex.Message, "Delete Order");
        }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        frmOrderDialog frmOrderDialog = new frmOrderDialog
        {
            Text = "Add Order",
            InsertOrUpdate = false,
            OrderRepository = orderRepository

        };

        if (frmOrderDialog.ShowDialog() == DialogResult.OK)
        {
            LoadOrderList();

            source.Position = source.Count - 1;
        }

    }

    private void btnBack_Click(object sender, EventArgs e)
    {
        frmMain frmMain = new frmMain();
        frmMain.ShowDialog();
        this.Hide();
    }

    private void dgvOrderList_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            DataGridViewRow selectedRow = dgvOrderList.Rows[e.RowIndex];

            OrderObject selectedOrder = selectedRow.DataBoundItem as OrderObject;

            frmOrderDialog frmOrderDialog = new frmOrderDialog
            {
                Text = "Add Order",
                InsertOrUpdate = true,
                OrderInfo = selectedOrder,
                OrderRepository = orderRepository

            };

            if (frmOrderDialog.ShowDialog() == DialogResult.OK)
            {
                LoadOrderList();
                source.Position = source.Count - 1;
            }
        }
    }

    private void DgvOrderList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (dgvOrderList.SelectedRows.Count > 0)
        {
            OrderObject selectedOrder = dgvOrderList.SelectedRows[0].DataBoundItem as OrderObject;
            if (selectedOrder != null)
            {
                txtOrderID.Text = selectedOrder.OrderID.ToString();
                txtMemberID.Text = selectedOrder.MemberID.ToString();
                txtOrderDate.Text = selectedOrder.OrderDate.ToString();
                txtRequiredDate.Text = selectedOrder.RequiredDate.ToString();
                txtShippedDate.Text = selectedOrder.ShippedDate.ToString();
                txtFreight.Text = selectedOrder.Freight.ToString();
            }
        }
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        var orders = orderRepository.GetOrder();
        try
        {
            if (source == null) source = new();

            source.DataSource = orders.Where(
                    order => order.OrderID.ToString().Contains(txtOrderID.Text)
                          && order.MemberID.ToString().Contains(txtMemberID.Text)
                          && order.OrderDate.ToString().Contains(txtOrderDate.Text)
                          && order.RequiredDate.ToString().Contains(txtRequiredDate.Text)
                          && order.ShippedDate.ToString().Contains(txtShippedDate.Text)
                          && order.Freight.ToString().Contains(txtFreight.Text));

            dgvOrderList.DataSource = null;
            dgvOrderList.DataSource = source;

            if (orders == null)
            {
                ClearText();
                btnDelete.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = true;
            }

        }
        catch (Exception ex)
        {

            MessageBox.Show(ex.Message, "Search Order list");
        }
    }
}
