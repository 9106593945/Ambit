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
   public abstract class AbstractBannerDao : AbstractBaseDao
    {
        public abstract PagedList<AbstractBanner> BannerSelectAll();

    }
}
