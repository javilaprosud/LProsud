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
    
    public partial class AUDIT_UNDO
    {
        public int AUDIT_LOG_TRANSACTION_ID { get; set; }
        public string TABLE_NAME { get; set; }
        public string TABLE_SCHEMA { get; set; }
        public string ACTION_NAME { get; set; }
        public string HOST_NAME { get; set; }
        public string APP_NAME { get; set; }
        public string MODIFIED_BY { get; set; }
        public System.DateTime MODIFIED_DATE { get; set; }
        public int AFFECTED_ROWS { get; set; }
        public Nullable<int> AUDIT_LOG_DATA_ID { get; set; }
        public string PRIMARY_KEY { get; set; }
        public string COL_NAME { get; set; }
        public string OLD_VALUE { get; set; }
        public string NEW_VALUE { get; set; }
        public string DATA_TYPE { get; set; }
    }
}
