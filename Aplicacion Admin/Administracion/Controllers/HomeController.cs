using Administracion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using ChroniGenNHibernate.CAD.Chroni;
using ChroniGenNHibernate.CEN.Chroni;

namespace Administracion.Controllers
{
    public class HomeController : BasicController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //
        // POST: /Articulo/Create
        [HttpPost]
        public ActionResult Acceso(Acceso acc)
        {
            try
            {
                Acceso acceso = new Acceso();

                if (!String.IsNullOrWhiteSpace(acc.Nombre))
                {
                    if(!String.IsNullOrWhiteSpace(acc.Pass))
                    {
                        SessionInitialize();

                        AdministratorCAD administratorCAD = new AdministratorCAD();
                        AdministratorCEN administratorCEN = new AdministratorCEN(administratorCAD);
                        int idAdministrador = administratorCEN.Login(acc.Nombre, acc.Pass);

                        SessionClose();

                        if(idAdministrador != -1)
                        {
                            return RedirectToAction("Index", "DashBoard", new { area = "DashBoard" });
                        }
                    }
                }
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index");
            }
        }

        public ActionResult Idioma(string lang, string returnUrl)
        {
            Session["Cultura"] = new System.Globalization.CultureInfo(lang);
            return Redirect(returnUrl);
        }
    }
}