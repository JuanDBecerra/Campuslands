using Campuslands.Interfaces;
using System.Resources;

namespace Campuslands.Services
{
    /// <summary>
    /// Clase base abstracta para los servicios genéricos.
    /// </summary>
    /// <typeparam name="TEntity">Tipo de entidad que manejará el servicio.</typeparam>
    public abstract class GenericService<TEntity> : IGenericServices<TEntity>
    {
        /// <summary>
        /// Repositorio que se utilizará para acceder a los datos.
        /// </summary>
        protected readonly IRepository<TEntity> _repository;

        /// <summary>
        /// Mediador para comunicarse con otros servicios.
        /// </summary>
        protected readonly IMediatorService _mediator;

        /// <summary>
        /// Constructor de la clase GenericService.
        /// </summary>
        /// <param name="repository">Repositorio que se utilizará para acceder a los datos.</param>
        /// <param name="mediator">Mediador para comunicarse con otros servicios.</param>
        protected GenericService(IRepository<TEntity> repository, IMediatorService mediator)
        {
            _repository = repository;
            _mediator = mediator;
        }

        public void Create(TEntity entity)
        {
            _repository.AddAsync(entity);
        }

        public void Delete(int id)
        {
            _repository.DeleteAsync(id);
        }

        public IEnumerable<TEntity> Get()
        {
            var result = _repository.GetAllAsync();
            return result.Result;
        }

        public TEntity? GetById(int id)
        {
            var result = _repository.GetByIdAsync(id);
            if (result == null)
                return default;
            return result.Result;
        }

        public void Update(TEntity entity)
        {
            _repository.UpdateAsync(entity);
        }
    }
}

