using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Administracion.Areas.DashBoard.Models
{
    public class Position
    {
        [ScaffoldColumn(false)]
        public int identifier { get; set; }

        [Display(Prompt = "Latitud de la posición", Description = "Latitud de la posición", Name = "Latitude ")]
        [Required(ErrorMessage = "Debe indicar una latitud para la posición")]
        [Range(minimum: -90, maximum: 90, ErrorMessage = "La latitud debe ser mayor de -90 y menor de 90")]
        public double latitude { get; set; }

        [Display(Prompt = "Longitud de la posición", Description = "Longitud de la posición", Name = "Longitude ")]
        [Required(ErrorMessage = "Debe indicar una longitud para la posición")]
        [Range(minimum: -180, maximum: 180, ErrorMessage = "La longitud debe ser mayor de -180 y menor de 180")]
        public double longitude { get; set; }

        [Display(Prompt = "Altitud de la posición", Description = "Altitud de la posición", Name = "Altitude ")]
        [Required(ErrorMessage = "Debe indicar una altitud para la posición")]
        [Range(minimum: -10000, maximum: 10000, ErrorMessage = "La altitud debe ser mayor de -10000 y menor de 10000")]
        public double altitude { get; set; }



    }
}