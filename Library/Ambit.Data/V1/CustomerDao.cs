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
    public class CustomerDao : AbstractCustomerDao
    {
        public override SuccessResult<AbstractCustomer> Login(AbstractCustomer abstractCustomer)
        {
            SuccessResult<AbstractCustomer> users = null;
            var param = new DynamicParameters();
            param.Add("@username", abstractCustomer.username, dbType: DbType.String, direction: ParameterDirection.Input);
            param.Add("@password", abstractCustomer.password, dbType: DbType.String, direction: ParameterDirection.Input);
            param.Add("@deviceid", abstractCustomer.deviceid, dbType: DbType.String, direction: ParameterDirection.Input);
            using (SqlConnection con = new SqlConnection(Configurations.ConnectionString))
            {
                var task = con.QueryMultiple(SQLConfig.Login, param, commandType: CommandType.StoredProcedure);
                users = task.Read<SuccessResult<AbstractCustomer>>().SingleOrDefault();
                users.Item = task.Read<Customer>().SingleOrDefault();
            }
            return users;
        }

        //public override PagedList<AbstractCustomer> UserAll(PageParam pageParam, string search,int UserType=0,string StartDate="",string EndDate="")
        //{
        //    PagedList<AbstractCustomer> classes = new PagedList<AbstractCustomer>();
        //    var param = new DynamicParameters();

        //    //param.Add("@Search", search, dbType: DbType.String, direction: ParameterDirection.Input);
        //    param.Add("@Offset", pageParam.Offset, dbType: DbType.Int32, direction: ParameterDirection.Input);
        //    param.Add("@Limit", pageParam.Limit, dbType: DbType.Int32, direction: ParameterDirection.Input);
        //    param.Add("@Search", search, dbType: DbType.String, direction: ParameterDirection.Input);
        //    param.Add("@UserType", UserType, dbType: DbType.Int32, direction: ParameterDirection.Input);
        //    param.Add("@StartDate", StartDate, dbType: DbType.String, direction: ParameterDirection.Input);
        //    param.Add("@EndDate", EndDate, dbType: DbType.String, direction: ParameterDirection.Input);

        //    using (SqlConnection con = new SqlConnection(Configurations.ConnectionString))
        //    {
        //        var task = con.QueryMultiple(SQLConfig.UserSelectAll, param, commandType: CommandType.StoredProcedure);
        //        classes.Values.AddRange(task.Read<Customer>());
        //        classes.TotalRecords = task.Read<long>().SingleOrDefault();
        //    }
        //    return classes;
        //}
        
        //public override SuccessResult<AbstractCustomer> UserById(int id, string DeviceToken)
        //{
        //    SuccessResult<AbstractCustomer> users = null;
        //    var param = new DynamicParameters();

        //    param.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
        //    //param.Add("@DeviceToken", DeviceToken, dbType: DbType.String, direction: ParameterDirection.Input);

        //    using (SqlConnection con = new SqlConnection(Configurations.ConnectionString))
        //    {
        //        var task = con.QueryMultiple(SQLConfig.UserById, param, commandType: CommandType.StoredProcedure);
        //        users = task.Read<SuccessResult<AbstractCustomer>>().SingleOrDefault();
        //        users.Item = task.Read<Customer>().SingleOrDefault();
        //    }
        //    return users;
        //}

        public override SuccessResult<AbstractCustomer> CustomerUpsert(AbstractCustomer abstractCustomer)
        {
            SuccessResult<AbstractCustomer> users = null;
            var param = new DynamicParameters();
            param.Add("@customerid", abstractCustomer.customerid, DbType.Int32, direction: ParameterDirection.Input);
            param.Add("@Active", abstractCustomer.Active, DbType.Boolean, direction: ParameterDirection.Input);
            param.Add("@Name", abstractCustomer.Name, DbType.String, direction: ParameterDirection.Input);
            param.Add("@customer_number", abstractCustomer.customer_number, DbType.String, direction: ParameterDirection.Input);
            param.Add("@address", abstractCustomer.address, DbType.String, direction: ParameterDirection.Input);
            param.Add("@city", abstractCustomer.city, DbType.String, direction: ParameterDirection.Input);
            param.Add("@postcode", abstractCustomer.postcode, DbType.String, direction: ParameterDirection.Input);
            param.Add("@state", abstractCustomer.state, DbType.String, direction: ParameterDirection.Input);
            param.Add("@country", abstractCustomer.country, DbType.String, direction: ParameterDirection.Input);
            param.Add("@mobile", abstractCustomer.mobile, DbType.String, direction: ParameterDirection.Input);
            param.Add("@email", abstractCustomer.email, DbType.String, direction: ParameterDirection.Input);
            param.Add("@password", abstractCustomer.password, DbType.String, direction: ParameterDirection.Input);
            param.Add("@description", abstractCustomer.description, DbType.String, direction: ParameterDirection.Input);
            param.Add("@transport", abstractCustomer.transport, DbType.String, direction: ParameterDirection.Input);
            using (SqlConnection con = new SqlConnection(Configurations.ConnectionString))
            {
                var task = con.QueryMultiple(SQLConfig.CustomerUpsert, param, commandType: CommandType.StoredProcedure);
                users = task.Read<SuccessResult<AbstractCustomer>>().SingleOrDefault();
                users.Item = task.Read<Customer>().SingleOrDefault();
            }
            return users;
        }

        //public override bool UserDelete(int id)
        //{
        //    bool isDelete = false;
        //    var param = new DynamicParameters();

        //    param.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);

        //    using (SqlConnection con = new SqlConnection(Configurations.ConnectionString))
        //    {
        //        var task = con.Query<bool>(SQLConfig.UserDelete, param, commandType: CommandType.StoredProcedure);
        //        isDelete = task.SingleOrDefault<bool>();
        //    }

        //    return isDelete;
        //}

    }
}
