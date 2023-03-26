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
    public class CategoryDao : AbstractCategoryDao
    {
        public override PagedList<AbstractCategory> CategorySelectAll()
        {
            PagedList<AbstractCategory> classes = new PagedList<AbstractCategory>();
            var param = new DynamicParameters();
            //param.Add("@EndDate", EndDate, dbType: DbType.String, direction: ParameterDirection.Input);
            using (SqlConnection con = new SqlConnection(Configurations.ConnectionString))
            {
                var task = con.QueryMultiple(SQLConfig.CategorySelectAll, param, commandType: CommandType.StoredProcedure);
                classes.Values.AddRange(task.Read<Category>());
                classes.TotalRecords = task.Read<long>().SingleOrDefault();
            }
            return classes;
        }

    }
}
