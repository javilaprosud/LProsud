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
    
    public partial class MarcarGuia
    {
        public int id { get; set; }
        public Nullable<int> Op { get; set; }
        public Nullable<int> Guia { get; set; }
        public string RutCliente { get; set; }
        public string NombreCliente { get; set; }
        public Nullable<int> TdocCodigo { get; set; }
        public Nullable<int> DoctMovimiento { get; set; }
        public string RelcExtranjero { get; set; }
    }
}