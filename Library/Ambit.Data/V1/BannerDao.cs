using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ambit.Common;
using Ambit.Common.Paging;
using Ambit.Data.Contract;
using Ambit.Entities.Contract;
using Ambit.Entities.V1;

namespace Ambit.Data.V1
{
    public class BannerDao : AbstractBannerDao
    {
        public override PagedList<AbstractBanner> BannerSelectAll()
        {
            PagedList<AbstractBanner> classes = new PagedList<AbstractBanner>();
            var param = new DynamicParameters();
            //param.Add("@EndDate", EndDate, dbType: DbType.String, direction: ParameterDirection.Input);
            using (SqlConnection con = new SqlConnection(Configurations.ConnectionString))
            {
                var task = con.QueryMultiple(SQLConfig.BannerSelectAll, param, commandType: CommandType.StoredProcedure);
                classes.Values.AddRange(task.Read<Banner>());
                classes.TotalRecords = task.Read<long>().SingleOrDefault();
            }
            return classes;
        }

    }
}
