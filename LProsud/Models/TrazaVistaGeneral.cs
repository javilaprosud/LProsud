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
    
    public partial class TrazaVistaGeneral
    {
        public int ID { get; set; }
        public string RutCliente { get; set; }
        public string NomCliente { get; set; }
        public string CodigoSucursal { get; set; }
        public string NombreSucursal { get; set; }
        public Nullable<System.DateTime> FechaIngreso { get; set; }
        public Nullable<System.DateTime> FechaDespacho { get; set; }
        public string KAM { get; set; }
    }
}