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
    
    public partial class Clientes_y_sucursales
    {
        public string Empresa { get; set; }
        public string Rut { get; set; }
        public short Ext { get; set; }
        public Nullable<short> Cliente { get; set; }
        public Nullable<short> Proveedor { get; set; }
        public Nullable<System.DateTime> Fecha_Pago { get; set; }
        public Nullable<System.DateTime> Fecha_Anticipo { get; set; }
        public string Cod_Clasificación { get; set; }
        public string Desc_Casificacion { get; set; }
        public string Nombre { get; set; }
        public string Giro { get; set; }
        public string Cod_Lista_Precio { get; set; }
        public string Nombre_lista_precio { get; set; }
        public Nullable<double> Descuento { get; set; }
        public Nullable<double> Credito_maximo { get; set; }
        public Nullable<double> Cre_Ocupado { get; set; }
        public double Cod_Sucursal { get; set; }
        public string Nombre_sucursal { get; set; }
        public string Dir_Sucursal { get; set; }
        public Nullable<short> Cod_region { get; set; }
        public string Nom_Region { get; set; }
        public Nullable<short> Cod_Ciudad { get; set; }
        public string Nom_Ciudad { get; set; }
        public Nullable<short> Cod_Comuna { get; set; }
        public string Nom_Comuna { get; set; }
        public string Cod_Pais { get; set; }
        public string Nom_Pais { get; set; }
        public string Fono_sucursal { get; set; }
        public string Fax_sucursal { get; set; }
        public string email_sucursal { get; set; }
        public Nullable<short> Cod_ejecutivo { get; set; }
        public string Nombre_Ejecutivo { get; set; }
        public string ZONA_GEOGRAFICA { get; set; }
        public string Direccion_Sucursal_Despacho { get; set; }
        public string CODIGO_EDI { get; set; }
        public string EQUIVALENCIA_SUC { get; set; }
        public string BLOQUEADO { get; set; }
    }
}