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
    
    public partial class MovimientoMensual_20180115
    {
        public string EmprCod { get; set; }
        public string EmplRut { get; set; }
        public short EmplExtranjero { get; set; }
        public short HabDesAno { get; set; }
        public short HabDesMes { get; set; }
        public int MovMenCorrel { get; set; }
        public string MovMenCodigo { get; set; }
        public Nullable<System.DateTime> MovMenFechaInicial { get; set; }
        public Nullable<System.DateTime> MovMenFechaTermino { get; set; }
        public string MovMenRut { get; set; }
        public Nullable<short> MovMenExt { get; set; }
        public Nullable<short> MovMenTrabAgric { get; set; }
        public Nullable<double> MovMenSdoBasePactado { get; set; }
        public Nullable<int> MovMenDiasContra { get; set; }
        public Nullable<short> MovMenDiasAusente { get; set; }
        public Nullable<short> MovMenDiasNoContratado { get; set; }
        public Nullable<short> MovMenDiasLicencia { get; set; }
        public string MovMenHXNormales { get; set; }
        public string MovMenHXNocturnas { get; set; }
        public string MovMenHDescuento { get; set; }
        public string MovMenHXFestivos { get; set; }
        public Nullable<double> MovMenXHNorMonto { get; set; }
        public Nullable<double> MovMenXHNocMonto { get; set; }
        public Nullable<double> MovMenXHFesMonto { get; set; }
        public Nullable<double> MovMenHDesMonto { get; set; }
        public Nullable<double> MovMenOtroImponible { get; set; }
        public Nullable<double> MovMenOtroIsapre { get; set; }
        public Nullable<double> MovMenImptoUnico { get; set; }
        public Nullable<double> MovMenImptoUnicoRel { get; set; }
        public string MovMenAFPCod { get; set; }
        public Nullable<short> MovMenAFPCotAdicTipo { get; set; }
        public Nullable<double> MovMenAFPCotAdicMonto { get; set; }
        public Nullable<double> MovMenAFPCotObli { get; set; }
        public Nullable<double> MovMenAFPCotVolu { get; set; }
        public Nullable<short> MovMenAFPCtaAhorroTipo { get; set; }
        public Nullable<double> MovMenAFPCtaAhorroMonto { get; set; }
        public string MovMenISACod { get; set; }
        public Nullable<short> MovMenISATipoCot { get; set; }
        public Nullable<double> MovMenISACotAdicTipo { get; set; }
        public Nullable<double> MovMenISACotAdicMonto { get; set; }
        public Nullable<short> MovMenTieneDosPor { get; set; }
        public Nullable<short> MovMenISATipoDosPor { get; set; }
        public Nullable<double> MovMenISADosPorMonto { get; set; }
        public Nullable<short> MovMenGratificaTipo { get; set; }
        public Nullable<double> MovMenGratificaMonto { get; set; }
        public string InstCodigo { get; set; }
        public string SucuCodigo { get; set; }
        public string CodResultado { get; set; }
        public string MovMenCargoDesem { get; set; }
        public Nullable<short> MovMenRetroSimple { get; set; }
        public Nullable<short> MovMenRetroMaternales { get; set; }
        public Nullable<short> MovMenRetroInvalidez { get; set; }
        public Nullable<short> MovMenTipoSueldo { get; set; }
        public string MovMenTipMonedaCodigo { get; set; }
        public Nullable<short> MovMenDiaCambio { get; set; }
        public Nullable<double> MovMenAsigColacion { get; set; }
        public Nullable<double> MovMenAsigMovilizacion { get; set; }
        public Nullable<double> MovMenAsigZonaEx { get; set; }
        public string MovMenLabor { get; set; }
        public string MovMenHorario { get; set; }
        public string MovMenNCuenta { get; set; }
        public Nullable<short> MovMenFormaPago { get; set; }
        public Nullable<short> MovMenDiasLaborales { get; set; }
        public Nullable<short> MovMenHorasSemanales { get; set; }
        public Nullable<System.DateTime> MovMenFechaContrato { get; set; }
        public Nullable<double> MovMenRetroMonto { get; set; }
        public Nullable<short> MovMenCargaSimple { get; set; }
        public Nullable<short> MovMenCargaMaternal { get; set; }
        public Nullable<short> MovMenCargaInvalidez { get; set; }
        public Nullable<double> MovMenCargaMonto { get; set; }
        public Nullable<double> MovMenDiasColacion { get; set; }
        public Nullable<double> MovMenDiasMovilizacion { get; set; }
        public Nullable<System.DateTime> MovMenFechaFiniquito { get; set; }
        public Nullable<double> MovMenISAServicios { get; set; }
        public Nullable<short> MovMenAFPExtranjero { get; set; }
        public Nullable<short> MovMenIsaExtranjero { get; set; }
        public Nullable<double> MovMenSdoProporcional { get; set; }
        public Nullable<short> MovMenTipoHE { get; set; }
        public Nullable<double> MovMenFeLeProgresivo { get; set; }
        public Nullable<short> MovMenSegDes { get; set; }
        public string MovMenInstSegDes { get; set; }
        public Nullable<int> MovMenTipContrato { get; set; }
        public Nullable<double> MovMenDepositoConvenido { get; set; }
        public Nullable<short> MovMenZonaExtrema { get; set; }
        public Nullable<double> MovMenPorZonaExtrema { get; set; }
        public Nullable<short> MovMenAfiliadoCCHC { get; set; }
        public Nullable<short> MovMenTipoPlanCCHC { get; set; }
        public Nullable<short> MovMenNoProporcional { get; set; }
        public Nullable<short> MovMenActual { get; set; }
        public Nullable<System.DateTime> MovMenFechaIRetro { get; set; }
        public Nullable<System.DateTime> MovMenFechaTRetro { get; set; }
        public Nullable<double> MovMenLey20255 { get; set; }
        public Nullable<short> MovMenTrabLey20255 { get; set; }
        public Nullable<double> MovMenISACotAdicMonto_2 { get; set; }
        public string MovMenSubZona { get; set; }
        public string MovMenHXDom { get; set; }
        public Nullable<double> MovMenHXDomMonto { get; set; }
    }
}
