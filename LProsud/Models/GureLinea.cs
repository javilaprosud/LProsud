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
    
    public partial class GureLinea
    {
        public string GuReRut { get; set; }
        public string EmprCod { get; set; }
        public double GuReNumero { get; set; }
        public short GuReExtranjero { get; set; }
        public int GuReCorrelativo { get; set; }
        public string DocSSerie { get; set; }
        public string ProdCodigo { get; set; }
        public short MproCodigo { get; set; }
        public Nullable<short> GuReEstado { get; set; }
    }
}