//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace YB.CMS.Models.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Himall_DistributorProfit
    {
        public long Id { get; set; }
        public Nullable<long> OrderId { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<long> UserId { get; set; }
        public string UserName { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> PromoterLevel { get; set; }
        public long DistributorId { get; set; }
        public long ProductId { get; set; }
        public string SKUId { get; set; }
        public long Count { get; set; }
        public decimal Commission { get; set; }
        public decimal TotalCommission { get; set; }
        public int CommissionRate { get; set; }
        public string Jnumber { get; set; }
        public string Score { get; set; }
    
        public virtual Himall_Distributor Himall_Distributor { get; set; }
    }
}
