using AirCondSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AirCondSystem.Controllers
{
    public class HomeController : Controller
    {
        AirCondContext db = new AirCondContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult WallsPartial()
        {
            return PartialView(db.Walls.ToList());
        }

        public ActionResult WindowsPartial()
        {
            return PartialView(db.Windows.ToList());
        }

        public ActionResult CeilingPartial()
        {
            return PartialView();
        }

        public ActionResult FloorPartial()
        {
            return PartialView();
        }

        public ActionResult DoorsPartial()
        {
            return PartialView(db.Doors.ToList());
        }
        
        public string CalcWalls()
        {
            string s = Request.Params["side"];
            int f = Int32.Parse(Request.Params["f"]);
            int j = Int32.Parse(Request.Params["j"]);
            double l = 1;//Double.Parse(Request.Params["l"]);
            int n = 1;
            int t = 42;
            double b;

            if (s == "С, В, С-В, С-З")
            {
                b = 0.1;
            }
            else b = 0.05;

            double r = j / l;
            double result = t / r * f * n * (1 + b);
            return "<h3><b> Теплопотери через наружные стены, Вт </b>" + result + "</h3>";
        }

        public string CalcWindows()
        {
            string s = Request.Params["side"];
            int f = Int32.Parse(Request.Params["f"]);
            double r = Double.Parse(Request.Params["r"]);
            int n = 1;
            int t = 42;
            double b;

            if (s == "С, В, С-В, С-З")
            {
                b = 0.1;
            }
            else b = 0.05;

            double result = t / r * f * n * (1 + b);
            return "<h3><b> Теплопотери через окна, Вт </b>" + result + "</h3>";
        }

        public string CalcDoors()
        {
            string s = Request.Params["side"];
            double l = Double.Parse(Request.Params["l"]);
            int f = Int32.Parse(Request.Params["f"]);
            int j = Int32.Parse(Request.Params["j"]);
            int n = 1;
            int t = 42;
            double b;

            if (s == "С, В, С-В, С-З")
            {
                b = 0.1;
            }
            else b = 0.05;
            
            double r = j / l;
            double result = t / r * f * n * (1 + b);
            return "<h3><b> Теплопотери через наружные двери, Вт </b>" + result + "</h3>";
        }
    }
}