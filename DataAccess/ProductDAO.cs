using BusinessObject;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace DataAccess;

public class ProductDAO : BaseDAL
{

    //-----------------------------
    //Using Singlton Patern
    private static ProductDAO? instance = null;
    private static readonly object instanceLock = new object();
    private ProductDAO() { }

    public static ProductDAO Instance
    {
        get
        {
            lock (instanceLock)
            {
                if (instance == null)
                {
                    instance = new ProductDAO();
                }
                return instance;
            }
        }
    }


    public IEnumerable<ProductObject> GetProductList()
    {
        IDataReader? dataReader = null;
        string SQLSelect = "Select ProductID, CategoryID, ProductName, Weight, UnitPrice, UnitsInStock from Product";
        var products = new List<ProductObject>();

        try
        {
            dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
            while (dataReader.Read())
            {
                products.Add(new ProductObject()
                {
                    ProductID = dataReader.GetInt32(0),
                    CategoryID = dataReader.GetInt32(1),
                    ProductName = dataReader.GetString(2),
                    Weight = dataReader.GetString(3),
                    UnitPrice = dataReader.GetDecimal(4),
                    UnitslnStock = dataReader.GetInt32(5)
                });
            }
        }
        catch (Exception ex )
        {
            throw new Exception(ex.Message);
        }
        finally
        {
            dataReader.Close();
            connection.Close();
        }
        return products;

    }

    public ProductObject GetProductByID(int productID)
    {
        ProductObject? product = null;
        IDataReader dataReader = null;
        string SQLSelect = "Select ProductID, CategoryID, ProductName, Weight, UnitPrice, UnitsInStock from [dbo].[Product] where ProductID=@ProductID";

        try
        {
            var param = dataProvider.CreateParameter("@ProductID", 4, productID, DbType.Int32);
            dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
            if (dataReader.Read())
            {
                product = new ProductObject
                {
                    ProductID = dataReader.GetInt32(0),
                    CategoryID= dataReader.GetInt32(1),
                    ProductName = dataReader.GetString(2),
                    Weight = dataReader.GetString(3),
                    UnitPrice= dataReader.GetDecimal(4),
                    UnitslnStock= dataReader.GetInt32(5)
                };
            }
        }
        catch (Exception ex)
        {

            throw new Exception (ex.Message);
        }
        finally
        {
            dataReader?.Close();
            CloseConnection();
        }
        return product;
    }

    //Add
    public void Add(ProductObject product)
    {
        try
        {
            ProductObject pro = GetProductByID(product.ProductID);
            if (pro == null) 
            {
                string SQLInsert = "Insert [dbo].[Product] values(@ProductID,@CategoryID,@ProductName, @Weight, @UnitPrice,@UnitsInStock)";
                var parameters = new List<SqlParameter>();

                parameters.Add(dataProvider.CreateParameter("@ProductID", 4, product.ProductID, DbType.Int32));
                parameters.Add(dataProvider.CreateParameter("@CategoryID", 4, product.CategoryID, DbType.Int32));
                parameters.Add(dataProvider.CreateParameter("@ProductName", 100, product.ProductName, DbType.String));
                parameters.Add(dataProvider.CreateParameter("@Weight", 100, product.Weight, DbType.String));
                parameters.Add(dataProvider.CreateParameter("@UnitPrice", 100, product.UnitPrice, DbType.Decimal));
                parameters.Add(dataProvider.CreateParameter("@UnitsInStock",4, product.UnitslnStock, DbType.Int32));

                dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
            }
            else
            {
                throw new Exception("Product is already exist.");
            }
        }
        catch (Exception ex )
        {

            throw new Exception(ex.Message);
        }
        finally
        {
            CloseConnection();
        }
    }

    //Update 

    public void Update (ProductObject product)
    {
        try
        {
            ProductObject pro = GetProductByID(product.ProductID);
            if (pro != null)
            {
                string SQLInsert = "Update [dbo].[Product] set CategoryID=@CategoryID, ProductName=@ProductName," +
                    " Weight=@Weight, UnitPrice=@unitPrice, UnitsInStock=@UnitsInStock where ProductID= @ProductID";
                var parameters = new List<SqlParameter>();

                parameters.Add(dataProvider.CreateParameter("@ProductID", 4, product.ProductID, DbType.Int32));
                parameters.Add(dataProvider.CreateParameter("@CategoryID", 4, product.CategoryID, DbType.Int32));
                parameters.Add(dataProvider.CreateParameter("@ProductName", 100, product.ProductName, DbType.String));
                parameters.Add(dataProvider.CreateParameter("@Weight", 100, product.Weight, DbType.String));
                parameters.Add(dataProvider.CreateParameter("@UnitPrice", 100, product.UnitPrice, DbType.Decimal));
                parameters.Add(dataProvider.CreateParameter("@UnitsInStock", 4, product.UnitslnStock, DbType.Int32));

                dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
            }
            else
            {
                throw new Exception("Product does not already exist.");
            }
        }
        catch (Exception ex)
        {

            throw new Exception(ex.Message);
        }
        finally
        {
            CloseConnection();
        }
    }

    //Delete

    public void Delete(int productID)
    {
        try
        {
            ProductObject product = GetProductByID(productID);
            if (product != null)
            {
                string SQLDelete = "Delete from [dbo].[Product] where ProductID=@ProductID";
                var param = dataProvider.CreateParameter("@ProductID", 4, productID, DbType.Int32);
                dataProvider.Delete(SQLDelete, CommandType.Text, param);
            }
            else
            {
                throw new Exception("Product does not already exist.");
            }
        }
        catch (Exception ex)
        {

            throw new Exception(ex.Message);
        }
        finally
        {
            CloseConnection();
        }
    }


    public IEnumerable<ReportItem> GenerateReport(DateTime startDate, DateTime endDate)
    {
        try
        {
            string SQLQuery = "SELECT o.OrderID, SUM(od.UnitPrice * od.Quantity) AS TotalSales," +
                " o.OrderDate, p.ProductName, od.UnitPrice, od.Quantity " +
                "FROM [Order] o JOIN OrderDetail od " +
                "ON o.OrderID = od.OrderID JOIN Product p " +
                "ON od.ProductID = p.ProductID " +
                "WHERE o.OrderDate BETWEEN @StartDate AND @EndDate " +
                "GROUP BY o.OrderID, o.OrderDate, p.ProductName, od.UnitPrice, od.Quantity " +
                "ORDER BY TotalSales DESC;";

            var parameters = new List<SqlParameter>
        {
            dataProvider.CreateParameter("@StartDate", 100, startDate, DbType.DateTime),
            dataProvider.CreateParameter("@EndDate", 100, endDate, DbType.DateTime)
        };

            var reportItems = new List<ReportItem>();

            using (IDataReader dataReader = dataProvider.GetDataReader(SQLQuery, CommandType.Text, out connection, parameters.ToArray()))
            {
                while (dataReader.Read())
                {
                    var reportItem = new ReportItem()
                    { 
                        OrderID = dataReader.GetInt32(0),
                        TotalSales = dataReader.GetDecimal(1),
                        OrderDate = dataReader.GetDateTime(2),
                        ProductName = dataReader.GetString(3),
                        UnitPrice = dataReader.GetDecimal(4),
                        Quantity = dataReader.GetInt32(5)
                    };
                    reportItems.Add(reportItem);
                }
            }

            return reportItems;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        finally
        {
            CloseConnection();
        }
    }
}
