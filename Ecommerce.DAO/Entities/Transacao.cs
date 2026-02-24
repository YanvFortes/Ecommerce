using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.DAO.Entities
{
    public partial class Transacao
    {
        public int Id { get; set; }
        public int Pedidoid { get; set; }

        public string Status { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public decimal Valor { get; set; }

        public DateTime Datacriacao { get; set; }
        public DateTime? Datapagamento { get; set; }

        public virtual Pedido Pedido { get; set; } = null!;
    }
}
