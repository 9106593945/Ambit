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
    public class BannerServices : AbstractBannerServices
    {
        private AbstractBannerDao abstractBannerDao;

        public BannerServices(AbstractBannerDao abstractBannerDao)
        {
            this.abstractBannerDao = abstractBannerDao;
        }

        public override PagedList<AbstractBanner> BannerSelectAll()
        {
            return this.abstractBannerDao.BannerSelectAll();
        }

    }
}
