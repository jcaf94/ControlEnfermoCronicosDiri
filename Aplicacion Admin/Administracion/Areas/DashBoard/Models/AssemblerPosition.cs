using ChroniGenNHibernate.EN.Chroni;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Administracion.Areas.DashBoard.Models
{
    public class AssemblerPosition
    {
        public Position ConvertENToModelUI(PositionEN en)
        {
            Position pos = new Position();
            pos.identifier = en.Identifier;
            pos.altitude = en.Altitude;
            pos.latitude = en.Latitude;
            pos.longitude = en.Longitude;
            return pos;
        }
        public IList<Position> ConvertListENToModel(IList<PositionEN> ens)
        {
            IList<Position> positions = new List<Position>();
            foreach (PositionEN en in ens)
            {
                positions.Add(ConvertENToModelUI(en));
            }
            return positions;
        }
    }
}