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
    
    public partial class ItemFlujoEfectivo
    {
        public string IFCodigo { get; set; }
        public string EmprCod { get; set; }
        public short IFAno { get; set; }
        public string IFDescripcion { get; set; }
        public string IFCodAsociado { get; set; }
        public Nullable<short> IFSuma { get; set; }
        public Nullable<int> IFOrdenDirecto { get; set; }
        public Nullable<short> IFOrdenIndirecto { get; set; }
        public Nullable<short> IFIndirecto { get; set; }
        public Nullable<short> IFConciliacion { get; set; }
        public string IFFormula { get; set; }
        public string IFFormula2 { get; set; }
        public string IFFormula3 { get; set; }
        public Nullable<short> IFNivel { get; set; }
        public string IFTipoSuma { get; set; }
    }
}