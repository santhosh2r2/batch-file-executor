using Batch.File.Executor.Models;

namespace Batch.File.Executor.Controllers;

public interface ICrudOps
{
    void Create();
    void Read();
    void Update();
    void Delete();
}

public abstract class AppControllerBase : ICrudOps
{
    public BatchFileExecutorContext BatchFileExecutorContext;


    public abstract void OnCreateEntry();
    public abstract void OnReadEntry();
    public abstract void OnUpdateEntry();

    #region Implement ICrudOps Members



    public void Create()
    {
        CreateContext();
        OnCreateEntry();
        DisposeContext();
    }

    public void Read()
    {
        CreateContext();
        OnReadEntry();
        DisposeContext();
    }

    public void Delete()
    {
        throw new NotImplementedException();
    }

    public void Update()
    {
        CreateContext();
        OnUpdateEntry();
        DisposeContext();
    }

    #endregion


    public void CreateContext()
    {
        BatchFileExecutorContext = new BatchFileExecutorContext();
    }
    public void DisposeContext()
    {
        BatchFileExecutorContext.Dispose();
    }


    /// <summary>
    /// WARNING: This deletes the entire database along with the data.
    /// </summary>
    public static void DeleteDatabase()
    {
        var context = new BatchFileExecutorContext();
        context.Database.EnsureDeleted();
    }
    /// <summary>
    /// Create the tables only if it does not exist.
    /// If tables already exists, then this function does not have influence.
    /// </summary>
    public static void CreateDatabase()
    {
        var context = new BatchFileExecutorContext();
        context.Database.EnsureCreated();
    }

}