using Ecommerce.DAO.Identity;

namespace Ecommerce.DAO.Entities;

public partial class Usuario
{
    public int Id { get; set; }
    public string Nome { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Telefone { get; set; } = null!;
    public string Documento { get; set; } = null!;
    public bool Ativo { get; set; }
    public int? Tipousuarioid { get; set; }
    public string? UserId { get; set; }
    public DateTime Datacadastro { get; set; }
    public DateTime? Dataedicao { get; set; }
    public virtual AspNetUser? User { get; set; }
    public virtual Carrinho? Carrinho { get; set; }
    public virtual List<Endereco> Enderecos { get; set; } = new();
    public virtual List<Pedido> Pedidos { get; set; } = new();
    public virtual List<Avaliacao> Avaliacoes { get; set; } = new();
}
