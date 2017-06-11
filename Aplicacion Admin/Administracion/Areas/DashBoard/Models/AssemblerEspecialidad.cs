using ChroniGenNHibernate.EN.Chroni;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Administracion.Areas.DashBoard.Models
{
    public class AssemblerEspecialidad
    {
        public Especialidad ConvertENToModelUI(SpecialtyEN en)
        {
            Especialidad pos = new Especialidad();
            pos.id = en.Identifier;
            pos.nombre = en.Display;
            return pos;
        }
        public IList<Especialidad> ConvertListENToModel(IList<SpecialtyEN> ens)
        {
            IList<Especialidad> positions = new List<Especialidad>();
            foreach (SpecialtyEN en in ens)
            {
                positions.Add(ConvertENToModelUI(en));
            }
            return positions;
        }
    }
}