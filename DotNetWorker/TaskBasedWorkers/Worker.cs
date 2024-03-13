public class Worker
{
    WorkerData _workerData = null;
    public void Run(WorkerData workerData)
    {
        Console.WriteLine(workerData.message.ToString());
    }

    public Task GetStartedWorker(WorkerData workerData)
    {
        _workerData = workerData;
        Task worker = new(() => {this.Run(workerData);});
        worker.Start();
        return worker;
    }
}