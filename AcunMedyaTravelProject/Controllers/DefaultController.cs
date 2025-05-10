using AcunMedyaTravelProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaTravelProject.Controllers
{
    public class DefaultController : Controller
    {
        AcunMedyaTravelProject.Context.Context _context = new AcunMedyaTravelProject.Context.Context();

        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialTurlar()
        {
            return PartialView();

        }

        [HttpGet]
        public JsonResult PartialContact(Category model)
        {
            //category değil mesajlar tablosu olacak
            if(ModelState.IsValid)
            {
                _context.Categories.Add(model);
                _context.SaveChanges();
                return Json(new { success = true, message= "Tebrikler Abone oldunuz" });
            }
            else
            {
                return Json(new { success = false, message = "Hata abone olamadınız" });

            }


        }
    }
}