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
    
    public partial class DTE_recibido_SII
    {
        public int id { get; set; }
        public Nullable<int> dte { get; set; }
        public string tipo_transaccion { get; set; }
        public string rut { get; set; }
        public string razon_social { get; set; }
        public string folio { get; set; }
        public string fecha { get; set; }
        public string fecha_recepcion { get; set; }
        public string fecha_acuse { get; set; }
        public string exento { get; set; }
        public string neto { get; set; }
        public string iva { get; set; }
        public string iva_no_recuperable_monto { get; set; }
        public string iva_no_recuperable_codigo { get; set; }
        public string total { get; set; }
        public string monto_activo_fijo { get; set; }
        public string monto_iva_activo_fijo { get; set; }
        public string iva_uso_comun { get; set; }
        public string impuesto_sin_credito { get; set; }
        public string iva_no_retenido { get; set; }
        public string impuesto_puros { get; set; }
        public string impuesto_cigarrillos { get; set; }
        public string impuesto_tabaco_elaborado { get; set; }
        public string emisor_nc_nd_fc { get; set; }
    }
}
