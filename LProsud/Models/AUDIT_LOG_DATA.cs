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
    
    public partial class AUDIT_LOG_DATA
    {
        public int AUDIT_LOG_DATA_ID { get; set; }
        public int AUDIT_LOG_TRANSACTION_ID { get; set; }
        public string PRIMARY_KEY_DATA { get; set; }
        public string COL_NAME { get; set; }
        public string OLD_VALUE_LONG { get; set; }
        public string NEW_VALUE_LONG { get; set; }
        public byte[] NEW_VALUE_BLOB { get; set; }
        public string NEW_VALUE { get; set; }
        public string OLD_VALUE { get; set; }
        public string PRIMARY_KEY { get; set; }
        public string DATA_TYPE { get; set; }
        public string KEY1 { get; set; }
        public string KEY2 { get; set; }
        public string KEY3 { get; set; }
        public string KEY4 { get; set; }
    
        public virtual AUDIT_LOG_TRANSACTIONS AUDIT_LOG_TRANSACTIONS { get; set; }
    }
}
