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
    
    public partial class VISTA_PERSONAL_WEB
    {
        public short DoctAno { get; set; }
        public short DoctMes { get; set; }
        public string CodigoSupervisor { get; set; }
        public string SUPERVISOR { get; set; }
        public Nullable<int> CodigoReponedor { get; set; }
        public string Reponedor { get; set; }
        public Nullable<System.DateTime> MovMenFechaContrato { get; set; }
        public string codOrganica { get; set; }
    }
}