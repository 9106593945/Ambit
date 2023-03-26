using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Ambit.Common;
using Ambit.Common.Paging;
using Ambit.Data.Contract;
using Ambit.Entities.Contract;
using Ambit.Entities.V1;
using Ambit.Services.Contract;

namespace Ambit.Services.V1
{
    public class CustomerLoginServices : AbstractCustomerLoginServices
    {
        private AbstractCustomerLoginDao abstractCustomerDao;

        public CustomerLoginServices(AbstractCustomerLoginDao abstractCustomerDao)
        {
            this.abstractCustomerDao = abstractCustomerDao;
        }

        public override SuccessResult<AbstractCustomerLogin> Login(AbstractCustomerLogin abstractCustomer)
        {
            return this.abstractCustomerDao.Login(abstractCustomer);
        }
        //public override PagedList<AbstractCustomer> UserAll(PageParam pageParam, string search, int UserType = 0, string StartDate = "", string EndDate = "")
        //{
        //    return this.abstractUsersDao.UserAll(pageParam, search, UserType, StartDate, EndDate);
        //}
        //public override SuccessResult<AbstractCustomer> UserById(int id,string DeviceToken)
        //{
        //    var result = abstractUsersDao.UserById(id, DeviceToken);
        //    if (result.Item != null)
        //    {
        //        if (result.Item.ProfilePhoto != null)
        //        {
        //            result.Item.ProfilePhoto = Configurations.S3BaseUrl + result.Item.ProfilePhoto;
        //        }
        //    }
        //    return result;
        //}
        public override SuccessResult<AbstractCustomerLogin> CustomerLoginUpsert(AbstractCustomerLogin abstractusers)
        {
            return this.abstractCustomerDao.CustomerLoginUpsert(abstractusers);
        }
        
        //public override bool UserDelete(int id)
        //{
        //    return this.abstractUsersDao.UserDelete(id);
        //}

    }
}
