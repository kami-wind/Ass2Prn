using BusinessObject;

namespace DataAccess.Repository;

public class ProductRepository : IProductRepository
{
    public void DeleteProduct(int ProductID) => ProductDAO.Instance.Delete(ProductID);

    public IEnumerable<ProductObject> GetProduct() => ProductDAO.Instance.GetProductList();

    public ProductObject GetProductById(int ProductID) => ProductDAO.Instance.GetProductByID(ProductID);


    public void InsertProduct(ProductObject product) => ProductDAO.Instance.Add(product);


    public void UpdateProduct(ProductObject product) => ProductDAO.Instance.Update(product);

    public IEnumerable<ReportItem> GetProductByDateRange(DateTime startDate, DateTime endDate) => ProductDAO.Instance.GenerateReport(startDate, endDate);
}

