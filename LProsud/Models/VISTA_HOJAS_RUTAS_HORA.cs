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
    
    public partial class VISTA_HOJAS_RUTAS_HORA
    {
        public string Empresa { get; set; }
        public Nullable<int> Año { get; set; }
        public Nullable<int> Mes { get; set; }
        public double HRNumero { get; set; }
        public Nullable<short> HoRuNula { get; set; }
        public Nullable<short> DisponibleParaPago { get; set; }
        public Nullable<short> HRLiEstado { get; set; }
        public Nullable<System.DateTime> HoRuFecha { get; set; }
        public Nullable<double> NumeroDocto { get; set; }
        public Nullable<double> TotalNeto { get; set; }
        public Nullable<double> TotalBruto { get; set; }
        public Nullable<double> PesoDocumento { get; set; }
        public string NomChofer { get; set; }
        public string NomTransportista { get; set; }
        public Nullable<double> HRLiMontoPagado { get; set; }
        public Nullable<int> CodComuna { get; set; }
        public string NomComuna { get; set; }
        public string Patente { get; set; }
        public Nullable<double> CapacidadT { get; set; }
        public string NomCliente { get; set; }
        public Nullable<double> CodSucCliente { get; set; }
        public string NomSucCliente { get; set; }
        public string DirSucCliente { get; set; }
        public Nullable<short> CodCiuSucCliente { get; set; }
        public string NomCiuCliente { get; set; }
        public Nullable<short> CodRegionCliente { get; set; }
        public string NomRegionCliente { get; set; }
        public string Cod_TipoDocumento { get; set; }
        public string Desc_TipoDocumento { get; set; }
        public Nullable<System.DateTime> Fecha_FA { get; set; }
        public string HoRuTipo { get; set; }
        public string HRLiDirDesp { get; set; }
        public Nullable<double> HRLiMontoCancelar { get; set; }
        public Nullable<System.DateTime> Hora { get; set; }
        public string Chofer_Bloqueado { get; set; }
        public string Patente_Bloqueada { get; set; }
        public string CIUDAD_DESPACHO { get; set; }
        public Nullable<double> CantPalletAzul { get; set; }
        public Nullable<double> CantPalletBlanco { get; set; }
        public string Glosa { get; set; }
        public Nullable<double> InformeCarga { get; set; }
        public Nullable<double> PUNTOS_ADICIONALES { get; set; }
        public Nullable<double> PAGO_DESCARGA { get; set; }
        public Nullable<double> DOBLE_VUELTA { get; set; }
        public Nullable<double> PEAJES { get; set; }
        public Nullable<double> PEONETAS { get; set; }
        public Nullable<double> RETIROS { get; set; }
        public Nullable<double> SOBRE_PESO { get; set; }
        public string RUTAS { get; set; }
        public string ZONA_GEOGRAFICA { get; set; }
        public string DirDespacho { get; set; }
        public Nullable<System.DateTime> FECHA_PAGADA { get; set; }
        public Nullable<System.DateTime> FECHA_RECIBIDA_TRANSPORTISTA { get; set; }
        public string RENDIDA_POR_TRANPORTISTA { get; set; }
        public string RENDIDA_A_CONTABILIDAD { get; set; }
        public Nullable<System.DateTime> FECHA_ENTREGA_A_CONTABILIDAD { get; set; }
        public string ACEPTADA_CONFORME { get; set; }
        public Nullable<System.DateTime> FECHA_ACEPTADA_CONFORME { get; set; }
    }
}