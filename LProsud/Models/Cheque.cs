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
    
    public partial class Cheque
    {
        public string EmprCod { get; set; }
        public string InstCodigo { get; set; }
        public string IfemNumeroCuenta { get; set; }
        public double CheqCorrelativo { get; set; }
        public int CheqMovimiento { get; set; }
        public int CheqAno { get; set; }
        public Nullable<System.DateTime> CheqFecha { get; set; }
        public Nullable<double> CheqMonto { get; set; }
        public string CheqAQuien { get; set; }
        public Nullable<short> CheqEmitido { get; set; }
        public Nullable<System.DateTime> CheqFechaEmitido { get; set; }
        public Nullable<short> CheqAnulado { get; set; }
        public Nullable<short> CheqCruzado { get; set; }
        public Nullable<short> CheqNominativo { get; set; }
        public Nullable<short> CheqAlPortador { get; set; }
        public string CheqTablaDaOr { get; set; }
        public string CheqValor1 { get; set; }
        public string CheqValor2 { get; set; }
        public string CheqValor3 { get; set; }
        public string CheqValor4 { get; set; }
        public string CheqValor5 { get; set; }
        public string CheqValor6 { get; set; }
        public string CheqValor7 { get; set; }
        public string CheqValor8 { get; set; }
        public string CheqValor9 { get; set; }
        public string CheqValor10 { get; set; }
        public string CheqCampoCheque { get; set; }
        public string TCheCodigo { get; set; }
        public string CheNumero { get; set; }
        public string CheqMesPal { get; set; }
        public string CheqMontoPal { get; set; }
        public Nullable<short> CheqElectronico { get; set; }
        public string ChequeAQuienRut { get; set; }
        public Nullable<bool> ChequeAQuienExt { get; set; }
    }
}
