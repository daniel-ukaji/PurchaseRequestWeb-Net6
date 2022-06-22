using PurchaseRequest.Web.Contracts;
using PurchaseRequest.Web.Data;

namespace PurchaseRequest.Web.Repositories
{
    public class PurchaseTypeRepository : GenericRepository<LeaveType>, IPurchaseTypeRepository
    {
        public PurchaseTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
