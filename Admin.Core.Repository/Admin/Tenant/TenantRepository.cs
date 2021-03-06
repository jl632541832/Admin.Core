using Admin.Core.Model.Admin;
using Admin.Core.Common.Auth;

namespace Admin.Core.Repository.Admin
{	
	public  class TenantRepository : RepositoryBase<TenantEntity>, ITenantRepository
    {
        public TenantRepository(MyUnitOfWorkManager muowm, IUser user) : base(muowm, user)
        {
        }
    }
}
