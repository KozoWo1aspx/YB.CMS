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
    
    public partial class Himall_VShop
    {
        public Himall_VShop()
        {
            this.Himall_VShopExtend = new HashSet<Himall_VShopExtend>();
        }
    
        public long Id { get; set; }
        public string Name { get; set; }
        public long ShopId { get; set; }
        public System.DateTime CreateTime { get; set; }
        public int VisitNum { get; set; }
        public int buyNum { get; set; }
        public int State { get; set; }
        private string logo { get; set; }
        private string backgroundImage { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; }
        public string HomePageTitle { get; set; }
        public string DomainName { get; set; }
    
        public virtual Himall_Shops Himall_Shops { get; set; }
        public virtual ICollection<Himall_VShopExtend> Himall_VShopExtend { get; set; }
    }
}
