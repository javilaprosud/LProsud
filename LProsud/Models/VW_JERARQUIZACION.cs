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
    
    public partial class VW_JERARQUIZACION
    {
        public string empresa { get; set; }
        public string RutEpleado { get; set; }
        public string NombreEmpleado { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public string UnidadDependencia { get; set; }
        public string CodigoUnidadDependencia { get; set; }
        public string esJefe { get; set; }
        public Nullable<int> NivelJerarquia { get; set; }
        public string CodigoUnidadSuperior { get; set; }
        public string UnidadSuperior { get; set; }
        public string JefeDirecto { get; set; }
        public string JefeDirectoRut { get; set; }
        public string Gerencia { get; set; }
        public string Departamento { get; set; }
        public string Area { get; set; }
    }
}