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
    
    public partial class stock_lot_vutil
    {
        public string Empresa { get; set; }
        public short Año { get; set; }
        public short Mes { get; set; }
        public string Almacen { get; set; }
        public string Cod_Producto { get; set; }
        public string Nom_Producto { get; set; }
        public string Cod_departamento { get; set; }
        public string Nom_departamento { get; set; }
        public string Cod_Linea_Pro { get; set; }
        public string Nom_Linea_Prod { get; set; }
        public Nullable<short> Cod_Marca { get; set; }
        public string Nom_Marca { get; set; }
        public string Cod_Grupo_Producto { get; set; }
        public string Nom_Grupo { get; set; }
        public Nullable<double> Unidades { get; set; }
        public Nullable<double> Stk_Minimo { get; set; }
        public Nullable<double> Stk_maximo { get; set; }
        public Nullable<double> Cajas { get; set; }
        public Nullable<double> Kilos { get; set; }
        public Nullable<double> CostoUnitarioPMP { get; set; }
        public Nullable<double> CostoTotalPMP { get; set; }
        public Nullable<double> stk_Comprometido { get; set; }
        public Nullable<double> Stk_Pedido { get; set; }
        public string LNroLote { get; set; }
        public string LFvcto { get; set; }
        public Nullable<short> tVida { get; set; }
        public string LZona { get; set; }
        public string LRack { get; set; }
        public string LNivel { get; set; }
        public string LPosicion { get; set; }
        public string LProfundidad { get; set; }
        public Nullable<double> LCant_Unidades { get; set; }
        public string LFRecepcion { get; set; }
    }
}
