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
    
    public partial class ODCosto
    {
        public string EmprCod { get; set; }
        public string ProdCodigo { get; set; }
        public string RelcRut { get; set; }
        public short RelcExtranjero { get; set; }
        public string SucuCodigo { get; set; }
        public string TdocCodigo { get; set; }
        public short OdocMovimiento { get; set; }
        public double OdocNumero { get; set; }
        public double NumeroCarpeta { get; set; }
        public short VIALLEGADA { get; set; }
        public short CLAUSULACOMPRA { get; set; }
        public string UnidMedida { get; set; }
        public Nullable<double> CantCONTENEDORES { get; set; }
        public Nullable<double> FletePuerto { get; set; }
        public Nullable<double> FleteInternacional { get; set; }
        public Nullable<double> TOTALKILOS { get; set; }
        public Nullable<double> USDUnitario { get; set; }
        public Nullable<double> TotalUSD { get; set; }
        public Nullable<double> USD_Unitario_Kilo { get; set; }
        public Nullable<double> USD_Unitario_Flete_Kilo { get; set; }
        public Nullable<double> USD_Unitario_CFR_Kilo { get; set; }
        public Nullable<double> Porcentaje_gasto { get; set; }
        public Nullable<double> COSTOS_USD { get; set; }
        public Nullable<double> TipoCambio { get; set; }
        public Nullable<double> CostoPesos { get; set; }
        public Nullable<short> GastosDefinitivos { get; set; }
        public Nullable<double> Descuento { get; set; }
        public Nullable<double> USD_Unit_Final { get; set; }
        public Nullable<double> ValorNeto { get; set; }
        public Nullable<double> ValorNetoDesc { get; set; }
        public Nullable<double> TotalCajas { get; set; }
    }
}