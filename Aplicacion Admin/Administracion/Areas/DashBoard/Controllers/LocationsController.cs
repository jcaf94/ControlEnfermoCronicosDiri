using Administracion.Areas.DashBoard.Models;
using Administracion.Controllers;
using ChroniGenNHibernate.CAD.Chroni;
using ChroniGenNHibernate.CEN.Chroni;
using ChroniGenNHibernate.EN.Chroni;
using ChroniGenNHibernate.Enumerated.Chroni;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Administracion.Areas.DashBoard.Controllers
{
    public class LocationsController : BasicController
    {
        // GET: DashBoard/Locations
        public ActionResult Index()
        {
            IEnumerable<Location> listLoc = null;

            try
            {
                SessionInitialize();
                LocationCAD cadPos = new LocationCAD();
                LocationCEN cen = new LocationCEN(cadPos);

                IList<LocationEN> listLocEn = cen.ReadAll(0, -1);
                listLoc = new AssemblerLocation().ConvertListENToModel(listLocEn).ToList();
                SessionClose();
            }
            catch (Exception ex)
            {
                TempData["resultado"] = "No existen locations que mostrar.";
                TempData["ok"] = "warning";
            }


            ViewBag.menu = "Locations";
            return View(listLoc);
        }

        // GET: DashBoard/Locations/Details/5
        public ActionResult Details(int id = 0)
        {
            SessionInitialize();

            string resultado = "";
            LocationCAD cadLoc = new LocationCAD();
            LocationCEN cen = new LocationCEN(cadLoc);
            LocationEN locEN = cen.ReadOID(id);

            Dictionary<string, string> res = new Dictionary<string, string>();

            if (locEN != null)
            {
                
                resultado = "<ul><li><strong>Id: </strong>" + locEN.Identifier + "</li><li><strong>Nombre: </strong>" + locEN.Name + "</li><li><strong>Teléfono: </strong>" + locEN.Phone + "</li><li><strong>Email: </strong>" + locEN.Email + "</li> <li><strong>Código Postal: </strong>" + locEN.PostalCode + "</li> <li><strong>Dirección: </strong>" + locEN.Address + "</li> <li><strong>Organización: </strong>" + locEN.ManagingOrganization + "</li></ul>";
                res.Add("titulo", "Detalles de la localización ");
            }
            else
            {
                resultado = "<p>Error obteniendo los detalles de la localización: " + id.ToString() + "</p>";
                res.Add("titulo", "Atención!");
            }

            res.Add("contenido", resultado);

            SessionClose();

            return Json(res);
        }

        // GET: DashBoard/Locations/Create
        public ActionResult Create()
        {
            ViewBag.menu = "Locations";
            return View();
        }

        // POST: DashBoard/Locations/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            ViewBag.menu = "Locations";

            try
            {
                SessionInitialize();

                LocationCAD cadPos = new LocationCAD();
                LocationCEN cen = new LocationCEN(cadPos);

                string name = collection["Name"].ToString();
                string tel = collection["Phone"].ToString();
                string email = collection["Email"].ToString();
                string cod = collection["CodPostal"].ToString();


                cen.New_(LocationStatusEnum.active, name, "", LocationModeEnum.private_location, LocationTypeEnum.ambulance, "", LocationPhysicalTypeEnum.building, "ORM", tel, email,cod);

                SessionClose();

                TempData["resultado"] = "Localizacion creada correctamente.";
                TempData["ok"] = "success";

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.error = ex.Message;
                return View();
            }
        }

        // GET: DashBoard/Locations/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.menu = "Locations";
            LocationEN locationEN = null;
            Location loc = null;

            try
            {
                SessionInitialize();

                LocationCAD cadPos = new LocationCAD();
                LocationCEN cen = new LocationCEN(cadPos);

                locationEN = cen.ReadOID(id);
                loc = new AssemblerLocation().ConvertENToModelUI(locationEN);
                SessionClose();
            }
            catch (Exception ex)
            {
                ViewBag.error = "Error, causa: " + ex.Message;
            }
            return View(loc);
        }

        // POST: DashBoard/Locations/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            ViewBag.menu = "Locations";
            LocationCAD cadPos = new LocationCAD();
            LocationCEN cen = new LocationCEN(cadPos);
            LocationEN positionEN = null;

            try
            {
                positionEN = cen.ReadOID(id);
                positionEN.Name = collection["Name"].ToString();
                positionEN.Email = collection["Email"].ToString();
                positionEN.Phone = collection["Phone"].ToString();
                positionEN.PostalCode = collection["CodPostal"].ToString();

                cen.Modify(positionEN.Identifier, positionEN.Status, positionEN.Name, positionEN.Description, positionEN.Mode, positionEN.Type, positionEN.Address, positionEN.PhysicalType, positionEN.ManagingOrganization, positionEN.Phone, positionEN.Email, positionEN.PostalCode);

                TempData["resultado"] = "Localizacion modificada correctamente.";
                TempData["ok"] = "success";

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                positionEN = cen.ReadOID(id);
                ViewBag.error = ex.Message;

                return View(positionEN);
            }
        }

        // GET: DashBoard/Locations/Delete/5
        public ActionResult Delete(int id)
        {
            ViewBag.menu = "Locations";

            SessionInitialize();

            LocationCAD cadPos = new LocationCAD();
            LocationCEN cen = new LocationCEN(cadPos);

            cen.Destroy(id);

            LocationEN pos = cen.ReadOID(id);
            SessionClose();


            if (pos == null)
            {
                TempData["resultado"] = "Location eliminada correctamente";
                TempData["ok"] = "success";
            }
            else
            {
                TempData["resultado"] = "Error al eliminar la location, pruébelo más tarde";
                TempData["ok"] = "danger";
            }

            return RedirectToAction("Index");
        }

        // POST: DashBoard/Locations/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
