using Microsoft.AspNetCore.Mvc;
using Demo.Models;
using Microsoft.EntityFrameworkCore;
namespace Demo.Controllers
{
    public class DepartmentController : Controller
    {
        DemoEntity contex = new DemoEntity();
        public IActionResult Index()
        {
            List<Department> depListModels = contex.Departments.Include(d=>d.Employees).ToList();
            // return View("Index",depListModels);
            //if  u want to make a debudging and see the data in the view
            // make the breakpoint on the line below
            return View(depListModels);//we can use this also If the view name is same as action name
            // use cntrol +shift +b to make a build for the project
        }
    }
}
