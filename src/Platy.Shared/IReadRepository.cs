namespace Platy.Shared;

/// <summary>
///   An abstraction for read only persistence operations.
///   Use this primarily to fetch trackable domain entities, not for custom queries.
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IReadRepository<T>
{
}
