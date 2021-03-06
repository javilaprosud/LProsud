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
    
    public partial class Detalle_movimiento
    {
        public string Documento { get; set; }
        public decimal Numero_documento { get; set; }
        public int Linea { get; set; }
        public string Tipo_movimiento { get; set; }
        public string Documento_solicitado { get; set; }
        public Nullable<decimal> Numero_documento_solicitado { get; set; }
        public string Estado_documento_solicitado { get; set; }
        public string Documento_trabajo { get; set; }
        public Nullable<decimal> Numero_documento_trabajo { get; set; }
        public string Empresa { get; set; }
        public string Bodega { get; set; }
        public string Bodega_erp { get; set; }
        public Nullable<decimal> Numero_oleada { get; set; }
        public Nullable<System.DateTime> Fecha_movimiento { get; set; }
        public string Producto { get; set; }
        public Nullable<decimal> Entrada { get; set; }
        public Nullable<decimal> Salida { get; set; }
        public Nullable<decimal> Cantidad { get; set; }
        public string Ubicacion { get; set; }
        public string Ubicacion_destino { get; set; }
        public string Ubicacion_final { get; set; }
        public string Pallet { get; set; }
        public string Pallet_movimiento_interno { get; set; }
        public string Lote { get; set; }
        public Nullable<System.DateTime> Fecha_elaboracion { get; set; }
        public Nullable<System.DateTime> Fecha_vencimiento { get; set; }
        public string Serie { get; set; }
        public string Variable1 { get; set; }
        public string Variable2 { get; set; }
        public string Variable3 { get; set; }
        public string Variable4 { get; set; }
        public string Variable5 { get; set; }
        public decimal Peso { get; set; }
        public Nullable<decimal> Volumen { get; set; }
        public string Usuario_proceso { get; set; }
        public Nullable<System.DateTime> Fecha_proceso { get; set; }
        public string Usuario_revision { get; set; }
        public Nullable<System.DateTime> Fecha_revision { get; set; }
        public string Identificador_erp { get; set; }
        public string Estado_erp { get; set; }
        public string Session_id { get; set; }
        public string Process_id { get; set; }
        public decimal Id_movimiento { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public Nullable<decimal> Neto { get; set; }
        public string Estado { get; set; }
        public string Usuario_creacion { get; set; }
        public System.DateTime Fecha_creacion { get; set; }
        public string Usuario_modificacion { get; set; }
        public Nullable<System.DateTime> Fecha_modificacion { get; set; }
    }
}
