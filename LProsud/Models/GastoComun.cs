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
    
    public partial class GastoComun
    {
        public string EdifCod { get; set; }
        public short GastAno { get; set; }
        public short GastMes { get; set; }
        public string ConcCodigo { get; set; }
        public Nullable<short> GastCuotas { get; set; }
        public Nullable<short> GastCantidad { get; set; }
        public Nullable<double> GastValor { get; set; }
        public Nullable<System.DateTime> GastFechaVen { get; set; }
        public string GastMensaje01 { get; set; }
        public string GastMensaje02 { get; set; }
        public string GastMensaje03 { get; set; }
        public string InmuCodigo { get; set; }
        public string TorrCodigo { get; set; }
        public Nullable<double> GastValorMonOri { get; set; }
    }
}