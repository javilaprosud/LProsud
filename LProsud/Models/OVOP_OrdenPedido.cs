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
    
    public partial class OVOP_OrdenPedido
    {
        public long OVOP_ID { get; set; }
        public string RelcRut { get; set; }
        public short RelcExtranjero { get; set; }
        public string OVOPFormaPago { get; set; }
        public Nullable<System.DateTime> OVOPFechaIngreso { get; set; }
        public Nullable<double> OVOPTotalNeto { get; set; }
        public Nullable<double> OVOPIVA { get; set; }
        public Nullable<double> OVOPOtrosImpuestos { get; set; }
        public Nullable<double> OVOPTotal { get; set; }
        public string OVOPDireccionDespacho { get; set; }
        public Nullable<System.DateTime> OVOPFechaDespacho { get; set; }
        public string OVOPHoraDespacho { get; set; }
        public string OVOPDescripcion { get; set; }
        public string OVOPEstado { get; set; }
        public Nullable<long> Rel_CodSuc { get; set; }
        public Nullable<long> OVOP_ID_OP { get; set; }
        public Nullable<System.DateTime> OVOPFechaVencimiento { get; set; }
        public string OdocEstado { get; set; }
        public Nullable<double> OdocNumero { get; set; }
        public Nullable<System.DateTime> FechaIngresoERP { get; set; }
        public string UnimCodigo { get; set; }
        public string usuario { get; set; }
    }
}