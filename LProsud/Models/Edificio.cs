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
    
    public partial class Edificio
    {
        public string EdifCod { get; set; }
        public string CoprRut { get; set; }
        public Nullable<short> CoprExtranjero { get; set; }
        public Nullable<double> EdifMetros { get; set; }
        public string EdifConstructora { get; set; }
        public string EdifContacto { get; set; }
        public string EdifFonoContacto { get; set; }
        public Nullable<short> EdifIntTipo { get; set; }
        public Nullable<double> EdifIntTasa { get; set; }
        public Nullable<double> EdifIntMonto { get; set; }
        public Nullable<double> EdifIntPorcentaje { get; set; }
        public Nullable<short> EdifIntPeriodicidad { get; set; }
        public Nullable<short> EdifRecTipo { get; set; }
        public Nullable<double> EdifRecTasa { get; set; }
        public Nullable<double> EdifRecMonto { get; set; }
        public Nullable<double> EdifRecPorcentaje { get; set; }
        public Nullable<short> EdifRecPeriodicidad { get; set; }
        public Nullable<int> EdifFondoTipo { get; set; }
        public Nullable<double> EdifFondoPorcentaje { get; set; }
        public Nullable<double> EdifFondoMonto { get; set; }
        public Nullable<int> EdifFaxContacto { get; set; }
        public Nullable<short> EdifInTipoPor { get; set; }
        public Nullable<short> EdifRecTipoPor { get; set; }
        public Nullable<short> EdifArriendo { get; set; }
        public string EdifTipmCodigoArr { get; set; }
        public Nullable<short> EdifFechaArr { get; set; }
    }
}
