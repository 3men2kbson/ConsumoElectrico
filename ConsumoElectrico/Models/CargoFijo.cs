using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ConsumoElectrico.Models
{
    public class CargoFijo
    {
        [DisplayName("Id")]
        public int CFId { get; set; }
        [DisplayName("Descripción")]
        public string CFDesc { get; set; }
        [DisplayName("Desde")]
        public int CFDesde { get; set; }
        [DisplayName("Hasta")]
        public int CFHasta { get; set; }
        [DisplayName("Sin Subsidio")]
        public decimal CFSinSubs { get; set; }
        [DisplayName("Con Subsidio")]
        public decimal CFConSubs { get; set; }
        [DisplayName("Activo desde")]
        public DateTime FechaActivo { get; set; }
        [DisplayName("Activo Hasta")]
        public DateTime FechaLimite { get; set; }

    }
}