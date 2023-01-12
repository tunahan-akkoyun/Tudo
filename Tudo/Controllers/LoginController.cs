using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tudo.Models;

namespace Tudo.Controllers
{
    public class LoginController : Controller
    {
        NarailDBEntities2 db = new NarailDBEntities2();
        public ActionResult Index()
        {
            
            return View();
        }
        public ActionResult Giris()
        {

            return View();
        }
    }
}