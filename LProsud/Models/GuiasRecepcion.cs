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
    
    public partial class GuiasRecepcion
    {
        public string GuReRut { get; set; }
        public string EmprCod { get; set; }
        public double GuReNumero { get; set; }
        public short GuReExtranjero { get; set; }
        public System.DateTime GuReFechaIngresa { get; set; }
        public Nullable<short> GureTipoServicio { get; set; }
        public Nullable<double> GuReAbono { get; set; }
        public Nullable<double> GuReMontoTotal { get; set; }
        public Nullable<double> GuReMontoPagado { get; set; }
        public string GuReObservacion { get; set; }
        public string GureFallas { get; set; }
        public string GureContacto { get; set; }
        public Nullable<System.DateTime> GuReFechaEntrega { get; set; }
        public short GureEntregaSiNo { get; set; }
        public Nullable<int> GureLugarServicio { get; set; }
        public string GureDescripcionEquipo { get; set; }
        public string GureAccesorios { get; set; }
        public Nullable<int> EmplCodigo { get; set; }
        public Nullable<int> EmplCodigoVendedor { get; set; }
        public string GureUsuario { get; set; }
        public short SuccCodigo { get; set; }
        public Nullable<System.DateTime> GureFechaGarantia { get; set; }
        public string GureNotasReparacion { get; set; }
        public bool GureEsFacturable { get; set; }
        public Nullable<double> GureGuiaAsoc { get; set; }
        public string GureSolicitante { get; set; }
        public string GureDireccion { get; set; }
        public string GureRutSolicitante { get; set; }
        public string GureDirecSol { get; set; }
        public Nullable<System.DateTime> GureHoraIniRes { get; set; }
        public Nullable<System.DateTime> GureHoraFinRes { get; set; }
        public Nullable<System.DateTime> GureHoraIniReal { get; set; }
        public Nullable<System.DateTime> GureHoraFinReal { get; set; }
        public Nullable<System.DateTime> GureFechaRes { get; set; }
        public string GureNombreclie { get; set; }
        public string Gureprioridad { get; set; }
    }
}
