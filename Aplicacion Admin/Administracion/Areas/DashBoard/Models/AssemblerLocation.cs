using ChroniGenNHibernate.EN.Chroni;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Administracion.Areas.DashBoard.Models
{
    public class AssemblerLocation
    {
        public Location ConvertENToModelUI(LocationEN en)
        {
            Location loc = new Location();
            loc.identifier = en.Identifier;
            loc.Name = en.Name;
            loc.Phone = en.Phone;
            loc.Email = en.Email;
            loc.CodPostal = en.PostalCode;
            return loc;
        }
        public IList<Location> ConvertListENToModel(IList<LocationEN> ens)
        {
            IList<Location> locations = new List<Location>();
            foreach (LocationEN en in ens)
            {
                locations.Add(ConvertENToModelUI(en));
            }
            return locations;
        }
    }
}