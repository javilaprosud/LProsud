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
    
    public partial class AUDIT_LOG_TRANSACTIONS
    {
        public AUDIT_LOG_TRANSACTIONS()
        {
            this.AUDIT_LOG_DATA = new HashSet<AUDIT_LOG_DATA>();
        }
    
        public int AUDIT_LOG_TRANSACTION_ID { get; set; }
        public string DATABASE { get; set; }
        public string TABLE_NAME { get; set; }
        public string TABLE_SCHEMA { get; set; }
        public byte AUDIT_ACTION_ID { get; set; }
        public string HOST_NAME { get; set; }
        public string APP_NAME { get; set; }
        public string MODIFIED_BY { get; set; }
        public System.DateTime MODIFIED_DATE { get; set; }
        public int AFFECTED_ROWS { get; set; }
        public Nullable<int> SYSOBJ_ID { get; set; }
    
        public virtual ICollection<AUDIT_LOG_DATA> AUDIT_LOG_DATA { get; set; }
    }
}
