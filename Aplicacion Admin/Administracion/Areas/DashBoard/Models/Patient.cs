using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Administracion.Areas.DashBoard.Models
{
    public class Patient
    {
        [ScaffoldColumn(false)]
        public int identifier { get; set; }

        [Display(Prompt = "Nombre de patient", Description = "Nombre de patient", Name = "Nombre ")]
        [Required(ErrorMessage = "Debe indicar un nombre para el location")]
        [StringLength(maximumLength: 50, ErrorMessage = "El nombre no puede tener más de 50 caracteres")]
        public string Name { get; set; }

        [Display(Prompt = "Telefono de patient", Description = "Telefono de patient", Name = "Telefono ")]
        [Required(ErrorMessage = "Debe indicar un telefono para el location")]
        [StringLength(maximumLength: 50, ErrorMessage = "El telefono no puede tener más de 50 caracteres")]
        public string Phone { get; set; }

        [Display(Prompt = "Email de patient", Description = "Email de patient", Name = "Email ")]
        [Required(ErrorMessage = "Debe indicar un email para el location")]
        [DataType(DataType.EmailAddress, ErrorMessage = "El email debe ser correcto")]
        [StringLength(maximumLength: 50, ErrorMessage = "El email no puede tener más de 50 caracteres")]
        public string Email { get; set; }

        [Display(Prompt = "Imagen de patient", Description = "Imagen de patient", Name = "Imagen ")]
        public string Imagen { get; set; }

    }
}