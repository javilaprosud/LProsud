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
    
    public partial class TipMoneda
    {
        public string TipmCodigo { get; set; }
        public string TipmNombre { get; set; }
        public Nullable<short> TipmSistema { get; set; }
        public Nullable<short> TipmCantDec { get; set; }
        public Nullable<short> TipmExtranjera { get; set; }
        public string TipmPais { get; set; }
        public Nullable<short> TipmDecPreCom { get; set; }
    }
}