using Ambit.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ambit.Entities.Contract
{
    public abstract class AbstractCustomerLogin : BaseModel
    {
        public int customerloginid { get; set; }
        public int customerid { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string deviceid { get; set; }
        public bool isapproved { get; set; }
        public bool Active { get; set; }
        public bool isDeleted { get; set; }
        public string Created_On { get; set; }
        public int Created_By { get; set; }
        public string Updated_On { get; set; }
        public int Updated_By { get; set; }

    }
}
