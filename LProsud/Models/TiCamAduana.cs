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
    
    public partial class TiCamAduana
    {
        public int ID_TC { get; set; }
        public string EmprCod { get; set; }
        public Nullable<short> TipValAno { get; set; }
        public string TipValMes { get; set; }
        public Nullable<double> TipValAduanero { get; set; }
        public Nullable<double> TipValTasaHoAA { get; set; }
        public Nullable<int> TipValpolizaSeg { get; set; }
        public Nullable<double> TipGastoDespacho { get; set; }
    }
}
