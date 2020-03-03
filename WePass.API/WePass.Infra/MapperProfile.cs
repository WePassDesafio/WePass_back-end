using AutoMapper;
using WePass.Infra.Entities;

namespace WePass.Infra
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Domain.Model.Compra, Compra>().ReverseMap();
            CreateMap<Domain.Model.Evento, Evento>().ReverseMap();
            CreateMap<Domain.Model.Usuario, Usuario>().ReverseMap();
            CreateMap<Domain.Model.Pagamento, Pagamento>().ReverseMap();
        }
    }
}
