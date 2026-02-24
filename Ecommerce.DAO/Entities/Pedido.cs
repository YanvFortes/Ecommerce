using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.DAO.Entities;

public partial class Pedido
{
    public int Id { get; set; }
    public int Usuarioid { get; set; }

    public string Status { get; set; } = null!;

    public decimal Valortotal { get; set; }
    public decimal Valorfrete { get; set; }
    public decimal Valordesconto { get; set; }

    public DateTime Datacadastro { get; set; }
    public DateTime? Dataedicao { get; set; }

    public virtual Usuario Usuario { get; set; } = null!;
    public virtual List<Itempedido> Itens { get; set; } = new();
    public virtual List<Transacao> Transacoes { get; set; } = new();
    public virtual Entrega? Entrega { get; set; }
}
