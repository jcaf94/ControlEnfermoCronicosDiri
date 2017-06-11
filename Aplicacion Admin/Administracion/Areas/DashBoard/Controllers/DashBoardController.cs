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
    public class DashBoardController : BasicController
    {
        // GET: DashBoard/DashBoard
        public ActionResult Index()
        {
            ViewBag.menu = "inicio";

            SessionInitialize();

            LocationCAD cadPos = new LocationCAD();
            LocationCEN cen = new LocationCEN(cadPos);
            IList<LocationEN> listLocations = cen.ReadAll(0, -1);
            ViewBag.numLocations = listLocations.Count;

            PractitionerCAD cadPrac = new PractitionerCAD();
            PractitionerCEN cenPrac = new PractitionerCEN(cadPrac);
            IList<PractitionerEN> listPracticioners = cenPrac.ReadAll(0, -1);
            ViewBag.numPractitioners = listPracticioners.Count;

            PatientCAD cadPatient = new PatientCAD();
            PatientCEN cenPatient = new PatientCEN(cadPatient);
            IList<PatientEN> listPatients = cenPatient.ReadAll(0, -1);
            ViewBag.numPatients = listPatients.Count;

            MedicationCAD cadMedication = new MedicationCAD();
            MedicationCEN cenMedication = new MedicationCEN(cadMedication);
            IList<MedicationEN> listMedications = cenMedication.ReadAll(0, -1);
            ViewBag.numMedications = listMedications.Count;

            CarePlanCAD cadCarePlan = new CarePlanCAD();
            CarePlanCEN cenCarePlan = new CarePlanCEN(cadCarePlan);
            IList<CarePlanEN> listCarePlans = cenCarePlan.ReadAll(0, -1);
            ViewBag.numCarePlans = listCarePlans.Count;

            GoalCAD cadGoal = new GoalCAD();
            GoalCEN cenGoal = new GoalCEN(cadGoal);
            IList<GoalEN> listGoals = cenGoal.ReadAll(0, -1);
            ViewBag.numGoals = listGoals.Count;

            SpecialtyCAD cadSpecialty = new SpecialtyCAD();
            SpecialtyCEN cenSpecialty = new SpecialtyCEN(cadSpecialty);
            IList<SpecialtyEN> listSpecialtys = cenSpecialty.ReadAll(0, -1);
            ViewBag.numSpecialtys = listSpecialtys.Count;

            EncounterCAD cadEncounter = new EncounterCAD();
            EncounterCEN cenEncounter = new EncounterCEN(cadEncounter);
            IList<EncounterEN> listEncounters = cenEncounter.ReadAll(0, -1);
            ViewBag.numEncounters = listEncounters.Count;

            SessionClose();

            return View("~/Areas/DashBoard/Views/Home/DashBoard.cshtml");
        }

        // GET: DashBoard/DashBoard
        public ActionResult BarChartLocations()
        {
            ViewBag.menu = "inicio";

            SessionInitialize();

            LocationCAD cadPos = new LocationCAD();
            LocationCEN cen = new LocationCEN(cadPos);
            IList<LocationEN> listLocations = cen.ReadAll(0, -1);

            PractitionerCAD cadPrac = new PractitionerCAD();
            PractitionerCEN cenPrac = new PractitionerCEN(cadPrac);
            IList<PractitionerEN> listPracticioners = cenPrac.ReadAll(0, -1);

            
            IList<LocationEN> listaLocationsChart = cen.ReadAll(0, -1);
            List<String> locations = new List<string>();

            foreach (LocationEN loc in listaLocationsChart)
            {
                locations.Add(loc.Name);
            }
            
            SessionClose();

            return Json(locations);

        }

        // GET: DashBoard/DashBoard
        public ActionResult BarChartPractitioners()
        {
            ViewBag.menu = "inicio";

            SessionInitialize();

            LocationCAD cadPos = new LocationCAD();
            LocationCEN cen = new LocationCEN(cadPos);
            IList<LocationEN> listLocations = cen.ReadAll(0, -1);

            PractitionerCAD cadPrac = new PractitionerCAD();
            PractitionerCEN cenPrac = new PractitionerCEN(cadPrac);
            IList<PractitionerEN> listPracticioners = cenPrac.ReadAll(0, -1);


            IList<LocationEN> listaLocationsChart = cen.ReadAll(0, -1);
            List<String> locations = new List<string>();

            List<int> numPractitionerCentro = new List<int>();

            foreach (LocationEN loc in listaLocationsChart)
            {
                IList<PractitionerEN> listaPacientes = cenPrac.GetPractitionersByLocation(loc.Identifier);
                numPractitionerCentro.Add(listaPacientes.Count);
            }
            
            SessionClose();

            return Json(numPractitionerCentro);

        }

        // GET: DashBoard/DashBoard
        public ActionResult BarChartPatients()
        {
            ViewBag.menu = "inicio";

            SessionInitialize();

            LocationCAD cadPos = new LocationCAD();
            LocationCEN cen = new LocationCEN(cadPos);
            IList<LocationEN> listLocations = cen.ReadAll(0, -1);

            PatientCAD cadPatient = new PatientCAD();
            PatientCEN cenPatient = new PatientCEN(cadPatient);
            IList<PatientEN> listPatients = cenPatient.ReadAll(0, -1);


            IList<LocationEN> listaLocationsChart = cen.ReadAll(0, -1);
            List<String> locations = new List<string>();

            List<int> numPractitionerCentro = new List<int>();

            foreach (LocationEN loc in listaLocationsChart)
            {
                IList<PatientEN> listaPacientes = cenPatient.GetPatientsByLocation(loc.Identifier);
                numPractitionerCentro.Add(listaPacientes.Count);
            }

            SessionClose();

            return Json(numPractitionerCentro);

        }
    }
}
