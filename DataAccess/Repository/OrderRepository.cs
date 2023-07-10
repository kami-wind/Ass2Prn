using BusinessObject;

namespace DataAccess.Repository;

public class OrderRepository : IOrderRepository
{
    public void DeleteOrder(int OrderID) => OrderDAO.Instance.Remove(OrderID);


    public IEnumerable<OrderObject> GetOrder() => OrderDAO.Instance.GetOrderList(); 


    public OrderObject GetOrderById(int OrderID) => OrderDAO.Instance.GetOrderByID(OrderID);
    

    public void InsertOrder(OrderObject order) => OrderDAO.Instance.Add(order);
    

    public void UpdateOrder(OrderObject order) => OrderDAO.Instance.Update(order);
    
}
