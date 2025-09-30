using FluentAssertions;
using Platy.Shared;
using Xunit;

namespace Platy.SharedKernel.UnitTests.EntityBaseTests;

public class EntityBase_AddDomainEvent
{
  [Fact]
  public void AddsDomainEventToEntity()
  {
    // Arrange
    var entity = new TestEntity();

    // Act
    entity.AddTestDomainEvent();

    // Assert
    entity.DomainEvents.Should().HaveCount(1);
    entity.DomainEvents.Should().AllBeOfType<TestDomainEvent>();
  }

  private class TestDomainEvent : DomainEventBase
  {
  }

  private class TestEntity : EntityBase
  {
    public void AddTestDomainEvent()
    {
      var domainEvent = new TestDomainEvent();
      RegisterDomainEvent(domainEvent);
    }
  }
}
