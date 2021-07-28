namespace KMIRepository
{
    public interface ISendRepository
    {

        int Count { get; set; }
        void Save();
    }
}