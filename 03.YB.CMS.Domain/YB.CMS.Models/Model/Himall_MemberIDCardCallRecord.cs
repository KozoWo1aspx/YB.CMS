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
    
    public partial class Himall_MemberIDCardCallRecord
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string RealName { get; set; }
        public string IdCard { get; set; }
        public System.DateTime CreateTime { get; set; }
        public int CallSource { get; set; }
    }
}