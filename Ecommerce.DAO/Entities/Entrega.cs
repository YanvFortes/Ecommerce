namespace Ecommerce.DAO.Entities;

public partial class Entrega
{
    public int Id { get; set; }
    public int Pedidoid { get; set; }
    public string Transportadora { get; set; } = null!;
    public string Codigorastreamento { get; set; } = null!;
    public string Status { get; set; } = null!;
    public DateTime? Enviadoem { get; set; }
    public DateTime? Entregueem { get; set; }
    public virtual Pedido Pedido { get; set; } = null!;
}
