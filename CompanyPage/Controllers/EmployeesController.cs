using Microsoft.AspNetCore.Mvc;
using Database;
namespace CompanyPage.Controllers
{
    public class EmployeesController : Controller
    {
        public async Task<IActionResult> Index()
        {
            Database.Database db = new Database.Database();
            List<Employee> emploees = await db.GetAllEmployees();
            return View(emploees);
        }
        public async Task<IActionResult> Details(string Id)
        {
            Database.Database db = new Database.Database();
            var employee = await db.GetEmployById(Id);
            return View(employee);
        }
    }
}
