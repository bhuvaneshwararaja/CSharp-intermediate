internal partial class Program
{
    private static void Main(string[] args)
    {
        // Workflow Engine

        WorkFlow workflow = new WorkFlow();

        workflow.Add(new VideoUploader());
        workflow.Add(new CallWebService());
        workflow.Add(new SendingEmail());

        var workFlowEngine = new WorkFlowEngine();

        workFlowEngine.Run(workflow);
    }
}