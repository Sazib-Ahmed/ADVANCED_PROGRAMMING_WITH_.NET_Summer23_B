using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: Portfolio
        public ActionResult Index()
        {
            string name = "MD.Sazib Ahmed";
            string email = "mail.sazibahmed@gmail.com";
            string bio = "MD. Sazib Ahmed is a Computer Science Engineering (CSE) student with a passion for all things tech-related. With a curious mind and a knack for problem-solving, Sazib dives into the fascinating world of programming languages, algorithms, and software development.\r\n\r\nFrom an early age, Sazib's love for computers and technology sparked an interest in pursuing a career in CSE. As a student, Sazib immerses himself in the world of coding, constantly exploring new programming languages, frameworks, and tools.";
            ViewBag.Name = name;
            ViewBag.Email = email;
            ViewBag.Bio = bio;
            return View();
        }

        public ActionResult Profile()
        {
            MyProfile s1 = new MyProfile();
            s1.Name = "MD. Sazib Ahmed";
            s1.Dob = "8/4/2000";
            s1.Nation = "Bangladeshi";
            s1.BGroup = "A+";
            s1.Address = "Dhaka, Bangladesh";
            s1.ContactNo = "+8801871887499";
            s1.Hobbies = new List<string>
            {
                "Gaming",
                "Reading",
                "Traveling"
            };
            return View(s1);
        }

        public ActionResult Education()
        {
            MyEducation e1 = new MyEducation();
            e1.Title = "BSC";
            e1.Institution = "AIUB";
            e1.Year = "4th year";

            MyEducation e2 = new MyEducation();
            e2.Title = "HSC";
            e2.Institution = "Science";
            e2.Year = "2018";

            MyEducation e3 = new MyEducation();
            e3.Title = "SSC";
            e3.Institution = "Science";
            e3.Year = "2016";

            MyEducation[] edu = new MyEducation[] { e1, e2, e3 };
            ViewBag.Edus = edu;

            return View();
        }

        public ActionResult Projects()
        {
            MyProjects p1 = new MyProjects();
            p1.Course = "Computer Graphics";
            p1.Description = "Somewhere in Banderban";

            MyProjects p2 = new MyProjects();
            p2.Course = "Advanced Webtech";
            p2.Description = "GreenFoot: A planet saver";

            MyProjects p3 = new MyProjects();
            p3.Course = "Software Engineering";
            p3.Description = "Personal Patient management system for doctors";

            var projects = new List<MyProjects> { p1, p2, p3 };

            return View(projects);
        }

        public ActionResult References()
        {
            return View();
        }
    }
}