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
    
    public partial class Impuesto
    {
        public string EmprCod { get; set; }
        public string ImpuCodigo { get; set; }
        public short ImpuAno { get; set; }
        public Nullable<short> ImpuEsIVA { get; set; }
        public Nullable<short> ImptCodigo { get; set; }
        public string ImpuCtaCCredito { get; set; }
        public Nullable<short> ImpuRetenido { get; set; }
        public Nullable<double> ImpuTasa { get; set; }
        public Nullable<short> ImpuAdic { get; set; }
        public Nullable<short> ImpuEsp { get; set; }
        public string ImpuNombre { get; set; }
        public string ImpuCtaCDebito { get; set; }
        public Nullable<short> ImpuCreEC { get; set; }
    }
}