using Microsoft.AspNetCore.Mvc;
using SquirrelAPI.Models;

namespace SquirrelAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private static readonly List<Customer> Customers = new()
        {
            new Customer { Id = 1, HoTen = "Nguyễn Văn A", Email = "anguyen@gmail.com", SoDienThoai = "0901234567" },
            new Customer { Id = 2, HoTen = "Trần Thị B", Email = "btran@gmail.com",  SoDienThoai = "0987654321" },
            new Customer { Id = 3, HoTen = "Lê Văn C",    Email = "cle@gmail.com",   SoDienThoai = "0912345678" },
            new Customer { Id = 4, HoTen = "Phạm Thị D",  Email = "dpham@gmail.com", SoDienThoai = "0922334455" },
            new Customer { Id = 5, HoTen = "Hoàng Văn E", Email = "ehoang@gmail.com",SoDienThoai = "0966778899" }
        };

        [HttpGet]
        public IActionResult Get() => Ok(Customers);
    }
}