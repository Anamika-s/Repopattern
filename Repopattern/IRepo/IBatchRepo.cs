using Repopattern.IRepo;
using Repopattern.Models;

namespace Repopattern.IRepo
{
    public interface IBatchRepo
    {
        List<Batch> GetBatches();
        Batch GetBatchById(int id);
        int AddBatch(Batch batch);
        int UpdateBatch(int id, Batch batch);
        int DeleteBatch(int id);
    }
}
 