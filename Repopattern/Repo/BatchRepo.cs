using Repopattern.Context;
using Repopattern.IRepo;
using Repopattern.Models;

namespace Repopattern.Repo
{
    public class BatchRepo : IBatchRepo
    {
        BatchDbContext _context;
        public BatchRepo(BatchDbContext context)
        {
            _context = context;
        }
        public int AddBatch(Batch batch)
        {
            _context.Batches.Add(batch);
            _context.SaveChanges();
            return 1;
        }

        public int DeleteBatch(int id)
        {
            Batch batch = GetBatchById(id);
            _context.Batches.Remove(batch);
            _context.SaveChanges();
            return 1;
        }

        public Batch GetBatchById(int id)
        {
            return _context.Batches.FirstOrDefault(x => x.Id == id);  
        }

        public List<Batch> GetBatches()
        {
            return _context.Batches.ToList();
        }

        public int UpdateBatch(int id, Batch batch)
        {
            Batch obj = GetBatchById(id);
            obj.Name= batch.Name;
            _context.SaveChanges();
            return 1;
        }
    }
}
