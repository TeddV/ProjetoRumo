using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoRumo.Models
{
    public class PedidoCopa
    {
        public int PedidoId { get; set; }
        [ForeignKey("PedidoFK")]
        public Pedido Pedido { get; set; }
        public int CopaId { get; set; }
        [ForeignKey("CopaFK")]
        public Copa Copa { get; set; }
    }
}
