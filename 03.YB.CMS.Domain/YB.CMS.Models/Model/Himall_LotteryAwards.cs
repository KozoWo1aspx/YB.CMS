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
    
    public partial class Himall_LotteryAwards
    {
        public int Id { get; set; }
        public int LotteryID { get; set; }
        public int AwardNum { get; set; }
        public int HaveWinNum { get; set; }
        public Nullable<decimal> Probability { get; set; }
        public Nullable<int> AwardLevel { get; set; }
        public string AwardName { get; set; }
        public int AwardType { get; set; }
        public long OTherValue { get; set; }
    }
}
