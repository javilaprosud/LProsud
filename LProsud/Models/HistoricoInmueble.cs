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
    
    public partial class HistoricoInmueble
    {
        public string EdifCod { get; set; }
        public string TorrCodigo { get; set; }
        public string InmuCodigo { get; set; }
        public string HisRutProp { get; set; }
        public short HisExtranjeroProp { get; set; }
        public string HisRutArre { get; set; }
        public short HisExtranjeroArre { get; set; }
        public string HistDescripcion { get; set; }
        public Nullable<double> InmuMetros { get; set; }
        public Nullable<short> InmuTipoGasto { get; set; }
        public Nullable<double> InmuFactor { get; set; }
        public Nullable<double> InmuMonto { get; set; }
        public Nullable<System.DateTime> HistFechaIngreso { get; set; }
    }
}