using Ambit.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ambit.Entities.Contract
{
    public abstract class AbstractItems : BaseModel
    {
        public int itemid { get; set; }
        public bool Active { get; set; }
        public bool isDeleted { get; set; }
        public string Created_On { get; set; }
        public int Created_By { get; set; }
        public string Updated_On { get; set; }
        public int Updated_By { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string code { get; set; }
        public decimal purchaseamount { get; set; }
        public decimal sellamount { get; set; }
        public decimal discount { get; set; }
        public int openingquantity { get; set; }
        public string image { get; set; }
        public int invoiceid { get; set; }
        public string supplier { get; set; }
        public int quotationid { get; set; }
        public int showninapp { get; set; }
        public decimal retailamount { get; set; }
        public decimal mrp { get; set; }
        public bool iscomboproduct { get; set; }
       

    }
}
