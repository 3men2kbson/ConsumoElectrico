using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ConsumoElectrico.Models
{
    public class LecturaDistrib
    {
        [DisplayName("Id")]
        public int LDId { get; set;  }
        [DisplayName("Fecha")]
        public DateTime LDFecha { get; set; }
        [DisplayName("Valor")]
        public decimal LDLectura { get; set; }

    }
}