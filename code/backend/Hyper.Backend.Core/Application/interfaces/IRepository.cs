using System.Linq.Expressions;
using Domain;

namespace Application.interfaces;

public interface IRepository<T> where T : Vehicle {
    IList<T> GetAll();
    T? GetById(Guid id);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
    T? Get(Expression<Func<T, bool>> filter);
    IList<T> GetList(Expression<Func<T, bool>>? filter = null);
}
