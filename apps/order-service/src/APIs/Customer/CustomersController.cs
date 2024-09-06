using Microsoft.AspNetCore.Mvc;

namespace OrderService.APIs;

[ApiController()]
public class CustomersController : CustomersControllerBase
{
    public CustomersController(ICustomersService service)
        : base(service) { }
}
