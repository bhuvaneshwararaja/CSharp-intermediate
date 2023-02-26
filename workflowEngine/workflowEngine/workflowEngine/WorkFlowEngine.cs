internal partial class Program
{
    public class WorkFlowEngine
    {

        public void Run(IWorkFlow workFlow)
        {
            foreach (IActivities activity in workFlow.getTasks())
            {
                activity.Execute();
            }
        }
    }
}