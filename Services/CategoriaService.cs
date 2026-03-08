using PracticaWinFormsTienda.Data;
using PracticaWinFormsTienda.Repositories.Interfaces;
using PracticaWinFormsTienda.Services.Interfaces;
using PracticaWinFormsTienda.Services;
using PracticaWinFormsTienda.Utils;
using static System.Runtime.InteropServices.JavaScript.JSType;
using PracticaWinFormsTienda.Models;

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