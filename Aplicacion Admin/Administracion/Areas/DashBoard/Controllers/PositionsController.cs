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
    public class PositionsController : BasicController
    {
        // GET: DashBoard/Positions
        public ActionResult Index()
        {
            IEnumerable<Position> listPos = null;

            try
            {
                SessionInitialize();
                PositionCAD cadPos = new PositionCAD();
                PositionCEN cen = new PositionCEN(cadPos);

                IList<PositionEN> listPosEn = cen.ReadAll(0, -1);
                listPos = new AssemblerPosition().ConvertListENToModel(listPosEn).ToList();
                SessionClose();
            }
            catch(Exception ex)
            {
                TempData["resultado"] = Resources.textos.modelEmpty;
                TempData["ok"] = "warning";
            }
            

            ViewBag.menu = "Positions";
            return View(listPos);
        }

        // GET: DashBoard/Positions/Details/5
        public ActionResult Details(int id = 0)
        {
            SessionInitialize();

            string resultado = "";
            string locationNombre = Resources.textos.modelEmpty;
            PositionCAD cadPos = new PositionCAD();
            PositionCEN cen = new PositionCEN(cadPos);
            PositionEN posEN = cen.ReadOID(id);

            Dictionary<string, string> res = new Dictionary<string, string>();

            if (posEN != null)
            {
                if(posEN.Location != null)
                {
                    locationNombre = posEN.Location.Name; 
                }

                resultado = "<ul><li><strong>Id: </strong>" + posEN.Identifier + "</li><li><strong>Latitude: </strong>" + posEN.Latitude + "</li><li><strong>Longitude: </strong>" + posEN.Longitude + "</li><li><strong>Altitude: </strong>" + posEN.Altitude + "</li> <li><strong>Location: </strong>" + locationNombre + "</li></ul>";
                res.Add("titulo", Resources.textos.detailsModal + posEN.Identifier);
            }
            else
            {
                resultado = "<p>" + Resources.textos.errorDataModal + " "+ id.ToString() + "</p>";
                res.Add("titulo", Resources.textos.modalTitulo);
            }

            res.Add("contenido", resultado);

            SessionClose();

            return Json(res);
        }

        // GET: DashBoard/Positions/Create
        public ActionResult Create()
        {
            ViewBag.menu = "Positions";
            return View();
        }

        // POST: DashBoard/Positions/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            ViewBag.menu = "Positions";

            try
            {
                SessionInitialize();

                PositionCAD cadPos = new PositionCAD();
                PositionCEN cen = new PositionCEN(cadPos);

                double altitud = Convert.ToDouble(collection["altitude"]);
                double longitud = Convert.ToDouble(collection["longitude"]);
                double latitud = Convert.ToDouble(collection["latitude"]);

                cen.New_(latitud, longitud, altitud, -1);

                SessionClose();

                TempData["resultado"] = Resources.textos.createOK;
                TempData["ok"] = "success";

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                ViewBag.error = ex.Message;
                return View();
            }
        }

        // GET: DashBoard/Positions/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.menu = "Positions";
            PositionEN positionEN = null;
            Position pos = null;

            try
            {
                SessionInitialize();

                PositionCAD cadPos = new PositionCAD();
                PositionCEN cen = new PositionCEN(cadPos);

                positionEN = cen.ReadOID(id);
                pos = new AssemblerPosition().ConvertENToModelUI(positionEN);
                SessionClose();
            }
            catch (Exception ex)
            {
                ViewBag.error = "Error: " + ex.Message;
            }
            return View(pos);
        }

        // POST: DashBoard/Positions/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            ViewBag.menu = "Positions";
            PositionCAD cadPos = new PositionCAD();
            PositionCEN cen = new PositionCEN(cadPos);
            PositionEN positionEN = null;

            try
            {
                positionEN = cen.ReadOID(id);
                positionEN.Altitude = Convert.ToDouble(collection["altitude"]);
                positionEN.Longitude = Convert.ToDouble(collection["longitude"]);
                positionEN.Latitude = Convert.ToDouble(collection["latitude"]);

                cen.Modify(positionEN.Identifier, positionEN.Latitude, positionEN.Longitude, positionEN.Altitude);

                TempData["resultado"] = Resources.textos.editOK;
                TempData["ok"] = "success";

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                positionEN = cen.ReadOID(id);
                ViewBag.error = ex.Message;

                return View(positionEN);
            }
        }

        // GET: DashBoard/Positions/Delete/5
        public ActionResult Delete(int id)
        {
            ViewBag.menu = "Positions";

            SessionInitialize();

            PositionCAD cadPos = new PositionCAD();
            PositionCEN cen = new PositionCEN(cadPos);

            cen.Destroy(id);

            PositionEN pos = cen.ReadOID(id);
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

        // POST: DashBoard/Positions/Delete/5
        /*
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        */
        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            IEnumerable<Position> listPos = null;

            try
            {
                SessionInitialize();
                PositionCAD cadPos = new PositionCAD();
                PositionCEN cen = new PositionCEN(cadPos);

                IList<PositionEN> listPosEn = cen.ReadAll(0, -1);

                string orden = collection["hdnOrden"].ToString();
                switch (orden)
                {
                    case "N":
                        listPosEn = listPosEn.OrderBy(p => p.Latitude).ToList();
                        break;
                    case "P":
                        listPosEn = listPosEn.OrderBy(p => p.Longitude).ToList();
                        break;
                    case "Q":
                        listPosEn = listPosEn.OrderBy(p => p.Altitude).ToList();
                        break;
                    default:
                        listPosEn = listPosEn.OrderBy(p => p.Latitude).ToList();
                        break;
                }

                listPos = new AssemblerPosition().ConvertListENToModel(listPosEn).ToList();
                SessionClose();
            }
            catch (Exception ex)
            {
                TempData["resultado"] = Resources.textos.modelEmpty;
                TempData["ok"] = "warning";
            }


            ViewBag.menu = "Positions";
            return View(listPos);

            
        }
    }
}
