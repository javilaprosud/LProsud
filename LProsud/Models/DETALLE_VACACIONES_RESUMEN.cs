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
    
    public partial class DETALLE_VACACIONES_RESUMEN
    {
        public string Empresa { get; set; }
        public short Año { get; set; }
        public short Mes { get; set; }
        public string Rut { get; set; }
        public string Apellido_P { get; set; }
        public string Apellido_M { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> TotalDiasTomados { get; set; }
        public Nullable<double> TotalDiasPeriodo2012 { get; set; }
        public Nullable<decimal> DiasPresenteAño { get; set; }
        public Nullable<double> DiasProgresivos { get; set; }
        public Nullable<double> TotalDiasVacaciones { get; set; }
        public string Cargo { get; set; }
        public string CentroCosto { get; set; }
        public string NOMBRE_SUPERVISOR { get; set; }
        public string DEPARTAMENTO { get; set; }
        public Nullable<System.DateTime> FechaContrato { get; set; }
        public string Comuna { get; set; }
        public Nullable<System.DateTime> Fecha_Finiquito { get; set; }
        public Nullable<int> TotalDiasHabiles { get; set; }
        public Nullable<int> TotalDias_NO_Habiles { get; set; }
        public Nullable<double> DiasRestantes { get; set; }
        public Nullable<double> DiasAcumulados { get; set; }
    }
}
