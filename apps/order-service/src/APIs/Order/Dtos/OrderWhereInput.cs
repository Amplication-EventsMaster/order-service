namespace OrderService.APIs.Dtos;

public class OrderWhereInput
{
    public DateTime? CreatedAt { get; set; }

    public string? Customer { get; set; }

    public string? Id { get; set; }

    public DateTime? OrderDate { get; set; }

    public double? TotalAmount { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
