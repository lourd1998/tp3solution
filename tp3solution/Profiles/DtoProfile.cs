using AutoMapper;
using tp3solution.Models;

namespace tp3solution.Profiles
{
    public class DtoProfile : Profile
    {
        public DtoProfile()
        {
            CreateMap<Dto, DtoViewModel>();
        }
    }
}
