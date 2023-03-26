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
   public abstract class AbstractItemsDao : AbstractBaseDao
    {
        public abstract PagedList<AbstractItems> ItemsSelectAll(int categoryid, int customerId, int customerLoginId);

    }
}
