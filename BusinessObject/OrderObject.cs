namespace BusinessObject;

public class OrderObject
{
    public int OrderID { get; set; }
    public int MemberID { get; set; }
    public DateTime OrderDate { get; set; }
    public DateTime RequiredDate { get; set; }
    public DateTime ShippedDate { get; set; }
    public decimal Freight { get; set; }

}
