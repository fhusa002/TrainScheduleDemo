using Xunit;
using Moq;
using Shouldly;
using TrainSchedule;

namespace TrainSchedule.Tests
{
    public class TrainServiceMoqTests
    {
        [Fact]
        public void GetTrainById_ShouldReturnTrainFromRepository()
        {
            // Arrange
            var fakeTrain = new Train { Id = 1, Destination = "Melbourne", DepartureTime = "10:00" };

            // Create a mock repository
            var repoMock = new Mock<ITrainRepository>();

            // Setup behavior: when GetTrain(1) is called, return fakeTrain
            repoMock.Setup(r => r.GetTrain(1)).Returns(fakeTrain);

            var service = new TrainServiceWithRepo(repoMock.Object);


            // Act
            var result = service.GetTrainById(1);

            // Assert
            result.ShouldNotBeNull();
            result.Destination.ShouldBe("Melbourne");

            // Verify that the method was actually called once
            repoMock.Verify(r => r.GetTrain(1), Times.Once);
        }
    }
}
