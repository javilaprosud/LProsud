//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LProsud.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Finiquito
    {
        public string EmprCod { get; set; }
        public string EmplRut { get; set; }
        public short EmplExtranjero { get; set; }
        public short FiniAno { get; set; }
        public short FiniMes { get; set; }
        public int MovMenCorrel { get; set; }
        public Nullable<short> CausCodigo { get; set; }
        public Nullable<System.DateTime> FiniFechaEmision { get; set; }
        public string FiniModelo { get; set; }
        public Nullable<System.DateTime> FiniFechaEntrega { get; set; }
        public string FiniGlosaDespido { get; set; }
        public Nullable<double> FiniIndeVoluntaria { get; set; }
        public Nullable<double> FiniIndePactada { get; set; }
        public Nullable<double> FiniDescuentoAFC { get; set; }
    }
}
