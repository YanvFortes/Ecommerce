namespace Ecommerce.DAO.Entities;

public partial class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; } = null!;
    public string? Descricao { get; set; }
    public int Categoriaid { get; set; }
    public bool Ativo { get; set; }
    public DateTime Datacadastro { get; set; }
    public DateTime? Dataedicao { get; set; }

    public virtual Categoria Categoria { get; set; } = null!;
    public virtual List<Varianteproduto> Variantes { get; set; } = new();
    public virtual List<Imagemproduto> Imagens { get; set; } = new();
    public virtual List<Avaliacao> Avaliacoes { get; set; } = new();
}
