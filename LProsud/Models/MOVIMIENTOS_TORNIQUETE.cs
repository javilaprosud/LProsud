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
    
    public partial class MOVIMIENTOS_TORNIQUETE
    {
        public string Empresa { get; set; }
        public Nullable<int> Año { get; set; }
        public Nullable<int> Mes { get; set; }
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public string CentroCosto { get; set; }
        public string DEPARTAMENTO { get; set; }
        public string Movimiento { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<System.TimeSpan> Hora { get; set; }
        public string Area { get; set; }
    }
}