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
    
    public partial class DetallesComision
    {
        public string EmprCod { get; set; }
        public string tacoCodigo { get; set; }
        public int decoLinea { get; set; }
        public string decoNombre { get; set; }
        public Nullable<double> decoDesde { get; set; }
        public Nullable<double> decoHasta { get; set; }
        public Nullable<double> decoValor { get; set; }
        public Nullable<double> decoPremio { get; set; }
    }
}