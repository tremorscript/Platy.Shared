namespace Platy.Shared;

public interface ITrackCreated
{
  DateTimeOffset Created { get; set; }
  string? CreatedBy { get; set; }
}
