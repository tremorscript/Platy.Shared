using Platy.Shared;

namespace Platy.SharedKernel.UnitTests.ValueObjectTests;

public class TestValueObject : ValueObject
{
  public TestValueObject(int value)
  {
    Value = value;
  }

  public int Value { get; }

  protected override IEnumerable<object> GetEqualityComponents()
  {
    yield return Value;
  }
}
