﻿using System;
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
    public abstract class AbstractCategoryServices : AbstractBaseService
    {
        public abstract PagedList<AbstractCategory> CategorySelectAll();

    }
}
