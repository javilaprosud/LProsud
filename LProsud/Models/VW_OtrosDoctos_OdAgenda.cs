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
    
    public partial class VW_OtrosDoctos_OdAgenda
    {
        public string emprcod { get; set; }
        public double odocnumero { get; set; }
        public Nullable<System.DateTime> OdocFechaI { get; set; }
        public Nullable<short> OdocAno { get; set; }
        public Nullable<short> OdocMes { get; set; }
        public string Cliente { get; set; }
        public string Sucursal { get; set; }
        public string CodigoSucursal { get; set; }
        public Nullable<double> Cajas { get; set; }
        public Nullable<double> Diferencia { get; set; }
        public Nullable<int> Suma { get; set; }
    }
}
