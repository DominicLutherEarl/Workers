public class WorkerData
{
    public string? message;

    public WorkerData GetWorkerData(string message)
    {
        this.message = message;
        return this;
    }
}