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
    
    public partial class VW_MLSTOCK
    {
        public int MLSid { get; set; }
        public string MLSAliasBodega { get; set; }
        public Nullable<double> MLSIdBodega { get; set; }
        public Nullable<double> MLSArticulo { get; set; }
        public string MLSSKU { get; set; }
        public string MLSDescripcion { get; set; }
        public string MLSIdEstado { get; set; }
        public string MLSEstado { get; set; }
        public string MLSLote { get; set; }
        public Nullable<System.DateTime> MLSfchVencimiento { get; set; }
        public Nullable<System.DateTime> MLSfchElaboracion { get; set; }
        public string MLSIdUnidad { get; set; }
        public string MLSUnidad { get; set; }
        public Nullable<double> MLSMaquilado { get; set; }
        public Nullable<double> MLSCantidad { get; set; }
        public Nullable<System.DateTime> MLSfchConsultada { get; set; }
    }
}