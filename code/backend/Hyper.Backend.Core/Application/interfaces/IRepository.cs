using System.Linq.Expressions;
using Domain;

namespace Application.interfaces;

public interface IRepository<T> where T : class, IEntity, new() {
    IList<T> GetAll();
    IList<T> GetByColor(string color);
    T? GetById(Guid id);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
    T? Get(Expression<Func<T, bool>> filter);
}
