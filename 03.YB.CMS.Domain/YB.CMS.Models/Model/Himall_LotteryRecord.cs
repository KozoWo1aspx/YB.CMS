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
    
    public partial class Himall_LotteryRecord
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string UserName { get; set; }
        public int AwardLeverl { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public int LotteryID { get; set; }
    }
}
