using System.Collections.Generic;
using System.Linq;

namespace TrainSchedule
{
    public class TrainService
    {
        private readonly List<Train> _trains = new();

        public void AddTrain(Train train) => _trains.Add(train);

        public Train GetTrainById(int id) =>
            _trains.FirstOrDefault(t => t.Id == id);

        public bool RemoveTrain(int id)
        {
            var train = GetTrainById(id);
            if (train == null) return false;
            _trains.Remove(train);
            return true;
        }

        public int Count => _trains.Count;
    }
}
