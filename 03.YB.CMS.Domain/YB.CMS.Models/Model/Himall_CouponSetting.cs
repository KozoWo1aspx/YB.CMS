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
    using static Enum.OrderEnum;
    public partial class Himall_CouponSetting
    {
        public int ID { get; set; }
        public PlatformType PlatForm { get; set; }
        public long CouponID { get; set; }
        public Nullable<int> Display { get; set; }
    
        public virtual Himall_Coupon Himall_Coupon { get; set; }
    }
}
