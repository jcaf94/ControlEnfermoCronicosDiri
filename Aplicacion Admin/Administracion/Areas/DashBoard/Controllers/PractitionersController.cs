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
    public class PractitionersController : BasicController
    {
        // GET: DashBoard/Practitioners
        public ActionResult Index()
        {
            IEnumerable<Practitioner> listPos = null;

            try
            {
                SessionInitialize();
                PractitionerCAD cadPrac = new PractitionerCAD();
                PractitionerCEN cen = new PractitionerCEN(cadPrac);

                SpecialtyCAD speCad = new SpecialtyCAD();
                SpecialtyCEN speCen = new SpecialtyCEN(speCad);

                IList<PractitionerEN> listPosEn = cen.ReadAll(0, -1);
                listPos = new AssemblerPractitioner().ConvertListENToModel(listPosEn).ToList();

                foreach(Practitioner prac in listPos)
                {
                    if (prac.Especialidad > 0)
                    {
                        prac.DescripcionEsp = speCen.ReadOID(prac.Especialidad).Display;
                    }
                    else
                    {
                        prac.DescripcionEsp = Resources.textos.modelEmpty;
                    }
                }

                SessionClose();
            }
            catch (Exception ex)
            {
                TempData["resultado"] = Resources.textos.modelEmpty;
                TempData["ok"] = "warning";
            }


            ViewBag.menu = "Practitioners";
            return View(listPos);
        }

        // GET: DashBoard/Practitioners/Details/5
        public ActionResult Details(int id)
        {
            SessionInitialize();

            string resultado = "";
            string specialidad = "";

            PractitionerCAD cadLoc = new PractitionerCAD();
            PractitionerCEN cen = new PractitionerCEN(cadLoc);

            SpecialtyCAD speCad = new SpecialtyCAD();
            SpecialtyCEN speCen = new SpecialtyCEN(speCad);

            PractitionerEN locEN = cen.ReadOID(id);

            if(locEN.Specialty != null && locEN.Specialty.Identifier > 0)
            {
                SpecialtyEN specEN = speCen.ReadOID(locEN.Specialty.Identifier);
                specialidad = specEN.Display;
            }
            else
            {
                specialidad = Resources.textos.modelEmpty;
            }

            Dictionary<string, string> res = new Dictionary<string, string>();

            if (locEN != null)
            {

                resultado = "<ul><li><strong>Id: </strong>" + locEN.Identifier + "</li><li><strong>Nombre: </strong>" + locEN.Name + "</li><li><strong>Teléfono: </strong>" + locEN.Phone + "</li><li><strong>Email: </strong>" + locEN.Email + "</li> <li><strong>Especialidad: </strong>" + specialidad + "</li> <li><strong>Dirección: </strong>" + locEN.Address + "</li></ul>";
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

        // GET: DashBoard/Practitioners/Create
        public ActionResult Create()
        {
            ViewBag.menu = "Practitioners";

            SpecialtyCAD speCad = new SpecialtyCAD();
            SpecialtyCEN speCen = new SpecialtyCEN(speCad);
            SpecialtyEN speEn = new SpecialtyEN();

            speEn.Identifier = 0;
            speEn.Display = "Ninguna especialidad";

            IList<SpecialtyEN> especialidadesBD = speCen.ReadAll(0, -1);
            especialidadesBD.Insert(0, speEn);

            var especialidades = especialidadesBD.OrderBy(p => p.Identifier);
            ViewBag.especialidades = new SelectList(especialidades, "identifier", "display");

            return View();
        }

        // POST: DashBoard/Practitioners/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            ViewBag.menu = "Practitioners";

            try
            {
                SessionInitialize();

                
                PractitionerCAD cadPos = new PractitionerCAD();
                PractitionerCEN cen = new PractitionerCEN(cadPos);

                string name = collection["Name"].ToString();
                string tel = collection["Phone"].ToString();
                string email = collection["Email"].ToString();
                int esp = Convert.ToInt32(collection["especialidades"]);

                int id = cen.New_("-", true, PractitionerRoleEnum.physician, name, "-", GenderEnum.unknown, DateTime.Now, "-", email, tel, "-", DateTime.Now, DateTime.Now, null , "-");

                if(esp > 0)
                {
                    cen.AssignSpecialty(id, esp);
                }

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

        // GET: DashBoard/Practitioners/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.menu = "Practitioners";
            PractitionerEN locationEN = null;
            Practitioner loc = null;

            try
            {
                SessionInitialize();

                PractitionerCAD cadPos = new PractitionerCAD();
                PractitionerCEN cen = new PractitionerCEN(cadPos);

                SpecialtyCAD speCad = new SpecialtyCAD();
                SpecialtyCEN speCen = new SpecialtyCEN(speCad);
                SpecialtyEN speEn = new SpecialtyEN();

                locationEN = cen.ReadOID(id);
                loc = new AssemblerPractitioner().ConvertENToModelUI(locationEN);

                speEn.Identifier = 0;
                speEn.Display = Administracion.Resources.textos.errorKO;

                IList<SpecialtyEN> especialidadesBD = speCen.ReadAll(0, -1);
                especialidadesBD.Insert(0, speEn);

                var especialidades = especialidadesBD.OrderBy(p => p.Identifier);
                ViewBag.especialidades = new SelectList(especialidades, "identifier", "display", loc.Especialidad);

                SessionClose();
            }
            catch (Exception ex)
            {
                ViewBag.error = "Error" + ex.Message;
            }
            return View(loc);
        }

        // POST: DashBoard/Practitioners/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            ViewBag.menu = "Practitioners";
            PractitionerCAD cadPos = new PractitionerCAD();
            PractitionerCEN cen = new PractitionerCEN(cadPos);
            PractitionerEN positionEN = null;

            try
            {
                positionEN = cen.ReadOID(id);
                positionEN.Name = collection["Name"].ToString();
                positionEN.Email = collection["Email"].ToString();
                positionEN.Phone = collection["Phone"].ToString();
                int esp = Convert.ToInt32(collection["especialidades"]);

                if(positionEN.Specialty != null)
                {
                    if(esp > 0)
                    {
                        cen.UnassignSpecialty(positionEN.Identifier, positionEN.Specialty.Identifier);
                        cen.AssignSpecialty(positionEN.Identifier, esp);
                    }
                    else
                    {
                        cen.UnassignSpecialty(positionEN.Identifier, positionEN.Specialty.Identifier);
                    }
                }
                else
                {
                    if(esp > 0)
                    {
                        cen.AssignSpecialty(positionEN.Identifier, esp);
                    }
                }

                cen.Modify(positionEN.Identifier, positionEN.Nif, positionEN.Active, positionEN.Role, positionEN.Name, positionEN.Surnames, positionEN.Gender, positionEN.BirthDate, positionEN.Address, positionEN.Email, positionEN.Phone, positionEN.Photo, positionEN.StartDate, positionEN.EndDate, positionEN.Password);

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

        // GET: DashBoard/Practitioners/Delete/5
        public ActionResult Delete(int id)
        {
            ViewBag.menu = "Practitioners";

            SessionInitialize();

            PractitionerCAD cadPos = new PractitionerCAD();
            PractitionerCEN cen = new PractitionerCEN(cadPos);

            cen.Destroy(id);

            PractitionerEN pos = cen.ReadOID(id);
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

        // POST: DashBoard/Practitioners/Delete/5
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
