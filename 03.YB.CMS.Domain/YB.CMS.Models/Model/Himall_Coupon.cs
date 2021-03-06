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
    
    public partial class Himall_Coupon
    {
        public Himall_Coupon()
        {
            this.Himall_CouponChildren = new HashSet<Himall_CouponChildren>();
            this.Himall_CouponRecord = new HashSet<Himall_CouponRecord>();
            this.Himall_CouponSetting = new HashSet<Himall_CouponSetting>();
        }
    
        public long Id { get; set; }
        public long ShopId { get; set; }
        public string ShopName { get; set; }
        public decimal Price { get; set; }
        public int PerMax { get; set; }
        public Nullable<decimal> OrderAmount { get; set; }
        public int Num { get; set; }
        public System.DateTime StartTime { get; set; }
        public System.DateTime EndTime { get; set; }
        public string CouponName { get; set; }
        public System.DateTime CreateTime { get; set; }
        public string IdSN { get; set; }
        public int IsBindProcduct { get; set; }
        public int IsHasChildCoupon { get; set; }
        public int Type { get; set; }
        public int IsFirst { get; set; }
        public int NeedValue { get; set; }
        public System.DateTime GetStartTime { get; set; }
        public System.DateTime GetEndTime { get; set; }
    
        public virtual ICollection<Himall_CouponChildren> Himall_CouponChildren { get; set; }
        public virtual ICollection<Himall_CouponRecord> Himall_CouponRecord { get; set; }
        public virtual ICollection<Himall_CouponSetting> Himall_CouponSetting { get; set; }
        public virtual Himall_Shops Himall_Shops { get; set; }
    }
}
