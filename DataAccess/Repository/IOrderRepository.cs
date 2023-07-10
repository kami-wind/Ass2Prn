using BusinessObject;

namespace DataAccess.Repository;

public interface IOrderRepository
{
    IEnumerable<OrderObject> GetOrder();
    OrderObject GetOrderById(int OrderID);
    void InsertOrder(OrderObject order);
    void UpdateOrder(OrderObject order);
    void DeleteOrder(int OrderID);
}
