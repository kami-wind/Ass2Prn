using BusinessObject;

namespace DataAccess.Repository;

public interface IProductRepository
{
    IEnumerable<ProductObject> GetProduct();
    ProductObject GetProductById(int ProductID);
    void InsertProduct(ProductObject product);
    void UpdateProduct(ProductObject product);
    void DeleteProduct(int ProductID);
    IEnumerable<ReportItem> GetProductByDateRange(DateTime startDate, DateTime endDate);

}
