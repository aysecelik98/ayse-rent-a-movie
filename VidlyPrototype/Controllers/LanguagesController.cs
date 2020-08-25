using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace VidlyPrototype.Controllers
    //sayfanın dilini değiştirmek için tanımlamn controller
{
    public class LanguagesController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Change(string LanguageAbbreviation)
        {
            if(LanguageAbbreviation != null)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(LanguageAbbreviation);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(LanguageAbbreviation);

            }

            HttpCookie cookie = new HttpCookie("Language");//baska bır sayfaya gıdınce o dılı kullanacak
            cookie.Value = LanguageAbbreviation;
            Response.Cookies.Add(cookie);

            if (Request.QueryString["ReturnURL"] != null)
                return Redirect(Request.QueryString["ReturnURL"]);
            else
                return RedirectToAction("Index", "Home");
        }
    }
}