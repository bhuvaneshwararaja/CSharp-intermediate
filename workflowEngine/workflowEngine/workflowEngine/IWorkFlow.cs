internal partial class Program
{
    public interface IWorkFlow
    {
        void Add(IActivities I);
        void Remove(IActivities I);
        IEnumerable<IActivities> getTasks();

    }
}