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
    
    public partial class DOCUMENTOS_COMPRAS_VENTAS_KAM04
    {
        public string Empresa { get; set; }
        public Nullable<short> Año { get; set; }
        public Nullable<short> Mes { get; set; }
        public string Cod_TipoDocumento { get; set; }
        public string Desc_TipoDocumento { get; set; }
        public double Numero { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<System.DateTime> F_Vencimiento { get; set; }
        public string Cod_Producto { get; set; }
        public string Nom_Productos { get; set; }
        public Nullable<double> UNIDADES { get; set; }
        public Nullable<double> TOTAL_NETO_LINEA { get; set; }
        public Nullable<double> Impuestos { get; set; }
        public Nullable<double> TOTAL_BRUTO_LINEA { get; set; }
        public string Rut { get; set; }
        public short Extranjero { get; set; }
        public string Nombre_CliProv { get; set; }
        public Nullable<double> Cod_sucursal { get; set; }
        public string Nom_sucursal { get; set; }
        public string Direccion_Sucursal { get; set; }
        public string Ciudad { get; set; }
        public string Cod_Clasificacion { get; set; }
        public string Clasificacion { get; set; }
        public Nullable<short> Cod_Vendedor { get; set; }
        public string Vendedor { get; set; }
        public string Cod_Departamento { get; set; }
        public string Departamento { get; set; }
        public string Cod_Linea { get; set; }
        public string LineaProducto { get; set; }
        public string Cod_Grupo { get; set; }
        public string Grupo { get; set; }
        public Nullable<short> Cod_Marca { get; set; }
        public string Marca { get; set; }
        public Nullable<double> CostoUnitario { get; set; }
        public Nullable<double> CostoTotal { get; set; }
        public Nullable<double> PrecioUnitarioNeto { get; set; }
        public Nullable<double> Cajas { get; set; }
        public Nullable<double> Kilos { get; set; }
        public string DocNULO { get; set; }
        public string Glosa { get; set; }
        public Nullable<double> HRNro { get; set; }
        public Nullable<double> HRTotPagadoUnidades { get; set; }
        public string HRNomChofer { get; set; }
        public string HRPatente { get; set; }
        public Nullable<double> HRCapacidadT { get; set; }
        public string NroOC { get; set; }
        public string FechaDespacho { get; set; }
        public string ModificadoPor { get; set; }
        public Nullable<double> CreditoMaximo { get; set; }
        public string NomTransportista { get; set; }
        public string DoctoOrigen { get; set; }
        public string FormaPago { get; set; }
        public Nullable<double> Cre_Ocupado { get; set; }
        public string CONCEPTO_DEVOL { get; set; }
        public string Direccion_Sucursal_Despacho { get; set; }
    }
}
