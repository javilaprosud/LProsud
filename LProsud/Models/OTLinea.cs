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
    
    public partial class OTLinea
    {
        public string EmprCod { get; set; }
        public string ProyeCodigo { get; set; }
        public string OTCodigo { get; set; }
        public short OTRevision { get; set; }
        public double OTLiCorrel { get; set; }
        public Nullable<double> OTLiCantidad { get; set; }
        public string OTLiCodProducto { get; set; }
        public Nullable<short> OTLiEsKit { get; set; }
        public Nullable<double> OTLiPrecioUni { get; set; }
        public Nullable<System.DateTime> OTLiFechaEnt { get; set; }
        public string OTLiComentarios { get; set; }
    }
}
