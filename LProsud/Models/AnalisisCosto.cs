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
    
    public partial class AnalisisCosto
    {
        public string EmprCod { get; set; }
        public string SucuCodigo { get; set; }
        public string RutCliente { get; set; }
        public bool RelcExtranjero { get; set; }
        public string TDOCCODIGO { get; set; }
        public Nullable<double> DOCTNUMERO { get; set; }
        public Nullable<double> DoctMovimiento { get; set; }
        public string CodigoProducto { get; set; }
        public Nullable<double> CostoReponedorInterno { get; set; }
        public Nullable<double> CostoReponedorExterno { get; set; }
        public Nullable<double> RAPEL { get; set; }
        public Nullable<double> MERMA { get; set; }
        public Nullable<double> DISTRIBUCION { get; set; }
        public Nullable<double> PUBLICIDAD { get; set; }
        public Nullable<double> INCORPORACION { get; set; }
        public Nullable<double> INAGURACION { get; set; }
        public Nullable<double> Descuento { get; set; }
        public Nullable<double> CostoVendedorInterno { get; set; }
        public Nullable<double> CostoVendedorExterno { get; set; }
        public Nullable<double> Costo { get; set; }
        public Nullable<double> Flete { get; set; }
        public Nullable<double> Margen { get; set; }
        public Nullable<double> Porcentaje { get; set; }
        public Nullable<double> MetaMonto { get; set; }
        public Nullable<double> MetaPorcentaje { get; set; }
        public Nullable<double> Correlativo { get; set; }
        public Nullable<double> B2B { get; set; }
        public Nullable<short> DoctMes { get; set; }
        public Nullable<short> DoctAno { get; set; }
        public string Sucursal2 { get; set; }
        public Nullable<System.DateTime> FechaDocto { get; set; }
        public string RutReponedor { get; set; }
        public string NombreReponedor { get; set; }
        public string RutSupervisor { get; set; }
        public string NombreSupervisor { get; set; }
        public string SucursalCliente { get; set; }
        public Nullable<double> MontoSupervisor { get; set; }
        public Nullable<double> CATALOGO { get; set; }
        public Nullable<double> EVENTOS { get; set; }
        public Nullable<double> EXHIBICION { get; set; }
        public Nullable<double> PREMIOS { get; set; }
    }
}