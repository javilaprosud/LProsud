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
    
    public partial class MLPedidoProcesado
    {
        public int MLPid { get; set; }
        public string MLPdocumento { get; set; }
        public string MLPposicion { get; set; }
        public string MLPsku { get; set; }
        public string MLPdescripcion { get; set; }
        public Nullable<double> MLPcantidadSolicitada { get; set; }
        public Nullable<double> MLPcantidadPicking { get; set; }
        public string MLPlote { get; set; }
        public Nullable<System.DateTime> MLPfchVencimiento { get; set; }
        public string MLPaliasBodega { get; set; }
        public Nullable<System.DateTime> MLPfchPicking { get; set; }
    }
}
