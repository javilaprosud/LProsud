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
    
    public partial class Detalle_movimiento_solicitado
    {
        public string Documento_solicitado { get; set; }
        public decimal Numero_documento_solicitado { get; set; }
        public int Linea { get; set; }
        public string Empresa { get; set; }
        public string Bodega { get; set; }
        public Nullable<System.DateTime> Fecha_movimiento { get; set; }
        public string Producto { get; set; }
        public Nullable<decimal> Entrada { get; set; }
        public Nullable<decimal> Salida { get; set; }
        public string Pallet { get; set; }
        public string Lote { get; set; }
        public Nullable<System.DateTime> Fecha_elaboracion { get; set; }
        public Nullable<System.DateTime> Fecha_vencimiento { get; set; }
        public string Serie { get; set; }
        public Nullable<decimal> Peso { get; set; }
        public string Variable1 { get; set; }
        public string Variable2 { get; set; }
        public string Variable3 { get; set; }
        public string Variable4 { get; set; }
        public string Variable5 { get; set; }
        public string Ubicacion { get; set; }
        public string Identificador_erp { get; set; }
        public string Estado_erp { get; set; }
        public Nullable<int> Numero_oleada { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public Nullable<decimal> Neto { get; set; }
        public string Session_id { get; set; }
        public string Estado { get; set; }
        public string Usuario_creacion { get; set; }
        public System.DateTime Fecha_creacion { get; set; }
        public string Usuario_modificacion { get; set; }
        public Nullable<System.DateTime> Fecha_modificacion { get; set; }
    }
}