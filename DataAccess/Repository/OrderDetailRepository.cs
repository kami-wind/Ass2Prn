using BusinessObject;

namespace DataAccess.Repository;

public class OrderDetailRepository : IOrderDetailRepository
{
    public void DeleteOrderDetail(int OrderID) => OrderDetailDAO.Instance.Remove(OrderID);


    public IEnumerable<OrderDetailObject> GetOrderDetail() => OrderDetailDAO.Instance.GetOrderDetailList();

    public OrderDetailObject GetOrderDetailById(int OrderID) => OrderDetailDAO.Instance.GetOrderDetailByID(OrderID);
    

    public void InsertOrderDetail(OrderDetailObject order) => OrderDetailDAO.Instance.Add(order);
    

    public void UpdateOrderDetail(OrderDetailObject order) => OrderDetailDAO.Instance.Update(order);
    
}
