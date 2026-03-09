using PracticaWinFormsTienda.Repositories.Interfaces;

namespace PracticaWinFormsTienda.Services
{
    public class GenericService<TDto, TEntity>
        where TEntity : class
    {
        protected readonly IRepository<TEntity> _repository;
        protected readonly IUnitOfWork _unitOfWork;

        private readonly Func<TEntity, TDto> _toDto;
        private readonly Func<TDto, TEntity> _toEntity;

        public GenericService(
            IRepository<TEntity> repository,
            IUnitOfWork unitOfWork,
            Func<TEntity, TDto> toDto,
            Func<TDto, TEntity> toEntity)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _toDto = toDto;
            _toEntity = toEntity;
        }

        public async Task<List<TDto>> GetAllAsync()
        {
            var entities = await _repository.GetAllAsync();

            return entities.Select(_toDto).ToList();
        }

        public async Task AddAsync(TDto dto)
        {
            var entity = _toEntity(dto);

            await _repository.InsertAsync(entity);

            await _unitOfWork.SaveAsync();
        }

        public async Task UpdateAsync(TDto dto)
        {
            var entity = _toEntity(dto);

            await _repository.UpdateAsync(entity);

            await _unitOfWork.SaveAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);

            await _unitOfWork.SaveAsync();
        }
    }
}