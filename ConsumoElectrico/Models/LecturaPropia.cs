using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ConsumoElectrico.Models
{
    public class LecturaPropia
    {
        [DisplayName("Id")]
        public int LPId { get; set; }
        [DisplayName("Fecha")]
        public DateTime LPFecha { get; set; }
        [DisplayName("Valor")]
        public decimal LPLectura { get; set; }
        [DisplayName("Subsidiado?")]
        public Boolean LPSubsidio { get; set; }

    }
}