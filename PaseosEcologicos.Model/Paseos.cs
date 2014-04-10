//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PaseosEcologicos.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public partial class Paseos
    { 
        public Paseos()
        {
            this.Reservaciones = new HashSet<Reservaciones>();
        }
    
        public int Id { get; set; }

        [Required(ErrorMessage = "El Titulo es Requerido")]
        [DataType(DataType.Text)] 
        public string Titulo { get; set; }
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "La fecha de partida es Requerida")] 
        [Display(Name="Fecha de Partida")]
        [DataType(DataType.DateTime)]       
        public Nullable<System.DateTime> FechaDePartida { get; set; }

        [Required(ErrorMessage = "El Precio es Requerido")]
        [DataType(DataType.Currency)] 
        public Nullable<decimal> Precio { get; set; }
    
        public virtual ICollection<Reservaciones> Reservaciones { get; set; }
    }
}
