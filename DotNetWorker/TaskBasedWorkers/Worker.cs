public class Worker
{
    public WorkerData? _workerData = null;
    public void Run()
    {
        Console.WriteLine(_workerData?.message?.ToString());
    }

    public Task GetStartedWorker(WorkerData workerData)
    {
        _workerData = workerData;
        Task worker = new(() => {this.Run();});
        worker.Start();
        return worker;
    }
}