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
    
    public partial class CompLinea
    {
        public string EdifCod { get; set; }
        public double CompNumero { get; set; }
        public short CompMovimiento { get; set; }
        public string RelcRut { get; set; }
        public short RelcExtranjero { get; set; }
        public string SucuCodigo { get; set; }
        public double CompLCorrel { get; set; }
        public Nullable<double> CompLCantidad { get; set; }
        public string CompLDescripcion { get; set; }
        public Nullable<double> CompLValor { get; set; }
        public string CompLDocumento { get; set; }
        public Nullable<int> CompLNumDocumento { get; set; }
        public string ConcCodDependencia { get; set; }
        public string ConcCod { get; set; }
        public short CompTipo { get; set; }
        public string TdocCodigo { get; set; }
    }
}
