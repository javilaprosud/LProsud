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
    
    public partial class sisLogistico_seguimiento
    {
        public int idIngreso { get; set; }
        public Nullable<int> agenda_nop { get; set; }
        public string agenda_cli { get; set; }
        public string agenda_suc { get; set; }
        public Nullable<System.DateTime> agenda_fcarga { get; set; }
        public Nullable<System.DateTime> agenda_fentregaTrans { get; set; }
        public Nullable<System.TimeSpan> agenda_hEntrega { get; set; }
        public string ramplas_empTrans { get; set; }
        public string ramplas_anden { get; set; }
        public string ramplas_folioCita { get; set; }
        public Nullable<System.TimeSpan> ramplas_hAjendadas { get; set; }
        public string preparacion_HRuta { get; set; }
        public Nullable<System.TimeSpan> preparacion_OPaALMACEN { get; set; }
        public Nullable<System.TimeSpan> preparacion_OPaOPERADOR { get; set; }
        public Nullable<System.TimeSpan> preparacion_termino { get; set; }
        public Nullable<System.TimeSpan> guardia_arriboTrans { get; set; }
        public Nullable<System.TimeSpan> guardia_salidaTrans { get; set; }
        public Nullable<System.TimeSpan> carga_inicio { get; set; }
        public Nullable<System.TimeSpan> carga_fin { get; set; }
        public Nullable<System.TimeSpan> hojaruta_horaEmision { get; set; }
        public string responsable_operador { get; set; }
        public string responsable_eSalida { get; set; }
        public string responsable_despachador { get; set; }
        public string responsable_cargador { get; set; }
        public string responsable_cCalidad { get; set; }
        public string observaciones { get; set; }
        public Nullable<int> NULO { get; set; }
    }
}