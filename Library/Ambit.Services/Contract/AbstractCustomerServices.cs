using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Ambit.Common;
using Ambit.Common.Paging;
using Ambit.Entities.Contract;

namespace Ambit.Services.Contract
{
    public abstract class AbstractCustomerServices : AbstractBaseService
    {
        public abstract SuccessResult<AbstractCustomer> Login(AbstractCustomer abstractusers);
        //public abstract PagedList<AbstractCustomer> UserAll(PageParam pageParam, string search, int UserType = 0, string StartDate = "", string EndDate = "");
        //public abstract SuccessResult<AbstractCustomer> UserById(int id, string DeviceToken);
        public abstract SuccessResult<AbstractCustomer> CustomerUpsert(AbstractCustomer abstractusers);
        //public abstract bool UserDelete(int id);
       
    }
}
