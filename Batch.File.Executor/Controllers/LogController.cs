using Batch.File.Executor.Models;

namespace Batch.File.Executor.Controllers;

public class LogController: AppControllerBase
{
    private readonly Log _log;

    public LogController(Log log)
    {
        _log = log;
    }
    public override void OnCreateEntry()
    {
        BatchFileExecutorContext.Logs.Add(_log);
        BatchFileExecutorContext.SaveChanges();
    }

    public override void OnReadEntry()
    {
        throw new NotImplementedException();
    }

    public override void OnUpdateEntry()
    {
        BatchFileExecutorContext.Update(_log);
        BatchFileExecutorContext.SaveChanges();
    }

}