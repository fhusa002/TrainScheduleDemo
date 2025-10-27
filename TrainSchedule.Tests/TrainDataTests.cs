using Xunit;
using Bogus;
using Shouldly;
using System;
using System.Collections.Generic;

namespace TrainSchedule.Tests
{
    public class TrainDataTests
    {
        [Fact]
        public void ShouldGenerateRealisticTrainData_AndDisplayIt()
        {
            // Arrange: define how train data should look
            var faker = new Faker<Train>()
                .RuleFor(t => t.Id, f => f.IndexFaker)
                .RuleFor(t => t.Destination, f => f.Address.City())
                .RuleFor(t => t.DepartureTime, f => f.Date.Future().ToShortTimeString());

            // Act: generate 5 realistic train entries
            var trains = faker.Generate(5);

            // Assert: ensure valid data was created
            trains.Count.ShouldBe(5);
            trains.ShouldAllBe(t => !string.IsNullOrEmpty(t.Destination));
            trains.ShouldAllBe(t => !string.IsNullOrEmpty(t.DepartureTime));

            // Print to console (this will show when you run dotnet test)
            Console.WriteLine("🚆 Generated Train Schedule Data:");
            Console.WriteLine("================================");
            foreach (var train in trains)
            {
                Console.WriteLine($"ID: {train.Id} | Destination: {train.Destination} | Departure: {train.DepartureTime}");
            }
            Console.WriteLine("================================");
        }
    }

    // Define same Train class used in your TrainSchedule project
    public class Train
    {
        public int Id { get; set; }
        public string Destination { get; set; }
        public string DepartureTime { get; set; }
    }
}
