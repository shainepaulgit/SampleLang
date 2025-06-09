using Microsoft.AspNetCore.Mvc;

namespace MVCApproachPractice.Controllers
{
    public class ProductController:Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
