using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ambit.Common;
using Ambit.Common.Paging;
using Ambit.Entities.Contract;

namespace Ambit.Data.Contract
{
   public abstract class AbstractCustomerDao : AbstractBaseDao
    {
        public abstract SuccessResult<AbstractCustomer> Login(AbstractCustomer abstractCustomer);
        //public abstract PagedList<AbstractCustomer> UserAll(PageParam pageParam, string search, int UserType = 0, string StartDate = "", string EndDate = "");
        //public abstract SuccessResult<AbstractCustomer> UserById(int id, string DeviceToken);
        public abstract SuccessResult<AbstractCustomer> CustomerUpsert(AbstractCustomer abstractCustomer);
        //public abstract bool UserDelete(int id);
        
    }
}
