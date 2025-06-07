using Microsoft.AspNetCore.Mvc;
using Demo.Models;
namespace Demo.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ShowAll()
        {
            StudentSampleData studentData = new StudentSampleData();
            List<Student> students = studentData.GetAllStudents();
            return View(students);
        }
        public IActionResult Details(int id)
        {
            StudentSampleData studentData = new StudentSampleData();
            Student student = studentData.GetStudentByID(id);
            if (student == null)
            {
                return NotFound();
            }
            return View("StudentsDetails",student);
        }
        public IActionResult GetAll()
        {
            StudentSampleData studentData = new StudentSampleData();
            List<Student> students = studentData.GetAllStudents();
            return View("StudentShowsAll", students);
        }
    }
}
