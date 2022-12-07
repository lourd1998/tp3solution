namespace tp3solution.Models.Repositories
{
    public class DtoRepository : IdtoRepositories
    {
        public Dto GetDto()
        {
            return new Dto
            {
                Id = 1,
                Tipo = "usado",
                Cantidad = 2
            };
        }
    }
}
