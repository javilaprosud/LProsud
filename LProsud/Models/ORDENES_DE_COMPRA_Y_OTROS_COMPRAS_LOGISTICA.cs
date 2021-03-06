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
    
    public partial class ORDENES_DE_COMPRA_Y_OTROS_COMPRAS_LOGISTICA
    {
        public string Empresa { get; set; }
        public Nullable<short> Año { get; set; }
        public Nullable<short> Mes { get; set; }
        public string Cod_TipoDocumento { get; set; }
        public string Desc_TipoDocumento { get; set; }
        public Nullable<short> Tipo_Movimiento { get; set; }
        public string Desc_TipoMovimiento { get; set; }
        public Nullable<double> Numero { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<System.DateTime> F_Vencimiento { get; set; }
        public string Rut { get; set; }
        public Nullable<short> Extranjero { get; set; }
        public string Nombre_CliProv { get; set; }
        public Nullable<double> Sucursal { get; set; }
        public string NomSucursal { get; set; }
        public string Clasificacion { get; set; }
        public Nullable<short> CodVendedor { get; set; }
        public string NomVendedor { get; set; }
        public string CodListP { get; set; }
        public string NomListP { get; set; }
        public string CodTipoPago { get; set; }
        public string NomTipoPago { get; set; }
        public string PlazoPago { get; set; }
        public string Cod_Producto { get; set; }
        public string Nom_Producto { get; set; }
        public string LineaProducto { get; set; }
        public string Departamento { get; set; }
        public string Grupo { get; set; }
        public string Marca { get; set; }
        public Nullable<double> Cajas { get; set; }
        public Nullable<double> Kilos { get; set; }
        public Nullable<double> PrecioUnitarioNeto { get; set; }
        public Nullable<double> CostoUnitario { get; set; }
        public Nullable<double> CostoTotal { get; set; }
        public Nullable<double> Descuento { get; set; }
        public Nullable<double> PrecioUnitFinal { get; set; }
        public Nullable<double> PrecioNetoTotFinal { get; set; }
        public Nullable<double> PrecioBrutoTotal { get; set; }
        public string Observaciones { get; set; }
        public string FechaDespacho { get; set; }
        public string DocuAsociado { get; set; }
        public string DirDespacho { get; set; }
        public Nullable<double> Cre_Disponible { get; set; }
        public Nullable<double> CantPendiente { get; set; }
        public int Recibida_Lote { get; set; }
        public string EsParteKit { get; set; }
        public Nullable<short> codregion { get; set; }
        public string nomregion { get; set; }
        public Nullable<short> codciudad { get; set; }
        public string nomciudad { get; set; }
        public Nullable<short> codcomuna { get; set; }
        public string nomcomuna { get; set; }
        public string ss { get; set; }
        public string CuentaContable { get; set; }
        public string CodCentroResultado { get; set; }
        public string Glosa1 { get; set; }
        public string Glosa2 { get; set; }
        public string Glosa3 { get; set; }
        public Nullable<int> NroSemana { get; set; }
        public string Anden { get; set; }
        public string ControlCalida { get; set; }
        public string EncargdRecepcion { get; set; }
        public Nullable<System.DateTime> FechaArriboDescarga { get; set; }
        public Nullable<System.DateTime> FechaCarga { get; set; }
        public Nullable<System.DateTime> FechaDescarga { get; set; }
        public Nullable<System.DateTime> FechaElaboracion { get; set; }
        public Nullable<System.DateTime> FechaEntregaGuiaAbast { get; set; }
        public Nullable<System.DateTime> FechaVencimiento { get; set; }
        public Nullable<System.DateTime> VencePorLote { get; set; }
        public Nullable<System.DateTime> HoraArriboDescarga { get; set; }
        public Nullable<System.DateTime> EntregaGuia { get; set; }
        public Nullable<System.DateTime> HoraIniciaDescarga { get; set; }
        public Nullable<System.DateTime> HoraTerminoDescarga { get; set; }
        public string Lotes { get; set; }
        public string Naviera { get; set; }
        public string Contenedor { get; set; }
        public string NombreChofer { get; set; }
        public string NTicket { get; set; }
        public string Operador { get; set; }
        public string Pallet { get; set; }
        public string Proforma { get; set; }
        public string Proveedor { get; set; }
        public string Semi { get; set; }
        public string Trac { get; set; }
        public string Trasporte { get; set; }
        public string NuevaOC { get; set; }
    }
}
