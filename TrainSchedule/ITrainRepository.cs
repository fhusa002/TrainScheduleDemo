namespace TrainSchedule
{
    public interface ITrainRepository
    {
        Train GetTrain(int id);
        void SaveTrain(Train train);
        void DeleteTrain(int id);
    }
}
