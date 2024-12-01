using modelBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace modelBinding.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult WithoutViewModel()
        {
            Student stuObj = new Student();
            stuObj.RollNo = 1;
            stuObj.StudentName = "Hong";

            Assessment assObj = new Assessment();
            assObj.asp = 90;
            assObj.mobile = 90;
            assObj.advanceNetwork = 70;
            assObj.isad = 60;

            ViewBag.assObj = assObj;

            return View(stuObj);
        }

        public ActionResult WithViewModel()
        {

            Student stuObj = new Student();
            stuObj.RollNo = 1;
            stuObj.StudentName = "Hong";

            Assessment assObj = new Assessment();
            assObj.asp = 90;
            assObj.mobile = 90;
            assObj.advanceNetwork = 70;
            assObj.isad = 60;

            Marksheet marksheetObj = new Marksheet();
            marksheetObj.student = stuObj;
            marksheetObj.assessment = assObj;

            return View(marksheetObj);
        }

    }
}