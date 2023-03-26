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
    public class ItemsDao : AbstractItemsDao
    {
        public override PagedList<AbstractItems> ItemsSelectAll(int categoryid, int customerId, int customerLoginId)
        {
            PagedList<AbstractItems> classes = new PagedList<AbstractItems>();
            var param = new DynamicParameters();
            param.Add("@categoryid", categoryid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            param.Add("@customerId", customerId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            param.Add("@customerLoginId", customerLoginId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            using (SqlConnection con = new SqlConnection(Configurations.ConnectionString))
            {
                var task = con.QueryMultiple(SQLConfig.ItemsSelectAll, param, commandType: CommandType.StoredProcedure);
                classes.Values.AddRange(task.Read<Items>());
                classes.TotalRecords = task.Read<long>().SingleOrDefault();
            }
            return classes;
        }

    }
}
