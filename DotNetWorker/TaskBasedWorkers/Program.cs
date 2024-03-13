Console.WriteLine("Task Manager start!");

int workerCount = 4;
List<Task> tasks = new List<Task>{};

// Task logger = new(() => {(new Logger()).Log(""+DateTime.Now.ToString());});
// logger.Start();
// tasks.Append(logger);

// Task scheduler = new(() => {(new Scheduler()).StartScheduler();});
// scheduler.Start();
// tasks.Append(scheduler);

for (int i = 0; i<workerCount ; i++)
{
    WorkerData data1 = (new WorkerData()).GetWorkerData("a=" + i.ToString());

    Worker w = new Worker();
    w._workerData = data1;
    Task worker = new(() => {w.Run();});
    worker.Start();
    tasks.Append(worker);

    WorkerData data = (new WorkerData()).GetWorkerData("b=" + i.ToString());
    tasks.Append((new Worker()).GetStartedWorker(data));
}

await Task.WhenAll(tasks);

Console.WriteLine("Task Manager stop!");