namespace Ecommerce.DAO.Entities;

public partial class Varianteproduto
{
    public int Id { get; set; }
    public int Produtoid { get; set; }
    public string Sku { get; set; } = null!;
    public decimal Preco { get; set; }
    public decimal? Precopromocional { get; set; }
    public decimal Precocusto { get; set; }
    public bool Ativo { get; set; }

    public virtual Produto Produto { get; set; } = null!;
    public virtual Estoque? Estoque { get; set; }
    public virtual List<Atributovariante> Atributos { get; set; } = new();
}
