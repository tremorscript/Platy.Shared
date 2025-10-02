namespace Platy.Shared;

public interface ITrackConcurrency
{
  string RowVersion { get; set; }
}
