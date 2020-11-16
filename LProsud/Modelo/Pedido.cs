using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LProsud.Modelo
{
    public class Pedido
    {
        public string IDKey { get; set; }
        public string Cliente { get; set; }
        public string Documento { get; set; }
        public string FechaPedido { get; set; }
        public string FechaDespacho { get; set; }
        public string NombreCli { get; set; }
        public string DireccionCli { get; set; }
        public string ComunaCli { get; set; }
        public string RutCli { get; set; }
        public string TotalPosiciones { get; set; }
        public string AliasBodega { get; set; }
        public string Observacion { get; set; }
        public Items[] Items { get; set; }
    }
}