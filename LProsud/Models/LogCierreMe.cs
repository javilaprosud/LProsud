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
    
    public partial class LogCierreMe
    {
        public long id { get; set; }
        public string Usuario { get; set; }
        public string Sistema { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Motivo { get; set; }
        public string NombrePC { get; set; }
        public string Empresa { get; set; }
        public string Mes { get; set; }
    }
}
