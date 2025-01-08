using Repopattern.IRepo;
using Repopattern.Models;

namespace Repopattern.Repo
{
    public class BatchRepo1 : IBatchRepo
    {
        List<Batch> batches = null;
        public int AddBatch(Batch batch)
        {
            batches.Add(batch);
            return 1;
        }

        public int DeleteBatch(int id)
        {
            Batch batch = GetBatchById(id);
            batches .Remove(batch);
            return 1;
        }

        public Batch GetBatchById(int id)
        {
            return batches.FirstOrDefault(x => x.Id == id);
        }

        public List<Batch> GetBatches()
        {
            return batches.ToList();
        }

        public int UpdateBatch(int id, Batch batch)
        {
            Batch obj = GetBatchById(id);
            obj.Name = batch.Name;
            return 1;
        }
    }
}
