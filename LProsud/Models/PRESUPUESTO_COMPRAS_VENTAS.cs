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
    
    public partial class PRESUPUESTO_COMPRAS_VENTAS
    {
        public string Empresa { get; set; }
        public Nullable<int> Año { get; set; }
        public Nullable<int> Mes { get; set; }
        public string Cod_producto { get; set; }
        public string Nom_producto { get; set; }
        public string Cod_Linea { get; set; }
        public string Nom_Linea { get; set; }
        public Nullable<int> Cod_Marca { get; set; }
        public string Nom_Marca { get; set; }
        public Nullable<double> PresupuestoCAJAS { get; set; }
        public Nullable<double> PresupuestoUNIDADES { get; set; }
        public Nullable<double> PresupuestoKILOS { get; set; }
        public Nullable<double> VentaCAJAS { get; set; }
        public Nullable<double> VentaUNIDADES { get; set; }
        public Nullable<double> VentaKILOS { get; set; }
    }
}
