//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZeroHunger.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class food_distribution_details
    {
        public int id { get; set; }
        public Nullable<int> food_distribution_id { get; set; }
        public Nullable<int> employee_id { get; set; }
    
        public virtual employee employee { get; set; }
        public virtual food_distribution food_distribution { get; set; }
    }
}
