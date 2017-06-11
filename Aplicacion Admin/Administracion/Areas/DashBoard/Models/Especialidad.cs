using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Administracion.Areas.DashBoard.Models
{
    public class Especialidad
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public Especialidad(int i = 0, string n = "")
        {
            this.id = i;
            this.nombre = n;
        }
    }
}