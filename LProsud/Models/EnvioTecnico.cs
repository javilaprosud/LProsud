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
    
    public partial class EnvioTecnico
    {
        public string EmprCod { get; set; }
        public short EnTeAno { get; set; }
        public string EnTeNumero { get; set; }
        public int EnTeTipo { get; set; }
        public string EnTeRut { get; set; }
        public bool EnTeExtranjero { get; set; }
        public System.DateTime EnTeFechaInicio { get; set; }
        public System.DateTime EnTeFechaTermino { get; set; }
        public Nullable<int> EnTeEstado { get; set; }
        public string EnTeRutResponsable { get; set; }
        public bool EnTeExtResponsable { get; set; }
        public string EnTeComentario { get; set; }
        public Nullable<System.DateTime> EnTeHoraInicio { get; set; }
        public Nullable<System.DateTime> EnTeHoraTermino { get; set; }
        public Nullable<double> EnteCorrel { get; set; }
        public string EnteRutSupervisor { get; set; }
        public Nullable<System.DateTime> EnteFechaVisita { get; set; }
        public string GuReNumero { get; set; }
        public string DocSSerie { get; set; }
        public string GureRut { get; set; }
        public Nullable<bool> GureExtranjero { get; set; }
    }
}
