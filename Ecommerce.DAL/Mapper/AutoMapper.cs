using AutoMapper;
using Ecommerce.DAO.Entities;
using Ecommerce.DTO.Entities;

namespace Ecommerce.DAL.Mapper;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Usuario, UsuarioDTO>().ReverseMap();
        CreateMap<Endereco, EnderecoDTO>().ReverseMap();
        CreateMap<Pedido, PedidoDTO>().ReverseMap();
        CreateMap<Itempedido, ItemPedidoDTO>().ReverseMap();
        CreateMap<Transacao, TransacaoDTO>().ReverseMap();
        CreateMap<Entrega, EntregaDTO>().ReverseMap();
        CreateMap<Produto, ProdutoDTO>().ReverseMap();
        CreateMap<Varianteproduto, VarianteProdutoDTO>().ReverseMap();
        CreateMap<Estoque, EstoqueDTO>().ReverseMap();
        CreateMap<Categoria, CategoriaDTO>().ReverseMap();
        CreateMap<Cupom, CupomDTO>().ReverseMap();
        CreateMap<Avaliacao, AvaliacaoDTO>().ReverseMap();
    }
}
