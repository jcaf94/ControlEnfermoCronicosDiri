using ChroniGenNHibernate.EN.Chroni;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Administracion.Areas.DashBoard.Models
{
    public class AssemblerPractitioner
    {
        public Practitioner ConvertENToModelUI(PractitionerEN en)
        {
            Practitioner loc = new Practitioner();
            loc.identifier = en.Identifier;
            loc.Name = en.Name;
            loc.Phone = en.Phone;
            loc.Email = en.Email;

            if (en.Specialty != null)
            {
                loc.Especialidad = en.Specialty.Identifier;
                
                loc.DescripcionEsp = "Sin especialidad asignada";
            }
            else
            {
                loc.Especialidad = 0;
                loc.DescripcionEsp = "Sin especialidad asignada";
            }

            return loc;
        }
        public IList<Practitioner> ConvertListENToModel(IList<PractitionerEN> ens)
        {
            IList<Practitioner> locations = new List<Practitioner>();
            foreach (PractitionerEN en in ens)
            {
                locations.Add(ConvertENToModelUI(en));
            }
            return locations;
        }
    }
}