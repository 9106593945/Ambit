using Ambit.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ambit.Entities.Contract
{
    public abstract class AbstractCategory : BaseModel
    {
        public int categoryid { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        public bool Active { get; set; }
        public bool isDeleted { get; set; }
        public string Created_On { get; set; }
        public int Created_By { get; set; }
        public string Updated_On { get; set; }
        public int Updated_By { get; set; }
        public string categorydate { get; set; }

    }
}
