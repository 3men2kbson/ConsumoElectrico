using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ConsumoElectrico.Models
{
    public class PrecioEnergia
    {
        [Key]
        [DisplayName("Id")]
        public int PEId { get; set;  }
        [DisplayName("Descripción")]
        [StringLength(50)]
        public string PEDesc { get; set; }
        [DisplayName("Desde")]
        public int PEDesde { get; set; }
        [DisplayName("Hasta")]
        public int PEhasta { get; set; }
        [DisplayName("Sin Subsidio")]
        public decimal PESinSubs { get; set; }
        [DisplayName("Con Subsidio")]
        public decimal PEConsubs { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayName("Activo Desde")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}")]
        public DateTime FechaActivo { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayName("Activo Hasta")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}")]
        public DateTime FechaLimite { get; set; }
    }
}