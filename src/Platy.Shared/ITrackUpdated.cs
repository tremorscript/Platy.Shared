namespace Platy.Shared;

internal interface ITrackUpdated
{
  DateTimeOffset Updated { get; set; }
  string? UpdatedBy { get; set; }
}
