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
    
    public partial class VW_Asistencia_SupplyChain
    {
        public string Gerencia { get; set; }
        public string Departamento { get; set; }
        public string Area { get; set; }
        public string UnidadDependencia { get; set; }
        public string FECHA { get; set; }
        public string DESCIPCION { get; set; }
        public string MES { get; set; }
        public string AÑO { get; set; }
        public string RUT { get; set; }
        public Nullable<int> SEMANA { get; set; }
        public Nullable<int> DiaSemana { get; set; }
        public string TipoTurno { get; set; }
        public string TurnoEntrada { get; set; }
        public string TurnoSalida { get; set; }
        public string HoraEntrada { get; set; }
        public string HoraSalida { get; set; }
        public string HoraEntradaColacion { get; set; }
        public string HoraSalidaColacion { get; set; }
        public Nullable<int> HorasExtras { get; set; }
        public Nullable<int> HorasAtraso { get; set; }
        public Nullable<int> HorasAntesSalida { get; set; }
        public Nullable<int> HorasPermiso { get; set; }
        public int HoraExtraAutorizada { get; set; }
        public string MotivoPermiso { get; set; }
        public string NombreEmpleado { get; set; }
    }
}
