using LeVanTru1409.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeVanTru1409.Controllers
{
    public class Student1Controller : Controller
    {
        public IActionResult Index2()
        {
            // Khoi tao 1 list student
            List<Student1> StdList = new List<Student1>()
            {
                new Student1 {StudentID2 = 1, StudentName2 = "Sinh Vien Tru", StudentAge2 = 18 },
                new Student1 {StudentID2 = 2, StudentName2 = "Sinh Vien B", StudentAge2 = 17 },
                new Student1 {StudentID2 = 3, StudentName2 = "Sinh Vien C", StudentAge2 = 21 },
                new Student1 {StudentID2 = 4, StudentName2 = "Sinh Vien D", StudentAge2 = 18 },
                new Student1 {StudentID2 = 5, StudentName2 = "Sinh Vien E", StudentAge2 = 22 },
            };
            ViewData["Student1"] = StdList;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student1Controller std)
        {
            // string message = std.StudentID + "-";
            // message += std.StudentName + "-";
            // message += std.Age;
            // ViewBag.TT = message;
            return View();
        }
    }
}
