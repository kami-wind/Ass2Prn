using BusinessObject;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DataAccess;

public class OrderDetailDAO : BaseDAL
{

    //-----------------------------
    //Using Singlton Patern


    private static OrderDetailDAO instance = null;
    private static readonly object instanceLock = new object();
    private OrderDetailDAO() { }

    public static OrderDetailDAO Instance
    {
        get
        {
            lock (instanceLock)
            {
                if (instance == null)
                {
                    instance = new OrderDetailDAO();
                }
                return instance;
            }
        }
    }

    public IEnumerable<OrderDetailObject> GetOrderDetailList()
    {
        IDataReader? dataReader = null;
        string SQLSelect = "Select OrderID, ProductID, UnitPrice, Quantity, Discount from OrderDetail";
        var orderDetails = new List<OrderDetailObject>();

        try
        {
            dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
            while (dataReader.Read())
            {
                orderDetails.Add(new OrderDetailObject()
                {
                    OrderID = dataReader.GetInt32(0),
                    ProductID = dataReader.GetInt32(1),
                    UnitPrice = dataReader.GetDecimal(2),
                    Quantity = dataReader.GetInt32(3),
                    Discount = dataReader.GetFloat(4)
                });
            }
        }
        catch (Exception ex)
        {

            throw new Exception(ex.Message);
        }
        finally
        {
            dataReader.Close();
            connection.Close();
        }
        return orderDetails;
    }


    public OrderDetailObject GetOrderDetailByID(int orderID)
    {
        OrderDetailObject? orderDetail = null;
        IDataReader dataReader = null;
        string SQLSelect = "Select OrderID, ProductID, UnitPrice, Quantity, Discount from OrderDetail";
        try
        {
            var param = dataProvider.CreateParameter("@OrderID", 4, orderID, DbType.Int32);
            dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
            if (dataReader.Read())
            {
                orderDetail = new OrderDetailObject()
                {
                    OrderID = dataReader.GetInt32(0),
                    ProductID = dataReader.GetInt32(1),
                    UnitPrice = dataReader.GetDecimal(2),
                    Quantity = dataReader.GetInt32(3),
                    Discount = dataReader.GetFloat(4)
                };
            }
        }
        catch (Exception ex)
        {

            throw new Exception(ex.Message);
        }
        finally
        {
            dataReader.Close();
            CloseConnection();
        }
        return orderDetail;
    }

    //----------------------------

    public void Add(OrderDetailObject orderDetail)
    {
        try
        {
            OrderDetailObject pro = GetOrderDetailByID(orderDetail.OrderID);
            if (pro == null)
            {
                string SQLInsert = "Insert OrderDetail values(@OrderID,@ProductID,@UnitPrice,@Quantity,@Discount)";
                var parameters = new List<SqlParameter>();
                parameters.Add(dataProvider.CreateParameter("OrderID", 4, pro.OrderID, DbType.Int32));
                parameters.Add(dataProvider.CreateParameter("ProductID", 4, pro.ProductID, DbType.Int32));
                parameters.Add(dataProvider.CreateParameter("UnitPrice", 15, pro.UnitPrice, DbType.Decimal));
                parameters.Add(dataProvider.CreateParameter("@Quantity",15 , pro.Quantity, DbType.Int32));
                parameters.Add(dataProvider.CreateParameter("@Discount", 15, pro.Discount, DbType.Byte));
                dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
            }
            else
            {
                throw new Exception("Order is already exist.");
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


    public void Update(OrderDetailObject orderDetail)
    {
        try
        {
            OrderDetailObject pro = GetOrderDetailByID(orderDetail.OrderID);
            if (pro != null)
            {
                string SQLUpdate = "Update OrderDetail set ProductID=@ProductID, UnitPrice=@UnitePrice, Quantity=@Quantity, Discount=@Discount where OrderID=@OrderID";
                var parameters = new List<SqlParameter>();
                parameters.Add(dataProvider.CreateParameter("OrderID", 4, pro.OrderID, DbType.Int32));
                parameters.Add(dataProvider.CreateParameter("ProductID", 4, pro.ProductID, DbType.Int32));
                parameters.Add(dataProvider.CreateParameter("UnitPrice", 15, pro.UnitPrice, DbType.Decimal));
                parameters.Add(dataProvider.CreateParameter("@Quantity", 15, pro.Quantity, DbType.Int32));
                parameters.Add(dataProvider.CreateParameter("@Discount", 15, pro.Discount, DbType.Byte));
                dataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());

            }
            else { throw new Exception("OrderDetail does not already exist"); }
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





    //-----------------

    public void Remove(int orderID)
    {
        try
        {
            OrderDetailObject orderDetail = GetOrderDetailByID(orderID);
            if (orderID != null)
            {
                string SQLDelete = "Delete OrderDetail where OrderID=@OrderID";
                var param = dataProvider.CreateParameter("@OrderID", 4, orderID, DbType.Int32);
                dataProvider.Delete(SQLDelete, CommandType.Text, param);
            }
            else
            {
                throw new Exception("OrderDetail does not already exist.");
            }

        }
        catch (Exception ex)
        {

            throw new Exception(ex.Message);
        }
        finally { CloseConnection(); }
    }


}
