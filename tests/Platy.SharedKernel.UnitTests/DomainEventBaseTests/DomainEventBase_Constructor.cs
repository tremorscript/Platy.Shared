using FluentAssertions;
using Platy.Shared;
using Xunit;

namespace Platy.SharedKernel.UnitTests.DomainEventBaseTests;

public class DomainEventBase_Constructor
{
  [Fact]
  public void SetsDateOccurredToCurrentDateTime()
  {
    // Arrange
    var beforeCreation = DateTime.UtcNow;

    // Act
    var domainEvent = new TestDomainEvent();

    // Assert
    domainEvent.DateOccurred.Should().BeOnOrAfter(beforeCreation);
    domainEvent.DateOccurred.Should().BeOnOrBefore(DateTime.UtcNow);
  }

  private class TestDomainEvent : DomainEventBase
  {
  }
}
