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
    
    public partial class DocEstado
    {
        public short DoctMovimiento { get; set; }
        public string RelcRut { get; set; }
        public string EmprCod { get; set; }
        public string TdocCodigo { get; set; }
        public double DoctNumero { get; set; }
        public string SucuCodigo { get; set; }
        public bool RelcExtranjero { get; set; }
        public Nullable<int> DoctEstado { get; set; }
        public Nullable<System.DateTime> DocFecha { get; set; }
        public string DocUsuario { get; set; }
        public string DocGlosa1 { get; set; }
        public string DocGlosa2 { get; set; }
    }
}