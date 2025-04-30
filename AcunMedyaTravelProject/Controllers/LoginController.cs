using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using AcunMedyaTravelProject.Entities;
namespace AcunMedyaTravelProject.Controllers
{
    [AllowAnonymous]
    //Sweet alert yapısı, dashboard, 404 sayfası ekleyeceğiz
    public class LoginController : Controller
    {
        AcunMedyaTravelProject.Context.Context _Context = new AcunMedyaTravelProject.Context.Context();
        public ActionResult Index()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return View();
        }
        
        [HttpPost]
        public ActionResult Index(Admin model)//test 123123
        {
            // && || 
            //Girilen kullancıı adı veri tabanındanki veriyle eşleşeen sütunu getir
            var values = _Context.Admins.FirstOrDefault(x=>x.UserName == model.UserName && x.Password == model.Password);

            if(values == null)
            {
                //sayfaya hata mesajı göster
                ModelState.AddModelError(string.Empty, "Kullanıcı adı ve şifre hatalı");
                return View(model);
            }

            FormsAuthentication.SetAuthCookie(model.UserName,false);

            //Geçici veri viewbag mantığını düşünebilirsiniz.
            Session["currentUser"] = model.UserName;




            return RedirectToAction("Index","Services");
        }

        public ActionResult LogOut()
        {
            return View();
        }
    }
}