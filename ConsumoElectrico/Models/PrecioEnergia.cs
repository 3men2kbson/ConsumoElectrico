using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ConsumoElectrico.Models
{
    public class PrecioEnergia
    {
        [DisplayName("Id")]
        public int PEId { get; set;  }
        [DisplayName("Descripción")]
        public string PEDesc { get; set; }
        [DisplayName("Desde")]
        public int PEDesde { get; set; }
        [DisplayName("Hasta")]
        public int PEhasta { get; set; }
        [DisplayName("Sin Subsidio")]
        public decimal PESinSubs { get; set; }
        [DisplayName("Con Subsidio")]
        public decimal PEConsubs { get; set; }
        [DisplayName("Activo Desde")]
        public DateTime FechaActivo { get; set; }
        [DisplayName("Activo Hasta")]
        public DateTime FechaLimite { get; set; }
    }
}