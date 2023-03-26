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
    public class ItemsServices : AbstractItemsServices
    {
        private AbstractItemsDao abstractItemsDao;

        public ItemsServices(AbstractItemsDao abstractItemsDao)
        {
            this.abstractItemsDao = abstractItemsDao;
        }

        public override PagedList<AbstractItems> ItemsSelectAll(int categoryid, int customerId, int customerLoginId)
        {
            return this.abstractItemsDao.ItemsSelectAll(categoryid, customerId, customerLoginId);
        }

    }
}
