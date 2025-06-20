using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.ILP2025.EmployeeCRUD.Repositores;
using Microsoft.ILP2025.EmployeeCRUD.Servcies;
using Microsoft.ILP2025.EmployeeCRUD.Entities;

namespace Microsoft.ILP2025.EmployeeCRUD.Web.Controllers
{
    public class EmployeeController : Controller
    {
        public IEmployeeService employeeService { get; set; }

        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        // GET: EmployeeController
        public async Task<ActionResult> Index()
        {
            var employees = await this.employeeService.GetAllEmployees();
            return View(employees);
        }

        // GET: EmployeeController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var employee = await this.employeeService.GetEmployee(id);
            return View(employee);
        }

        public IActionResult Create(EmployeeEntity emp)
        {
            employeeService.Create(emp);
            return View(emp);
        }    
    }
}
