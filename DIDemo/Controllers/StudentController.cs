using DIDemo.Models;
using DIDemo.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DIDemo.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService service;
        public StudentController(IStudentService service)
        {
            this.service = service;
        }

        // GET: StudentController
        public ActionResult Index()
        {
           var stu= service.GetAllStudent();
            return View(stu);
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
           var stu= service.GetStudentByRollno(id);
            return View(stu);
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student stu)
        {
            try
            {
               int result= service.AddStudent(stu);
                if(result==1)
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
            return View();
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            var stu = service.GetStudentByRollno(id);
            return View(stu);
            
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Student stu)
        {
            try
            {
                int result=service.UpdateStudent(stu);
                if(result==1)
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
            return View();
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            var stu = service.GetStudentByRollno(id);
            return View(stu);
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            try
            {
               int result= service.DeleteStudent(id);
                if(result==1)
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
            return View();
        }
    }
}
