using MVCAutosAjaxJson.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAutosAjaxJson.Controllers
{
    public class AutoController : Controller
    {
        // GET: Auto
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewAll()
        {
            return View(GetAllAuto());
        }

        IEnumerable<CarShow> GetAllAuto()
        {
            using (DBModel db = new DBModel())
            {
                return db.CarShows.ToList<CarShow>();
            }
        }


        public ActionResult AddOrEdit(int id = 0)
        {
            CarShow zoom = new CarShow();

            return View(zoom);
        }

        [HttpPost]
        public ActionResult AddOrEdit(CarShow c)
        {
            if(c.ImagePath != null )
            {
                string fileName = Path.GetFileNameWithoutExtension(c.ImageUpload.FileName);
                string extension = Path.GetExtension(c.ImageUpload.FileName);
                fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                c.ImagePath = "~/Appfiles/Images/" + fileName;
                c.ImageUpload.SaveAs(Path.Combine(Server.MapPath("~/Appfiles/Images/"), fileName));
            }

            using (DBModel db = new DBModel())
            {
                db.CarShows.Add(c);
                db.SaveChanges();
            }

                return View();
        }

    }
}