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
    
    public partial class OrdenTrabajo
    {
        public string EmprCod { get; set; }
        public string ProyeCodigo { get; set; }
        public string OTCodigo { get; set; }
        public short OTRevision { get; set; }
        public string OTVigente { get; set; }
        public Nullable<System.DateTime> OTFecha { get; set; }
        public string OTDesc { get; set; }
        public string OCNumero { get; set; }
        public Nullable<System.DateTime> OCfecha { get; set; }
        public string OTContrato { get; set; }
        public Nullable<System.DateTime> OTFechaCont { get; set; }
        public string OTConsignacion { get; set; }
        public Nullable<System.DateTime> OTFechaConsig { get; set; }
        public string OTComentarios { get; set; }
        public string OTNotas { get; set; }
        public string OTObservaciones { get; set; }
        public string OTProduccion { get; set; }
        public Nullable<System.DateTime> OTFechaProduc { get; set; }
        public string OTComercial { get; set; }
        public Nullable<System.DateTime> OTFechaComer { get; set; }
        public Nullable<System.DateTime> OTFechaAutorizacion { get; set; }
        public string ListCodigo { get; set; }
        public Nullable<short> OTTasa { get; set; }
        public string TiflCodigo { get; set; }
        public string TdocCodigo { get; set; }
        public string OTLugarEntrega { get; set; }
        public string OTTranspOrig { get; set; }
        public string OTTranspDes { get; set; }
    }
}