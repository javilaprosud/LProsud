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
    
    public partial class Lock
    {
        public string LockCodigo { get; set; }
        public string UsrsCodigo { get; set; }
        public Nullable<System.DateTime> LockFechaIni { get; set; }
        public Nullable<System.DateTime> LockFechaFin { get; set; }
        public Nullable<System.DateTime> LockHoraIni { get; set; }
        public Nullable<System.DateTime> LockHoraFin { get; set; }
        public string LockPC { get; set; }
        public string LockSistema { get; set; }
    }
}
