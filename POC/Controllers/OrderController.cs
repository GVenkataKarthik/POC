using Microsoft.AspNetCore.Mvc;
using POC.Database;
using POC.Models;

namespace POC.Controllers
{
    public class OrderController : Controller
    {

        private readonly ApplicationDBContext _objDBContext;
        public OrderController(ApplicationDBContext objDBContext)
        {
            _objDBContext = objDBContext;
        }
        public IActionResult Orders()
        {
            List<Orders> objOrders = _objDBContext.Orders.ToList();
            return View(objOrders);
        }
    }
}
