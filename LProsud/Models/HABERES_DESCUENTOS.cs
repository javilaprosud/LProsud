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
    
    public partial class HABERES_DESCUENTOS
    {
        public string Empresa { get; set; }
        public short Año { get; set; }
        public short Mes { get; set; }
        public string Rut { get; set; }
        public string Apellido_P { get; set; }
        public string Apellido_M { get; set; }
        public string Nombre { get; set; }
        public string TIPO_HABER_DESCUENTO { get; set; }
        public string CODIGO_HABERDESCUENTO { get; set; }
        public string NOMBRE_HABER_DESCUENTO { get; set; }
        public Nullable<double> VALOR_UNITARIO { get; set; }
        public Nullable<double> CANTIDAD { get; set; }
        public Nullable<double> TOTAL { get; set; }
        public string CentroCosto { get; set; }
        public string DEPARTAMENTO { get; set; }
        public Nullable<System.DateTime> FechaFiniquitofdc { get; set; }
        public Nullable<short> Considera_Finiquito { get; set; }
        public string HImponible { get; set; }
        public string Cuenta_Contable { get; set; }
        public string Nombre_Cuenta_Contable { get; set; }
    }
}