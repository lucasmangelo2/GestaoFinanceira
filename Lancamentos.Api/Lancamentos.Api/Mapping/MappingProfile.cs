using AutoMapper;
using Lancamentos.Api.Request;
using Lancamentos.Api.Response;
using Lancamentos.Domain.Models;

namespace Lancamentos.Api.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        { 
            
            CreateMap<InsereMovimentacaoRequest, Movimentacao>().ReverseMap();
            CreateMap<MovimentacaoResponse, Movimentacao>().ReverseMap();
        }
    }
}
