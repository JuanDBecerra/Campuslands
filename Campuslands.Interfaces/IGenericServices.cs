namespace Campuslands.Interfaces
{
    public interface IGenericServices<TEntity>
    {
         void Create(TEntity entity);
         void Delete(int id);
         IEnumerable<TEntity> Get();

         TEntity? GetById(int id);

         void Update(TEntity entity);
    }
}
