using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace minhlamcons.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin")]
    [Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}