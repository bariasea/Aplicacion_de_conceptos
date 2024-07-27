//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Notas
    {
        [Display(Name = "#")]
        public int Id { get; set; }

        [Display(Name = "Tipo de la nota")]
        public string Titulo { get; set; }


        [Display(Name = "Descripcion de la nota")]
        public string Contenido { get; set; }

        [Display(Name = "Fecha de creacion")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [DataType(DataType.DateTime)]
        public System.DateTime FechaCreacion { get; set; }


        [Display(Name = "Completo")]
        public bool Completado { get; set; }
    }
}
