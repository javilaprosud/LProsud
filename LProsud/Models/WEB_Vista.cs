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
    
    public partial class WEB_Vista
    {
        public long OVOP_ID { get; set; }
        public Nullable<long> id { get; set; }
        public string RelcRut { get; set; }
        public string RelcExtranjero { get; set; }
        public string cliente { get; set; }
        public Nullable<short> OVOPFormaPago { get; set; }
        public string OVOPFechaIngreso { get; set; }
        public Nullable<decimal> OVOPTotalNeto { get; set; }
        public Nullable<decimal> TotalImpuestos { get; set; }
        public Nullable<decimal> OVOPTotal { get; set; }
        public string OVOPDireccionDespacho { get; set; }
        public string OVOPEstado { get; set; }
        public string Estado_ERP { get; set; }
        public Nullable<double> Correlativo_OP { get; set; }
        public Nullable<System.DateTime> Fecha_IngresoERP { get; set; }
        public string rut1 { get; set; }
        public string rut2 { get; set; }
        public string Vendedor { get; set; }
    }
}
