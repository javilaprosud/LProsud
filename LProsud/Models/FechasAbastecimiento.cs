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
    
    public partial class FechasAbastecimiento
    {
        public string EmprCod { get; set; }
        public short OdliCorrLinea { get; set; }
        public string RelcRut { get; set; }
        public short RelcExtranjero { get; set; }
        public string SucuCodigo { get; set; }
        public string TdocCodigo { get; set; }
        public short OdocMovimiento { get; set; }
        public string OdocNumero { get; set; }
        public short OdocLinea { get; set; }
        public Nullable<System.DateTime> FechaEmision { get; set; }
        public Nullable<System.DateTime> FechaSuif { get; set; }
        public Nullable<System.DateTime> FechaLibDocumento { get; set; }
        public Nullable<System.DateTime> FechaCarga { get; set; }
        public Nullable<System.DateTime> FechaAgendamiento { get; set; }
        public Nullable<System.DateTime> FechaLlegadaP { get; set; }
        public Nullable<System.DateTime> FechaMurrach { get; set; }
        public Nullable<System.DateTime> HoraAgendamiento { get; set; }
        public Nullable<System.DateTime> FechaCambioProvisorio { get; set; }
        public Nullable<double> TipoCambioDefinitivo { get; set; }
        public Nullable<System.DateTime> FechaCambioDefinitivo { get; set; }
        public Nullable<double> TipoCambioProvisorio { get; set; }
    }
}
