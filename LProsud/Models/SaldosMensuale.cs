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
    
    public partial class SaldosMensuale
    {
        public string EmprCod { get; set; }
        public int meseAno { get; set; }
        public int meseNumero { get; set; }
        public string CtaCCodigo { get; set; }
        public string CodRCodigo { get; set; }
        public string TipmCodigo { get; set; }
        public Nullable<double> sameMonto { get; set; }
        public Nullable<double> sameMontoMonOri { get; set; }
        public Nullable<double> sameMontoAcumulado { get; set; }
        public Nullable<double> sameMontoAcumuladoMonOri { get; set; }
        public Nullable<double> sameMontoDebe { get; set; }
        public Nullable<double> sameMontoHaber { get; set; }
        public Nullable<double> sameMontoDebeOri { get; set; }
        public Nullable<double> sameMontoHaberOri { get; set; }
    }
}