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
    
    public partial class VISTA_PRODUCTIVIDAD
    {
        public string Empresa { get; set; }
        public Nullable<int> Ano { get; set; }
        public string NombreProducto { get; set; }
        public string Cod_Departamento { get; set; }
        public string Departamento { get; set; }
        public string Cod_Linea { get; set; }
        public string LineaProducto { get; set; }
        public string Cod_Grupo { get; set; }
        public string Grupo { get; set; }
        public Nullable<short> Cod_Marca { get; set; }
        public string Marca { get; set; }
        public Nullable<double> C_ { get; set; }
        public Nullable<System.DateTime> ASIGNADO { get; set; }
        public Nullable<double> DEMORA_INICIO { get; set; }
        public Nullable<double> ENTRADA { get; set; }
        public Nullable<System.DateTime> HORA_ASIGNADO { get; set; }
        public Nullable<System.DateTime> HORA_INICIO { get; set; }
        public Nullable<System.DateTime> HORA_TERMINO { get; set; }
        public Nullable<System.DateTime> INICIO { get; set; }
        public Nullable<double> LINEAS { get; set; }
        public Nullable<double> MINUTOS { get; set; }
        public string NOMBRE { get; set; }
        public Nullable<double> OP { get; set; }
        public string PRODUCTO { get; set; }
        public Nullable<double> SALIDA { get; set; }
        public Nullable<System.DateTime> TERMINO { get; set; }
        public string TIPODOCTO { get; set; }
        public string NOMBRE_TIPODOCTO { get; set; }
        public string UBICACION_DESDE { get; set; }
        public string UBICACION_DESTINO { get; set; }
        public string UBICACION_FINAL { get; set; }
        public string USUARIO { get; set; }
        public string TIPOMOVIMIENTO { get; set; }
        public string NOMBRE_TIPOMOVIMIENTO { get; set; }
        public Nullable<System.DateTime> FECHA_VENCIMIENTO { get; set; }
        public Nullable<System.DateTime> FECHA_ELABORACION { get; set; }
        public string LOTE { get; set; }
        public Nullable<System.DateTime> FECHA_MOVIMIENTO { get; set; }
        public string DOCUMENTO_RESPALDO { get; set; }
        public Nullable<double> NUMERO_RESPALDO { get; set; }
        public string PALLET_ID { get; set; }
        public Nullable<int> Mes { get; set; }
    }
}