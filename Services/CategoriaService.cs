using PracticaWinFormsTienda.Data;
using PracticaWinFormsTienda.Models;
using PracticaWinFormsTienda.Repositories.Interfaces;
using PracticaWinFormsTienda.Services;
using PracticaWinFormsTienda.Services.Interfaces;
using PracticaWinFormsTienda.Utils;

public class CategoriaService
    : GenericService<CategoriaDto, Categoria>, ICategoriaService
{
    public CategoriaService(
        ICategoriaRepository repository,
        IUnitOfWork unitOfWork)
        : base(
              repository,
              unitOfWork,
              MapperHelper.ToDTO,
              MapperHelper.ToEntity)
    {
    }
}