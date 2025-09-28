using Ardalis.Specification;

namespace Platy.Shared;

/// <summary>
/// An abstraction for persistence
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IRepository<T> : IRepositoryBase<T> where T : class, IAggregateRoot
{
}
