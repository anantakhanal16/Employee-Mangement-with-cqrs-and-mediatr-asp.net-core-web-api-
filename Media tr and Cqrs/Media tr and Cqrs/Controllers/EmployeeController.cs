using Microsoft.AspNetCore.Mvc;

namespace Media_tr_and_Cqrs.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
