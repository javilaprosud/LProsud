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
    
    public partial class DatosLogistico
    {
        public string EmprCod { get; set; }
        public string RelcRut { get; set; }
        public short RelcExtranjero { get; set; }
        public string SucuCodigo { get; set; }
        public string TdocCodigo { get; set; }
        public short OdocMovimiento { get; set; }
        public string OdocNumero { get; set; }
        public short OdocLinea { get; set; }
        public Nullable<short> OdocAno { get; set; }
        public Nullable<short> OdocMes { get; set; }
        public string LogNombreChofer { get; set; }
        public string LogTransporte { get; set; }
        public string LogProveedor { get; set; }
        public string LogTrac { get; set; }
        public string LogSemi { get; set; }
        public Nullable<System.DateTime> LogFechaCarga { get; set; }
        public string LogPallet { get; set; }
        public string LogProforma { get; set; }
        public Nullable<System.DateTime> LogFechaArriboDesc { get; set; }
        public Nullable<System.DateTime> LogHoraArriboDesc { get; set; }
        public Nullable<System.DateTime> LogHoraEntregaGuia { get; set; }
        public Nullable<System.DateTime> LogFechaDescarga { get; set; }
        public Nullable<System.DateTime> LogHoraIniDesc { get; set; }
        public Nullable<System.DateTime> LogHoraTerminoDesc { get; set; }
        public string LogAnden { get; set; }
        public Nullable<System.DateTime> LogFEntregaGuiaAbast { get; set; }
        public string LogOperador { get; set; }
        public string LogNTicket { get; set; }
        public Nullable<System.DateTime> LogFVencXLote { get; set; }
        public string LogNContenedor { get; set; }
        public string LogNaviera { get; set; }
        public string LogEncargadoRecepcion { get; set; }
        public string LogControlCalidad { get; set; }
        public string LogLotes { get; set; }
        public Nullable<System.DateTime> LogFElab { get; set; }
        public Nullable<System.DateTime> LogFVenc { get; set; }
    }
}
