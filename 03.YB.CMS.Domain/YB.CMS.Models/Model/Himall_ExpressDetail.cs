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
    
    public partial class Himall_ExpressDetail
    {
        public long Id { get; set; }
        public long ExpressId { get; set; }
        public System.DateTime DetailTime { get; set; }
        public string Status { get; set; }
        public string AreaCode { get; set; }
        public string AreaName { get; set; }
        public string Context { get; set; }
        public System.DateTime CreateTime { get; set; }
    
        public virtual Himall_Express Himall_Express { get; set; }
    }
}