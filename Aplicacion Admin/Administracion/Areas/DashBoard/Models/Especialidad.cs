using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Administracion.Areas.DashBoard.Models
{
    public class Especialidad
    {
        public int id { get; set; }

        [Display(Prompt = "Nombre de especialidad", Description = "Nombre de especialidad", Name = "Nombre ")]
        [Required(ErrorMessage = "Debe indicar un nombre para la especialidad")]
        [StringLength(maximumLength: 50, ErrorMessage = "El nombre no puede tener más de 50 caracteres")]

        public string nombre { get; set; }

        public Especialidad(int i = 0, string n = "")
        {
            this.id = i;
            this.nombre = n;
        }
    }
}