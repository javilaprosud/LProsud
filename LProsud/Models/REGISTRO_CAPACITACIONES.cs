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
    
    public partial class REGISTRO_CAPACITACIONES
    {
        public string Empresa { get; set; }
        public string Rut { get; set; }
        public string Apellido_P { get; set; }
        public string Apellido_M { get; set; }
        public string Nombre { get; set; }
        public string TIPO_CAPACITACION { get; set; }
        public string CODIGO_CURSO { get; set; }
        public string NOMBRE_CURSO { get; set; }
        public string NOMBRE_OTEC { get; set; }
        public Nullable<System.DateTime> FECHA_INICIO { get; set; }
        public Nullable<System.DateTime> FECHA_TERMINO { get; set; }
        public Nullable<double> HORAS { get; set; }
        public string EVALUACION { get; set; }
        public string MOTIVO_REPRUEBA { get; set; }
        public string CUBRE_SENCE { get; set; }
        public Nullable<double> VALOR_CURSO { get; set; }
        public Nullable<double> APORTA_SENCE { get; set; }
        public Nullable<double> APORTA_EMPRESA { get; set; }
        public string OBSERVACIONES { get; set; }
        public string DEPARTAMENTO { get; set; }
        public string CARGO { get; set; }
        public string NOTA { get; set; }
        public string NOTA_3_MESES { get; set; }
        public string NOTA_6_MESES { get; set; }
        public string NOTA_DIAGNOSTICO { get; set; }
        public int AÑO { get; set; }
    }
}
