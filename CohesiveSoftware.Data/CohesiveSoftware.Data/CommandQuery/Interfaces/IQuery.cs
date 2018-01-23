namespace CohesiveSoftware.Data.CommandQuery.Interfaces
{
    public interface IQuery
    {
        void Execute();
    }

    public interface IQuery<T> : IQuery
    {
        T ExecuteAndReturnResults();
        T Results { get; }
    }
}
