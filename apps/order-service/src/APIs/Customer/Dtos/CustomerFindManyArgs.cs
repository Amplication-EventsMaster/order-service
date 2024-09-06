using Microsoft.AspNetCore.Mvc;
using OrderService.APIs.Common;
using OrderService.Infrastructure.Models;

namespace OrderService.APIs.Dtos;

[BindProperties(SupportsGet = true)]
public class CustomerFindManyArgs : FindManyInput<Customer, CustomerWhereInput> { }
