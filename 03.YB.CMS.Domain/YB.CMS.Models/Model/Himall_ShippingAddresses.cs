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
    
    public partial class Himall_ShippingAddresses
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public int RegionId { get; set; }
        public string ShipTo { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public bool IsDefault { get; set; }
        public bool IsQuick { get; set; }
        public string IDCard { get; set; }
        private string IdCardFace { get; set; }
        private string IdCardButtock { get; set; }
        public string DomainName { get; set; }
        public string ImagePath { get; set; }
    
        public virtual Himall_Members Himall_Members { get; set; }
    }
}