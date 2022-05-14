using SampleKO.Business.Abstract;
using SampleKO.DataAccess.DbContexts;
using SampleKO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleKO.Business.Concrete
{
    public class UnitOfWorks : IUnitOfWorks
    {
        private readonly SampleDbContext _context;
        public UnitOfWorks(SampleDbContext context)
        {
            if (context != null)
                _context = context;
            else
            {
                //Add Logger
            }
        }
        public IGenericRepository<T> GetGenericRepository<T>() where T : class, new()
        {
            return new GenericRepository<T>(_context);
        }

        public ServiceResult SaveChanges()
        {
            var transaction = _context.Database.CurrentTransaction;
            if (transaction == null)
            {
                transaction = _context.Database.BeginTransaction();
            }
            try
            {
                var affected = _context.SaveChangesAsync().GetAwaiter().GetResult();
                transaction.Commit();
                return Result.Success("İşlem başarılı", null);
            }
            catch (Exception)
            {
                transaction.Rollback();
                //logger
                return Result.Fail("İşlem sırasında hata oluştu", null);
            }
        }
    }
}
