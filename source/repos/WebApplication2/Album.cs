//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Album
    {
        public string Album_ISBN { get; set; }
        public string Album_Artist { get; set; }
        public string Album_Name { get; set; }
        public Nullable<int> Category_ID { get; set; }
        public Nullable<int> Album_Year { get; set; }
        public Nullable<System.DateTime> Album_Run_Time { get; set; }
        public Nullable<int> Type_ID { get; set; }
        public Nullable<int> Price_ID { get; set; }
    
        public virtual Album_Category Album_Category { get; set; }
        public virtual Album_Price Album_Price { get; set; }
        public virtual Album_Type Album_Type { get; set; }
        public virtual Stock_Item Stock_Item { get; set; }
    }
}
