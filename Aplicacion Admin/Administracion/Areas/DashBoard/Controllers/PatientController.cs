using Administracion.Areas.DashBoard.Models;
using Administracion.Controllers;
using ChroniGenNHibernate.CAD.Chroni;
using ChroniGenNHibernate.CEN.Chroni;
using ChroniGenNHibernate.EN.Chroni;
using ChroniGenNHibernate.Enumerated.Chroni;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Administracion.Areas.DashBoard.Controllers
{
    public class PatientController : BasicController
    {
        // GET: DashBoard/Patient
        public ActionResult Index()
        {
            IEnumerable<Patient> listPos = null;

            try
            {
                SessionInitialize();
                PractitionerCAD cadPrac = new PractitionerCAD();
                PractitionerCEN cenPrac = new PractitionerCEN(cadPrac);

                PatientCAD cad = new PatientCAD();
                PatientCEN cen = new PatientCEN(cad);


                IList<PatientEN> listPosEn = cen.ReadAll(0, -1);


                listPos = new AssemblerPatient().ConvertListENToModel(listPosEn).ToList();

                foreach (Patient p in listPos)
                {
                    if (string.IsNullOrEmpty(p.Imagen))
                    {
                        p.Imagen = "default.png";
                    }
                }

                SessionClose();
            }
            catch (Exception ex)
            {
                TempData["resultado"] = Resources.textos.modelEmpty;
                TempData["ok"] = "warning";
            }


            ViewBag.menu = "Patients";
            return View(listPos);
        }

        // GET: DashBoard/Patient/Details/5
        public ActionResult Details(int id)
        {
            SessionInitialize();

            string resultado = "";
            string locationNombre = Resources.textos.modelEmpty;
            PatientCAD cadPos = new PatientCAD();
            PatientCEN cen = new PatientCEN(cadPos);
            PatientEN posEN = cen.ReadOID(id);

            Dictionary<string, string> res = new Dictionary<string, string>();

            if (posEN != null)
            {
                if (posEN.Name != null)
                {
                    locationNombre = posEN.Name;
                }

                if(string.IsNullOrEmpty(posEN.Photo))
                {
                    posEN.Photo = "default.png";
                }

                resultado = "<ul><li><strong>Id: </strong>" + posEN.Identifier + "</li><li><strong>Nombre: </strong>" + posEN.Name + "</li><li><strong>Teléfono: </strong>" + posEN.Phone + "</li><li><strong>Email: </strong>" + posEN.Email + "</li><li><strong>Dirección: </strong>" + posEN.Address + "</li></ul>";
                res.Add("titulo", Resources.textos.detailsModal + posEN.Identifier + " " + "<img src = '/Content/images/" + posEN.Photo +"' height = '32' width = '32' />");
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

        // GET: DashBoard/Patient/Create
        public ActionResult Create()
        {
            ViewBag.menu = "Patients";
            return View();
        }

        // POST: DashBoard/Patient/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection, HttpPostedFileBase imagen)
        {
            ViewBag.menu = "Patients";

            try
            {
                SessionInitialize();

                PatientCAD cadPos = new PatientCAD();
                PatientCEN cen = new PatientCEN(cadPos);

                string name = collection["Name"].ToString();
                string tel = collection["Phone"].ToString();
                string email = collection["Email"].ToString();
                string photo = string.Empty;

                int tamMax = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["tamMaxImgProd"].ToString());

                if (imagen != null)
                {
                    if (imagen.ContentLength < (tamMax))
                    {
                        if (IsImage(imagen))
                        {
                            string nombreImagen = "img_" + name + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetExtension(imagen.FileName);
                            var path = Server.MapPath("~/Content/images/");
                            imagen.SaveAs(Path.Combine(path + nombreImagen));
                            photo = nombreImagen;

                        }
                        else
                        {
                            TempData["resultado"] = Resources.textos.errorKO;
                            TempData["ok"] = "danger";
                            
                        }
                    }
                    else
                    {
                        TempData["resultado"] = Resources.textos.errorKO;
                        TempData["ok"] = "danger";
                    }
                }

                cen.New_("-", true, name, "-", GenderEnum.other, DateTime.Now, false, "-", email, tel, MaritalStatusEnum.divorced, photo, null, null, "-" );

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

        // GET: DashBoard/Patient/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.menu = "Patients";

            PatientEN positionEN = null;
            Patient pos = null;

            try
            {
                SessionInitialize();

                PatientCAD cadPos = new PatientCAD();
                PatientCEN cen = new PatientCEN(cadPos);

                positionEN = cen.ReadOID(id);
                pos = new AssemblerPatient().ConvertENToModelUI(positionEN);
                SessionClose();
            }
            catch (Exception ex)
            {
                ViewBag.error = "Error: " + ex.Message;
            }
            return View(pos);
        }

        // POST: DashBoard/Patient/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection, HttpPostedFileBase imagen)
        {
            ViewBag.menu = "Patients";
            PatientCAD cadPos = new PatientCAD();
            PatientCEN cen = new PatientCEN(cadPos);
            PatientEN positionEN = null;

            try
            {
                positionEN = cen.ReadOID(id);
                positionEN.Name = collection["Name"].ToString();
                positionEN.Phone = collection["Phone"].ToString();
                positionEN.Email = collection["Email"].ToString();


                int tamMax = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["tamMaxImgProd"].ToString());

                if (imagen != null)
                {
                    if (imagen.ContentLength < (tamMax))
                    {
                        if (IsImage(imagen))
                        {
                            string nombreImagen = "img_" + positionEN.Name + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetExtension(imagen.FileName);
                            var path = Server.MapPath("~/Content/images/");
                            imagen.SaveAs(Path.Combine(path + nombreImagen));
                            positionEN.Photo = nombreImagen;

                        }
                        else
                        {
                            TempData["resultado"] = Resources.textos.errorKO;
                            TempData["ok"] = "success";

                        }
                    }
                    else
                    {
                        TempData["resultado"] = Resources.textos.errorKO;
                        TempData["ok"] = "success";
                    }
                }

                cen.Modify(positionEN.Identifier, positionEN.Nif, positionEN.Active, positionEN.Name, positionEN.Surnames, positionEN.Gender, positionEN.BirthDate, positionEN.Deceased, positionEN.Address, positionEN.Email, positionEN.Phone, positionEN.MaritalStatus, positionEN.Photo, positionEN.Password);

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

        // GET: DashBoard/Patient/Delete/5
        public ActionResult Delete(int id)
        {
            ViewBag.menu = "Patients";

            SessionInitialize();

            PatientCAD cadPos = new PatientCAD();
            PatientCEN cen = new PatientCEN(cadPos);

            cen.Destroy(id);

            PatientEN pos = cen.ReadOID(id);
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

        // POST: DashBoard/Patient/Delete/5
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

        private string timeStamp()
        {
            return "_" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        private bool IsImage(HttpPostedFileBase postedFile)
        {
            bool esImg = true;
            if (postedFile.ContentType.ToLower() != "image/jpg" &&
                        postedFile.ContentType.ToLower() != "image/jpeg" &&
                        postedFile.ContentType.ToLower() != "image/pjpeg" &&
                        postedFile.ContentType.ToLower() != "image/gif" &&
                        postedFile.ContentType.ToLower() != "image/x-png" &&
                        postedFile.ContentType.ToLower() != "image/png")
            {
                esImg = false;
            }

            if (Path.GetExtension(postedFile.FileName).ToLower() != ".jpg"
                && Path.GetExtension(postedFile.FileName).ToLower() != ".png"
                && Path.GetExtension(postedFile.FileName).ToLower() != ".gif"
                && Path.GetExtension(postedFile.FileName).ToLower() != ".jpeg")
            {
                esImg = false;
            }

            try
            {
                using (var bitmap = new System.Drawing.Bitmap(postedFile.InputStream))
                {
                    esImg = !bitmap.Size.IsEmpty;
                }
            }
            catch (Exception)
            {
                esImg = false;
            }
            finally
            {
                postedFile.InputStream.Position = 0;
            }

            return esImg;
        }
    }
}
