using AutoMapper;
using tp3solution.Models.Repositories;

namespace tp3solution.Models.Service
{
    public class DtoService : IdtoService
    {
        private readonly IdtoRepositories __repository;

        private readonly IMapper _mapper;
        public DtoService(IdtoRepositories repository)
        {
            __repository = repository;
            _mapper = _mapper;
        }
        public DtoViewModel GetDto()
        {
            var dto = __repository.GetDto();
            return _mapper.Map<DtoViewModel>(dto);
            return new DtoViewModel()
            {
                Id = dto.Id,
                Tipo = dto.Tipo,
                Cantidad = dto.Cantidad
            };
        }

        object IdtoService.GetDto()
        {
            throw new NotImplementedException();
        }
    }
}
