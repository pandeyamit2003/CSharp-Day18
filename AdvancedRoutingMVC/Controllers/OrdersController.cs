using Microsoft.AspNetCore.Mvc;

namespace AdvancedRoutingMVC.Controllers
{
    public class OrdersController : Controller
    {
        // Route Example:
        // /Orders/550e8400-e29b-41d4-a716-446655440000

        [Route("Orders/{id:guidcheck}")]
        public IActionResult Details(Guid id)
        {
            ViewBag.OrderId = id;

            return View();
        }
    }
}