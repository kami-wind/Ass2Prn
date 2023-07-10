using BusinessObject;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DataAccess;

public class OrderDAO : BaseDAL
{

    //-----------------------------
    //Using Singlton Patern


    private static OrderDAO instance = null;
    private static readonly object instanceLock = new object();
    private OrderDAO() { }

    public static OrderDAO Instance
    {
        get
        {
            lock (instanceLock)
            {
                if (instance == null)
                {
                    instance = new OrderDAO();
                }
                return instance;
            }
        }
    }

    public IEnumerable<OrderObject> GetOrderList()
    {
        IDataReader? dataReader = null;
        string SQLSelect = "Select OrderID, MemberID, OrderDate, RequiredDate, ShippedDate, Freight from [dbo].[Order]";
        var orders = new List<OrderObject>();

        try
        {
            dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
            while (dataReader.Read())
            {
                orders.Add(new OrderObject()
                {
                    OrderID = dataReader.GetInt32(0),
                    MemberID = dataReader.GetInt32(1),
                    OrderDate = dataReader.GetDateTime(2),
                    RequiredDate = dataReader.GetDateTime(3),
                    ShippedDate = dataReader.GetDateTime(4),
                    Freight = dataReader.GetDecimal(5),
                });
            }
        }
        catch (Exception ex)
        {

            throw new Exception(ex.Message);
        }
        finally
        {
            dataReader?.Close();
            connection.Close();
        }
        return orders;
    }


    public OrderObject GetOrderByID(int orderID)
    {
        OrderObject? order = null;
        IDataReader dataReader = null;
        string SQLSelect = "Select OrderID, MemberID, OrderDate, RequiredDate, ShippedDate, Freight from [dbo].[Order] where OrderID=@OrderID";
        try
        {
            var param = dataProvider.CreateParameter("@OrderID", 4, orderID, DbType.Int32);
            dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
            if (dataReader.Read())
            {
                order = new OrderObject
                {
                    OrderID = dataReader.GetInt32(0),
                    MemberID = dataReader.GetInt32(1),
                    OrderDate = dataReader.GetDateTime(2),
                    RequiredDate = dataReader.GetDateTime(3),
                    ShippedDate = dataReader.GetDateTime(4),
                    Freight = dataReader.GetDecimal(5),
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
        return order;
    }

    //----------------------------

    public void Add(OrderObject order)
    {
        try
        {
            OrderObject pro = GetOrderByID(order.OrderID);
            if (pro == null)
            {
                string SQLInsert = "Insert [dbo].[Order] values(@OrderID,@MemberID,@OrderDate,@RequiredDate,@ShippedDate,@Freight)";
                var parameters = new List<SqlParameter>();
                parameters.Add(dataProvider.CreateParameter("@OrderID", 4, order.MemberID, DbType.Int32));
                parameters.Add(dataProvider.CreateParameter("@MemberID", 100, order.MemberID, DbType.Int32));
                parameters.Add(dataProvider.CreateParameter("@OrderDate", 100, order.OrderDate, DbType.DateTime));
                parameters.Add(dataProvider.CreateParameter("@RequiredDate", 100, order.RequiredDate, DbType.DateTime));
                parameters.Add(dataProvider.CreateParameter("@ShippedDate", 100, order.ShippedDate, DbType.DateTime));
                parameters.Add(dataProvider.CreateParameter("@Freight", 100, order.Freight, DbType.Decimal));
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


    public void Update(OrderObject order)
    {
        try
        {
            OrderObject c = GetOrderByID(order.OrderID);
            if (c != null)
            {
                string SQLUpdate = "Update [dbo].[Order] set MemberID=@MemberID," +
                    " OrderDate=@OrderDate, RequiredDate=@RequiredDate, ShippedDate=@ShippedDate, Freight=@Freight  where OrderID=@OrderID";
                var parameters = new List<SqlParameter>();
                parameters.Add(dataProvider.CreateParameter("@OrderID", 4, order.MemberID, DbType.Int32));
                parameters.Add(dataProvider.CreateParameter("@MemberID", 100, order.MemberID, DbType.Int32));
                parameters.Add(dataProvider.CreateParameter("@OrderDate", 100, order.OrderDate, DbType.DateTime));
                parameters.Add(dataProvider.CreateParameter("@RequiredDate", 100, order.RequiredDate, DbType.DateTime));
                parameters.Add(dataProvider.CreateParameter("@ShippedDate", 100, order.ShippedDate, DbType.DateTime));
                parameters.Add(dataProvider.CreateParameter("@Freight", 100, order.Freight, DbType.Decimal));
                dataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());

            }
            else { throw new Exception("Order does not already exist"); }
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
            OrderObject order = GetOrderByID(orderID);
            if (orderID != null)
            {
                string SQLDelete = "Delete [dbo].[Order] where OrderID=@OrderID";
                var param = dataProvider.CreateParameter("@OrderID", 4, orderID, DbType.Int32);
                dataProvider.Delete(SQLDelete, CommandType.Text, param);
            }
            else
            {
                throw new Exception("Order does not already exist.");
            }

        }
        catch (Exception ex)
        {

            throw new Exception(ex.Message);
        }
        finally { CloseConnection(); }
    }


}
