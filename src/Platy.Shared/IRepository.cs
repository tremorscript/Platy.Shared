using System.Linq.Expressions;
using Ardalis.Result;

namespace Platy.Shared;

public interface IRepository<TEntity, TId, TReadModel, TCreateModel, TUpdateModel>
  where TEntity : class, IIdentity<TId>
  where TId : struct, IEquatable<TId>
  where TReadModel : IEntityReadModel
  where TCreateModel : IEntityCreateModel
  where TUpdateModel : IEntityUpdateModel
{
  Task<Result<TReadModel>> GetAsync(
    TId id,
    CancellationToken cancellationToken);

  Task<Result<IReadOnlyList<TReadModel>>> ListAsync(
    Expression<Func<TEntity, bool>> predicate,
    CancellationToken cancellationToken);

  Task<Result<TReadModel>> CreateAsync(
    TCreateModel createModel,
    CancellationToken cancellationToken);

  Task<Result<TReadModel>> UpdateAsync(
    TId id,
    TUpdateModel updateModel,
    CancellationToken cancellationToken);

  Task<Result<TReadModel>> DeleteAsync(
    TId id,
    CancellationToken cancellationToken);
}
