using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeMangement.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: EmployeeController
        public ActionResult Index()
        {
            return View();
        }

        public string Hello()
        {
            return "hello  hai  Vishnu";
        }



        public ActionResult page2()
        {
            return View();
        }




       
    }
}
