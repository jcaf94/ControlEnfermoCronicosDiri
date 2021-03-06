﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Administracion.Areas.DashBoard.Models
{
    public class Location
    {
        [ScaffoldColumn(false)]
        public int identifier { get; set; }

        [Display(Prompt = "Nombre de location", Description = "Nombre de location", Name = "Nombre ")]
        [Required(ErrorMessage = "Debe indicar un nombre para el location")]
        [StringLength(maximumLength: 50, ErrorMessage = "El nombre no puede tener más de 50 caracteres")]
        public string Name { get; set; }

        [Display(Prompt = "Telefono de location", Description = "Telefono de location", Name = "Telefono ")]
        [Required(ErrorMessage = "Debe indicar un telefono para el location")]
        [StringLength(maximumLength: 50, ErrorMessage = "El telefono no puede tener más de 50 caracteres")]
        public string Phone { get; set; }

        [Display(Prompt = "Email de location", Description = "Email de location", Name = "Email ")]
        [Required(ErrorMessage = "Debe indicar un email para el location")]
        [DataType(DataType.EmailAddress, ErrorMessage = "El email debe ser correcto")]
        [StringLength(maximumLength: 50, ErrorMessage = "El email no puede tener más de 50 caracteres")]
        public string Email { get; set; }

        [Display(Prompt = "Código Postal de location", Description = "Código Postal de location", Name = "CodPostal ")]
        [StringLength(maximumLength: 5, ErrorMessage = "El código postal no puede tener más de 5 caracteres")]
        public string CodPostal { get; set; }
    }
}