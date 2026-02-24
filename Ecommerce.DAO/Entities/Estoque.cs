namespace Ecommerce.DAO.Entities;

public partial class Estoque
{
    public int Id { get; set; }
    public int Varianteid { get; set; }

    public int Quantidadedisponivel { get; set; }
    public int Quantidadereservada { get; set; }

    public DateTime Datacadastro { get; set; }
    public DateTime? Dataedicao { get; set; }

    public virtual Varianteproduto Variante { get; set; } = null!;
    public virtual List<Movimentacaoestoque> Movimentacoes { get; set; } = new();
}
