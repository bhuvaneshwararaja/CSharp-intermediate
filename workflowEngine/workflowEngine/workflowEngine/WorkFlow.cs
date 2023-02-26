internal partial class Program
{
    public class WorkFlow:IWorkFlow
    {
        private List<IActivities> T;

        public WorkFlow()
        {
            T = new List<IActivities>();
        }

        public void Add(IActivities activityObject)
        {
            T.Add(activityObject);
        }

        public void Remove (IActivities activityObject)
        {
            T.Remove(activityObject);
        }

        public IEnumerable<IActivities> getTasks()
        {
            return T;
        }

    }
}