namespace Platy.Shared;

public interface IIdentity<TId>
  where TId : struct, IEquatable<TId>
{
  public TId Id { get; set; } 
}
