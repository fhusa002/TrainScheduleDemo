using Xunit;
using Shouldly;
using TrainSchedule;
using AutoFixture;

namespace TrainSchedule.Tests
{
    public class TrainServiceTests
    {
        [Fact]  // tells xUnit that this is a test case
        public void AddTrain_ShouldIncreaseCount()
        {
            // Arrange (set up)
            var service = new TrainService();
            var train = new Train { Id = 1, Destination = "Melbourne", DepartureTime = "10:00" };

            // Act (perform action)
            service.AddTrain(train);

            // Assert (verify)
            service.Count.ShouldBe(1);
        }
        [Fact]
        public void AddRandomTrain_ShouldIncreaseCount()
        {
            var fixture = new Fixture();
            var service = new TrainService();
            var train = fixture.Create<Train>();
            service.AddTrain(train);
            service.Count.ShouldBe(1);
        }
    }   
}
