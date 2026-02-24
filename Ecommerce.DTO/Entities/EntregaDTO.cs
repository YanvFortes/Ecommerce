namespace Ecommerce.DTO.Entities;

public class EntregaDTO
{
    public int Id { get; set; }
    public int PedidoId { get; set; }
    public string Transportadora { get; set; } = string.Empty;
    public string CodigoRastreamento { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public DateTime? EnviadoEm { get; set; }
    public DateTime? EntregueEm { get; set; }
}
