using Administracion.Areas.DashBoard.Models;
using Administracion.Controllers;
using ChroniGenNHibernate.CAD.Chroni;
using ChroniGenNHibernate.CEN.Chroni;
using ChroniGenNHibernate.EN.Chroni;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Administracion.Areas.DashBoard.Controllers
{
    public class EspecialidadController : BasicController
    {
        // GET: DashBoard/Especialidad
        public ActionResult Index()
        {
            IEnumerable<Especialidad> listLoc = null;

            try
            {
                SessionInitialize();
                SpecialtyCAD cadSpecialty = new SpecialtyCAD();
                SpecialtyCEN cen = new SpecialtyCEN(cadSpecialty);

                IList<SpecialtyEN> listSpeEn = cen.ReadAll(0, -1);
                listLoc = new AssemblerEspecialidad().ConvertListENToModel(listSpeEn).ToList();
                SessionClose();
            }
            catch (Exception ex)
            {
                TempData["resultado"] = Resources.textos.modelEmpty;
                TempData["ok"] = "warning";
            }


            ViewBag.menu = "Specialities";
            return View(listLoc);
        }

        // GET: DashBoard/Especialidad/Details/5
        public ActionResult Details(int id = 0)
        {
            SessionInitialize();

            string resultado = "";
            SpecialtyCAD cadLoc = new SpecialtyCAD();
            SpecialtyCEN cen = new SpecialtyCEN(cadLoc);
            SpecialtyEN locEN = cen.ReadOID(id);

            Dictionary<string, string> res = new Dictionary<string, string>();

            if (locEN != null)
            {

                resultado = "<ul><li><strong>Id: </strong>" + locEN.Identifier + "</li><li><strong>Código: </strong>" + locEN.Code + "</li><li><strong>Nombre: </strong>" + locEN.Display + "</ul>";
                res.Add("titulo", Resources.textos.detailsModal);
            }
            else
            {
                resultado = "<p>" + Resources.textos.errorDataModal + " " + id.ToString() + "</p>";
                res.Add("titulo", Resources.textos.modalTitulo);
            }

            res.Add("contenido", resultado);

            SessionClose();

            return Json(res);
        }

        // GET: DashBoard/Especialidad/Create
        public ActionResult Create()
        {
            ViewBag.menu = "Specialities";
            return View();
        }

        // POST: DashBoard/Especialidad/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            ViewBag.menu = "Specialities";

            try
            {
                SessionInitialize();

                SpecialtyCAD cadPos = new SpecialtyCAD();
                SpecialtyCEN cen = new SpecialtyCEN(cadPos);

                string name = collection["Nombre"].ToString();

                Random r = new Random();
                int aleatorio = r.Next(0, 100000);

                cen.New_(aleatorio.ToString(), name);

                SessionClose();

                TempData["resultado"] = Resources.textos.createOK;
                TempData["ok"] = "success";

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.error = ex.Message;
                return View();
            }
        }

        // GET: DashBoard/Especialidad/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.menu = "Specialities";
            SpecialtyEN locationEN = null;
            Especialidad loc = null;

            try
            {
                SessionInitialize();

                SpecialtyCAD cadPos = new SpecialtyCAD();
                SpecialtyCEN cen = new SpecialtyCEN(cadPos);

                locationEN = cen.ReadOID(id);
                loc = new AssemblerEspecialidad().ConvertENToModelUI(locationEN);
                SessionClose();
            }
            catch (Exception ex)
            {
                ViewBag.error = "Error: " + ex.Message;
            }
            return View(loc);
        }

        // POST: DashBoard/Especialidad/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            ViewBag.menu = "Specialities";
            SpecialtyCAD cadPos = new SpecialtyCAD();
            SpecialtyCEN cen = new SpecialtyCEN(cadPos);
            SpecialtyEN positionEN = null;

            try
            {
                positionEN = cen.ReadOID(id);
                positionEN.Display = collection["Nombre"].ToString();

                cen.Modify(positionEN.Identifier, positionEN.Code, positionEN.Display);

                TempData["resultado"] = Resources.textos.editOK;
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

        // GET: DashBoard/Especialidad/Delete/5
        public ActionResult Delete(int id)
        {
            ViewBag.menu = "Specialities";

            SessionInitialize();

            SpecialtyCAD cadPos = new SpecialtyCAD();
            SpecialtyCEN cen = new SpecialtyCEN(cadPos);

            cen.Destroy(id);

            SpecialtyEN pos = cen.ReadOID(id);
            SessionClose();


            if (pos == null)
            {
                TempData["resultado"] = Resources.textos.deleteOK;
                TempData["ok"] = "success";
            }
            else
            {
                TempData["resultado"] = Resources.textos.errorKO;
                TempData["ok"] = "danger";
            }

            return RedirectToAction("Index");
        }

        // POST: DashBoard/Especialidad/Delete/5
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
