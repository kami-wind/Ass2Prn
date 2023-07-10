using BusinessObject;
using DataAccess.Repository;

namespace SalesWinApp;

public partial class frmOrderDialog : Form
{

    public bool InsertOrUpdate { get; set; }

    public OrderObject OrderInfo { get; set; }

    public IOrderRepository OrderRepository { get; set; }


    public frmOrderDialog()
    {
        InitializeComponent();
    }

    private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
    {

    }

    private void frmOrderDialog_Load(object sender, EventArgs e)
    {
        txtOrderID.Enabled = !InsertOrUpdate;
        if (InsertOrUpdate == true)
        {
            txtOrderID.Text = OrderInfo.OrderID.ToString();
            txtMemberID.Text = OrderInfo.MemberID.ToString();
            dtpOrderDate.Text = OrderInfo.OrderDate.ToString();
            dtpRequiredDate.Text = OrderInfo.RequiredDate.ToString();
            dtpShippedDate.Text = OrderInfo.ShippedDate.ToString();
            txtFreight.Text = OrderInfo.Freight.ToString();
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            var order = new OrderObject
            {
                OrderID = int.Parse(txtOrderID.Text),
                MemberID = int.Parse(txtMemberID.Text),
                OrderDate = DateTime.Parse(dtpOrderDate.Text),
                RequiredDate = DateTime.Parse(dtpRequiredDate.Text),
                ShippedDate = DateTime.Parse(dtpShippedDate.Text),
                //OrderDate = dtpOrderDate.Value,
                //RequiredDate = dtpRequiredDate.Value,
                //ShippedDate = dtpShippedDate.Value,
                Freight = decimal.Parse(txtFreight.Text)
            };

            if (InsertOrUpdate == false)
            {
                OrderRepository.InsertOrder(order);
            }
            else
            {
                OrderInfo.OrderID = order.OrderID;
                OrderInfo.MemberID = order.MemberID;
                OrderInfo.OrderDate = order.OrderDate;
                OrderInfo.RequiredDate = order.RequiredDate;
                OrderInfo.ShippedDate = order.ShippedDate;
                OrderInfo.Freight = order.Freight;

                OrderRepository.UpdateOrder(order);
            }
            MessageBox.Show(InsertOrUpdate == false ? "Order added successfully!" : "Order updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add new Order" : "Update Order");
        }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }

    private void dtpOrderDate_ValueChanged(object sender, EventArgs e)
    {

    }
}
