namespace Ecommerce.DAO.Entities;

public partial class Avaliacao
{
    public int Id { get; set; }
    public int Produtoid { get; set; }
    public int Usuarioid { get; set; }
    public int Nota { get; set; }
    public string Comentario { get; set; } = null!;
    public DateTime Datacadastro { get; set; }

    public virtual Produto Produto { get; set; } = null!;
    public virtual Usuario Usuario { get; set; } = null!;
}
