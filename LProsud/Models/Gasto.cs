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
    
    public partial class Gasto
    {
        public string EdifCod { get; set; }
        public string TorrCodigo { get; set; }
        public string InmuCodigo { get; set; }
        public short GastAno { get; set; }
        public short GastMes { get; set; }
        public Nullable<double> GastSaldo { get; set; }
        public Nullable<double> GastMonto { get; set; }
        public Nullable<double> GastIntereses { get; set; }
        public Nullable<double> GastRecargos { get; set; }
        public Nullable<System.DateTime> GastFechaVenc { get; set; }
        public Nullable<double> GastFondo { get; set; }
        public Nullable<double> GastMontoTotal { get; set; }
        public string GastMensaje01 { get; set; }
        public string GastMensaje02 { get; set; }
        public string GastMensaje03 { get; set; }
        public string ConcCodigo { get; set; }
        public Nullable<double> GastFondoMonOri { get; set; }
    }
}
