using BusinessObject;

namespace DataAccess.Repository;

public interface IOrderDetailRepository
{
    IEnumerable<OrderDetailObject> GetOrderDetail();
    OrderDetailObject GetOrderDetailById(int OrderID);
    void InsertOrderDetail(OrderDetailObject order);
    void UpdateOrderDetail(OrderDetailObject order);
    void DeleteOrderDetail(int OrderID);
}
