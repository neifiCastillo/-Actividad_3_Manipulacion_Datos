using PracticaWinFormsTienda.Data;
using PracticaWinFormsTienda.Models;
using PracticaWinFormsTienda.Repositories.Interfaces;
using PracticaWinFormsTienda.Services.Interfaces;
using PracticaWinFormsTienda.Utils;

namespace PracticaWinFormsTienda.Services
{
    public class ProductoService
        : GenericService<ProductoDto, Producto>, IProductoService
    {
        private readonly IProductoRepository _productoRepository;

        public ProductoService(
            IProductoRepository repository,
            IUnitOfWork unitOfWork)
            : base(
                repository,
                unitOfWork,
                MapperHelper.ToDTO,
                MapperHelper.ToEntity)
        {
            _productoRepository = repository;
        }

        public async Task<List<ProductoDto>> GetAllWithCategoriaAsync()
        {
            var productos = await _productoRepository.GetAllWithCategoriaAsync();

            return productos
                .Select(MapperHelper.ToDTO)
                .ToList();
        }
    }
}