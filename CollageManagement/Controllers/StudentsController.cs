using System;
using System.Web.Mvc;
using CollageManagement.BLL;
using CollageManagement.Models;

namespace CollageManagement.Controllers
{
    public class StudentsController : Controller
    {
        private StudentBll _studentBll = new StudentBll();
        public ActionResult Add()
        {
            return View();
        }  

        [HttpPost]
        public ActionResult Add(Student student)
        {
            try
            {  
                var isAdded= _studentBll.Add(student);
                if (isAdded)
                {
                    return ViewBag.SMsg = "Save Success.";
                }
                else
                {
                    return ViewBag.FMsg = "Save Faild.";
                }

            }
            catch (Exception exception)
            {
                return ViewBag.FMsg = exception.Message;
            }

            return View();

        }

	}
}