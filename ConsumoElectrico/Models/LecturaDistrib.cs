using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ConsumoElectrico.Models
{
    public class LecturaDistrib
    {
        [Key]
        [DisplayName("Id")]
        public int LDId { get; set;  }
        [DataType(DataType.DateTime)]
        [DisplayName("Fecha")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy}")]
        public DateTime LDFecha { get; set; }
        [DisplayName("Valor")]
        public decimal LDLectura { get; set; }

    }
}