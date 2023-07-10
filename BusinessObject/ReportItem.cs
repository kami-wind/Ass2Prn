namespace BusinessObject;

public class ReportItem
{
    public int OrderID { get; set; }
    public decimal TotalSales { get; set; }
    public DateTime OrderDate { get; set; }
    public string? ProductName { get; set; }
    public decimal UnitPrice { get; set; }
    public int Quantity { get; set; }
}
