using System.Collections.Concurrent;

//Should be singleton
public class Logger
{
    //ConcurrentQueue<string> logQueue = new System.Collections.Concurrent.ConcurrentQueue<string>();
    //static Logger instance = null;

    public Logger()
    {
        //logQueue = new ConcurrentQueue<string>();
    }

    public bool Initialize()
    {
        //Start the thread to dump messages to persistance.
        Task dumpToPersistanceStorage = new Task(() => {DumpToPersistanceStorage();});
        dumpToPersistanceStorage.Start();
        return true;
    }

    public void Log(string message)
    {
        //logQueue.Append(message);
    }

    private void DumpToPersistanceStorage()
    {
        string message = string.Empty;
        //logQueue.TryDequeue(out message);
        WriteToTargets(message);
    }

    private void WriteToTargets(string message)
    {
        Console.WriteLine(message);
    }
}