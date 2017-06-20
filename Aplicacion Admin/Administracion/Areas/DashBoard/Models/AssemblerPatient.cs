using ChroniGenNHibernate.EN.Chroni;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Administracion.Areas.DashBoard.Models
{
    public class AssemblerPatient
    {
        public Patient ConvertENToModelUI(PatientEN en)
        {

            Patient loc = new Patient();
            loc.identifier = en.Identifier;
            loc.Name = en.Name;
            loc.Phone = en.Phone;
            loc.Email = en.Email;
            loc.Imagen = en.Photo;

            return loc;
        }
        public IList<Patient> ConvertListENToModel(IList<PatientEN> ens)
        {
            IList<Patient> locations = new List<Patient>();
            foreach (PatientEN en in ens)
            {
                locations.Add(ConvertENToModelUI(en));
            }
            return locations;
        }
    }
}