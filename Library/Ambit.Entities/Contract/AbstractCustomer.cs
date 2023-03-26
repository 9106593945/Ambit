using Ambit.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ambit.Entities.Contract
{
    public abstract class AbstractCustomer : BaseModel
    {
        public int customerid { get; set; }
        public bool Active { get; set; }
        public bool isDeleted { get; set; }
        public string Created_On { get; set; }
        public int Created_By { get; set; }
        public string Updated_On { get; set; }
        public int Updated_By { get; set; }
        public string Name { get; set; }
        public string customer_number { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string postcode { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string description { get; set; }
        public string transport { get; set; }
        public string username { get; set; }
        public string deviceid { get; set; }
    }
}
