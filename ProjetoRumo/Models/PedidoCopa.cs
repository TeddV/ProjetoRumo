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
       public Pedido Pedido { get; set; }     
       public int CopaId { get; set; }
        public Copa Copa { get; set; }
    }
}
