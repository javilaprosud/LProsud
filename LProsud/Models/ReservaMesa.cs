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
    
    public partial class ReservaMesa
    {
        public string EmprCod { get; set; }
        public string mesaCodigo { get; set; }
        public System.DateTime ReMeFecha { get; set; }
        public System.DateTime ReMeHora { get; set; }
        public string ReMeObs { get; set; }
        public Nullable<int> ReMeCantPers { get; set; }
        public Nullable<short> ReMeAnula { get; set; }
    }
}