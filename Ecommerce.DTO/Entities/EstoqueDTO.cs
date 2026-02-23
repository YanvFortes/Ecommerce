namespace Ecommerce.DTO.Entities;

public class EstoqueDTO
{
    public int Id { get; set; }
    public int VarianteId { get; set; }
    public int QuantidadeDisponivel { get; set; }
    public int QuantidadeReservada { get; set; }
}
