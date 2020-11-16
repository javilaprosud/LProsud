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
    
    public partial class RegistroCapacitacion
    {
        public string EmprCod { get; set; }
        public string EmplRut { get; set; }
        public short EmplExtranjero { get; set; }
        public int TipoCapacitacion { get; set; }
        public string CurCod { get; set; }
        public int CurAno { get; set; }
        public string InstruCodigo { get; set; }
        public Nullable<System.DateTime> FechaInicio { get; set; }
        public Nullable<System.DateTime> FechaTermino { get; set; }
        public Nullable<double> Horas { get; set; }
        public Nullable<int> TipoEvaluacion { get; set; }
        public Nullable<int> TipoResultado { get; set; }
        public Nullable<double> ValorCurso { get; set; }
        public Nullable<int> CubreSence { get; set; }
        public Nullable<double> ParteSence { get; set; }
        public Nullable<double> ParteEmpresa { get; set; }
        public string Observaciones { get; set; }
        public Nullable<int> CursoAbierto { get; set; }
        public string Nota { get; set; }
        public string Nota3M { get; set; }
        public string Nota6M { get; set; }
        public string NotaDiagnostico { get; set; }
    }
}