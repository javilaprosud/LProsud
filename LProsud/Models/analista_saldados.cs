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
    
    public partial class analista_saldados
    {
        public string Empresa { get; set; }
        public string NombreEmpresa { get; set; }
        public string Rut { get; set; }
        public int Ano { get; set; }
        public int Mes { get; set; }
        public int VouchNum { get; set; }
        public Nullable<double> CocoDoc { get; set; }
        public Nullable<double> debe { get; set; }
        public string CodDocumento { get; set; }
        public Nullable<double> haber { get; set; }
        public Nullable<double> saldo { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<System.DateTime> Vencimiento { get; set; }
        public string cuenta { get; set; }
    }
}
