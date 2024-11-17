using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Batch.File.Executor.Models;

namespace Batch.File.Executor.Controllers;

public class BatchFileAppController : AppControllerBase
{
    private readonly BatchFile _file;
    private readonly int _id;

    public BatchFileAppController(BatchFile file)
    {
        _file = file;
    }
    public override void OnCreateEntry()
    {
        BatchFileExecutorContext.BatchFiles.Add(_file);
        BatchFileExecutorContext.SaveChanges();
    }

    public override void OnReadEntry()
    {
        //var entry = BatchFileExecutorContext.BatchFiles.SingleOrDefault(b => b.Id == _id);

    }

    public override void OnUpdateEntry()
    {
        BatchFileExecutorContext.Update(_file);
        BatchFileExecutorContext.SaveChanges();
    }
    
}

public class BatchFileEventArgs(BatchFile batchFile) : EventArgs
{
    public BatchFile File { get; set; } = batchFile;
}
