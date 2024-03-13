Console.WriteLine("Thread Manager start!");
WorkerData workerData = new WorkerData();
int workerCount = 4;
List<Task> tasks = new List<Task>{};

Task logger = new(() => {(new Logger()).Log(""+DateTime.Now.ToString());});
logger.Start();
tasks.Append(logger);

Task scheduler = new(() => {(new Scheduler()).StartScheduler();});
scheduler.Start();
tasks.Append(scheduler);

for (int i = 0; i<workerCount ; i++)
{
    WorkerData data = workerData.GetWorkerData("b=" + i.ToString());
    tasks.Append((new Worker()).GetStartedWorker(data));
}

Console.WriteLine("Done");
tasks.ForEach(t => t.Wait());