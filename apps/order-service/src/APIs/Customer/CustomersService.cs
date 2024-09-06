using OrderService.Infrastructure;

namespace OrderService.APIs;

public class CustomersService : CustomersServiceBase
{
    public CustomersService(OrderServiceDbContext context)
        : base(context) { }
}
