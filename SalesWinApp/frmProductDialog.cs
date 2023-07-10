using BusinessObject;
using DataAccess.Repository;

namespace SalesWinApp;

public partial class frmProductDialog : Form
{
    public frmProductDialog()
    {
        InitializeComponent();
    }


    public bool InsertOrUpdate { get; set; }

    public ProductObject ProductInfo { get; set; }

    public IProductRepository ProductRepository { get; set; }


    private void frmProductDialog_Load(object sender, EventArgs e)
    {
        txtProductID.Enabled = !InsertOrUpdate;
        if (InsertOrUpdate == true)
        {
            txtProductID.Text = ProductInfo.ProductID.ToString();
            txtCategoryID.Text = ProductInfo.CategoryID.ToString();
            txtProductName.Text = ProductInfo.ProductName.ToString();
            txtWeight.Text = ProductInfo.Weight.ToString();
            txtUnitPrice.Text = ProductInfo.UnitPrice.ToString();
            txtUnitsInStock.Text = ProductInfo.UnitslnStock.ToString();
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            var products = new ProductObject
            {
                ProductID = int.Parse(txtProductID.Text),
                CategoryID = int.Parse(txtCategoryID.Text),
                ProductName = txtProductName.Text,
                Weight = txtWeight.Text,
                UnitPrice = decimal.Parse(txtUnitPrice.Text),
                UnitslnStock = int.Parse(txtUnitsInStock.Text),
            };

            if (InsertOrUpdate == false)
            {
                ProductRepository.InsertProduct(products);
            }
            else
            {
                ProductInfo.ProductID = products.ProductID;
                ProductInfo.CategoryID = products.CategoryID;
                ProductInfo.ProductName = products.ProductName;
                ProductInfo.Weight = products.Weight;
                ProductInfo.UnitPrice = products.UnitPrice;
                ProductInfo.UnitslnStock = products.UnitslnStock;

                ProductRepository.UpdateProduct(products);
            }

            MessageBox.Show(InsertOrUpdate == false ? "Product added successfully!" : "Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add new Product" : "Update Product");
        }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }
}
