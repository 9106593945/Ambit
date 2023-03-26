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
    public class CategoryServices : AbstractCategoryServices
    {
        private AbstractCategoryDao abstractCategoryDao;

        public CategoryServices(AbstractCategoryDao abstractCategoryDao)
        {
            this.abstractCategoryDao = abstractCategoryDao;
        }

        public override PagedList<AbstractCategory> CategorySelectAll()
        {
            return this.abstractCategoryDao.CategorySelectAll();
        }

    }
}
