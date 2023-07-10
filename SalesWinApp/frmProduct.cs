using BusinessObject;
using DataAccess;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp;

public partial class frmProduct : Form
{
    public frmProduct()
    {
        InitializeComponent();
    }

    IProductRepository productRepository = new ProductRepository();

    BindingSource source;

    private void frmProduct_Load(object sender, EventArgs e)
    {
        btnDelete.Enabled = false;

        dgvProductList.CellDoubleClick += DgvProductList_CellDoubleClick;

    }

    private void DgvProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        //if (dgvProductList.SelectedRows.Count > 0)
        //{
        //    ProductObject selectedProduct = dgvProductList.SelectedRows[0].DataBoundItem as ProductObject;

        //    if (selectedProduct != null)
        //    {
        //        txtProductID.Text = selectedProduct.ProductID.ToString();
        //        txtCategoryID.Text = selectedProduct.CategoryID.ToString();
        //        txtProductName.Text = selectedProduct.ProductName.ToString();
        //        txtWeight.Text = selectedProduct.Weight.ToString();
        //        txtUnitPrice.Text = selectedProduct.UnitPrice.ToString();
        //        txtUnitsInStock.Text = selectedProduct.UnitslnStock.ToString();
        //    }
        //}
    }

    private void ClearText()
    {
        txtProductID.Text = string.Empty;
        txtCategoryID.Text = string.Empty;
        txtProductName.Text = string.Empty;
        txtWeight.Text = string.Empty;
        txtUnitPrice.Text = string.Empty;
        txtUnitsInStock.Text = string.Empty;
    }

    public void LoadProductList()
    {
        var products = productRepository.GetProduct();
        try
        {
            source = new BindingSource();
            source.DataSource = products;

            dgvProductList.DataSource = null;
            dgvProductList.DataSource = source;

            if (products.Count() == 0)
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

            MessageBox.Show(ex.Message, "Load Product list");
        }
    }

    private void btnLoad_Click(object sender, EventArgs e)
    {
        LoadProductList();
    }

    private void btnClearText_Click(object sender, EventArgs e)
    {
        ClearText();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            if (dgvProductList.SelectedRows.Count > 0)
            {
                int ProductID = (int)dgvProductList.SelectedRows[0].Cells["ProductID"].Value;
                productRepository.DeleteProduct(ProductID);
                LoadProductList();
            }

            else
            {
                MessageBox.Show("Please select a Product to delete.", "Delete Product");
            }
        }
        catch (Exception ex)
        {

            MessageBox.Show(ex.Message, "Delete Product");
        }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        frmProductDialog frmProductDialog = new frmProductDialog
        {
            Text = "Add Product",
            InsertOrUpdate = false,
            ProductRepository = productRepository,
        };
        if (frmProductDialog.ShowDialog() == DialogResult.OK)
        {
            LoadProductList();
            source.Position = source.Count - 1;
        }
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
        frmMain frm = new frmMain();
        frm.Show();
        this.Hide();
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        var products = productRepository.GetProduct();
        try
        {
            if (source == null) source = new();

            source.DataSource = products.Where(
                product => product.ProductID.ToString().Contains(txtProductID.Text)
                && product.CategoryID.ToString().Contains(txtCategoryID.Text)
                && product.ProductName.ToString().Contains(txtProductName.Text)
                && product.Weight.ToString().Contains(txtWeight.Text)
                && product.UnitPrice.ToString().Contains(txtUnitPrice.Text)
                && product.UnitslnStock.ToString().Contains(txtUnitsInStock.Text));

            dgvProductList.DataSource = null;
            dgvProductList.DataSource = source;

            if (products == null)
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
            MessageBox.Show(ex.Message, "Search Product list");
        }
    }

    private void dgvProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0 )
        {
            DataGridViewRow selectedRow = dgvProductList.Rows[e.RowIndex];


            ProductObject selectedProduct = selectedRow.DataBoundItem as ProductObject;

            if (selectedProduct != null)
            {

                frmProductDialog frmProductDialog = new frmProductDialog
                {
                    Text = "Update Product",
                    InsertOrUpdate = true,
                    ProductInfo = selectedProduct,
                    ProductRepository = productRepository,
                };

                if (frmProductDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadProductList();
                    source.Position = source.Count - 1;
                }
            }
        }
    }

    private void btnReport_Click(object sender, EventArgs e)
    {
        frmReportSetDate frmReportSetDate = new frmReportSetDate();



       //DateTime.Parse("2003-02-01"); 
      //  DateTime.Parse("2003-10-01");



        try
        {

            if (frmReportSetDate.ShowDialog() == DialogResult.OK)
            {
                DateTime startDate = frmReportSetDate.SelectedStartDate;
                DateTime endDate = frmReportSetDate.SelectedEndDate;

                if (startDate < SqlDateTime.MinValue.Value || endDate > SqlDateTime.MaxValue.Value)
                {
                    MessageBox.Show("Selected date range is outside the valid range.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                // Generate the report
                var reportData = productRepository.GetProductByDateRange(startDate, endDate);

                // Display the report data (e.g., in a DataGridView control)

                source = new BindingSource();
                source.DataSource = reportData;

                dgvProductList.DataSource = null;
                dgvProductList.DataSource = source;
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show("An error occurred while generating the report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
