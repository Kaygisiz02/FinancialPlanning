namespace FinancialPlanning.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly FinancialPlanningDbContext _dbContext;
        DbSet<TEntity> _dbset;
        public Repository(FinancialPlanningDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbset = dbContext.Set<TEntity>();
        }
        public bool Add(TEntity entity)
        {
            _dbset.Add(entity);
            return Save();
        }

        public bool AddRange(List<TEntity> entities)
        {
            _dbset.AddRange(entities);
            return Save();
        }

        public TEntity? Get(int id)
        {
            return _dbset.Find(id);
        }

        public TEntity? Get(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbset.Where(predicate).FirstOrDefault();
        }

        public List<TEntity> GetAll()
        {
            return _dbset.ToList();
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbset.Where(predicate).ToList();
        }

        public bool Remove(int id)
        {
            TEntity? entity = Get(id);
            if (entity != null)
            {
                _dbset.Remove(entity);
                return Save();
            }
            return false;
        }

        public bool RemoveRange(IEnumerable<TEntity> entities)
        {
            _dbset.RemoveRange(entities);
            return Save();
        }

        public bool Save()
        {
            try
            {
                return _dbContext.SaveChanges() > 0;
            }
            catch (Exception)
            {
                // Handle exception accordingly
                return false;
            }
        }

        public bool Update(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            return Save();
        }
    }
}
