namespace CohesiveSoftware.Data.Interfaces
{
    public interface IToModel<out T>
    {
        T ToModel();
    }
}
