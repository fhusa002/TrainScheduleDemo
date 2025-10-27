namespace TrainSchedule
{
    public class TrainServiceWithRepo
    {
        private readonly ITrainRepository _repo;

        public TrainServiceWithRepo(ITrainRepository repo)
        {
            _repo = repo;
        }

        public Train GetTrainById(int id)
        {
            return _repo.GetTrain(id);
        }

        public void AddTrain(Train train)
        {
            _repo.SaveTrain(train);
        }

        public void RemoveTrain(int id)
        {
            _repo.DeleteTrain(id);
        }
    }
}
