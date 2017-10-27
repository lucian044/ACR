using Db.DataModels;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Db.Services
{
    public class PricingExceptionService
    {
        private IUnitOfWork _uw;

        public PricingExceptionService(IUnitOfWork uw)
        {
            _uw = uw;
        }

        public async Task<Employee> CreateRequest(Employee model)
        {
            var repo = _uw.GetRepository<Employee>();

            await repo.InsertAsync(model);

            await _uw.SaveChangesAsync();

            return model;
        }
    }
}