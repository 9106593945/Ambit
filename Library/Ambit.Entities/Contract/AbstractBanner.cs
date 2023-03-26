using Ambit.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ambit.Entities.Contract
{
    public abstract class AbstractBanner : BaseModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string imagePath { get; set; }
        public bool isvideo { get; set; }
        public string actionlink { get; set; }
        public string action { get; set; }
        public bool isDeleted { get; set; }
        public string Created_On { get; set; }
        public int Created_By { get; set; }
        public string Updated_On { get; set; }
        public int Updated_By { get; set; }

    }
}
