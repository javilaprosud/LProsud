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
    
    public partial class SemanaCorrida
    {
        public string EmprCod { get; set; }
        public string EmplRut { get; set; }
        public bool EmplExtranjero { get; set; }
        public short SemaAno { get; set; }
        public short SemaMes { get; set; }
        public Nullable<short> SemaCorr { get; set; }
        public Nullable<short> SemaDAus { get; set; }
        public Nullable<short> SemaDLic { get; set; }
        public Nullable<short> SemaDTra { get; set; }
        public Nullable<System.DateTime> SemaHENor { get; set; }
        public Nullable<System.DateTime> SemaHENoc { get; set; }
        public Nullable<System.DateTime> SemaHEFes { get; set; }
        public Nullable<System.DateTime> SemaHEDes { get; set; }
        public Nullable<double> SemaOtrosBonos { get; set; }
        public Nullable<double> SemaCantidad { get; set; }
        public Nullable<double> SemaPromedio { get; set; }
        public Nullable<double> SemaTotal { get; set; }
    }
}
