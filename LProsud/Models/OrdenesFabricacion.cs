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
    
    public partial class OrdenesFabricacion
    {
        public string EmprCod { get; set; }
        public short OrFaAno { get; set; }
        public double OrFaCodigo { get; set; }
        public Nullable<System.DateTime> OrFaFechaIng { get; set; }
        public Nullable<short> OrFaFinalizada { get; set; }
        public string AlmaCodigo { get; set; }
        public Nullable<short> EmplCodigo_Ini { get; set; }
        public Nullable<short> EmplCodigo_Ter { get; set; }
        public string AlmaCodigoDestMP { get; set; }
    }
}
