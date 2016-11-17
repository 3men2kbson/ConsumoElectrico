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
        [StringLength(50)]
        public string CFDesc { get; set; }
        [DisplayName("Desde")]
        public int CFDesde { get; set; }
        [DisplayName("Hasta")]
        public int CFHasta { get; set; }
        [DisplayName("Sin Subsidio")]
        public decimal CFSinSubs { get; set; }
        [DisplayName("Con Subsidio")]
        public decimal CFConSubs { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayName("Activo desde")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}")]
        public DateTime FechaActivo { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayName("Activo Hasta")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}")]
        public DateTime FechaLimite { get; set; }

    }
}