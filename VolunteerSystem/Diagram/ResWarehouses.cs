//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VolunteerSystem.Diagram
{
    using System;
    using System.Collections.Generic;
    
    public partial class ResWarehouses
    {
        public int Id { get; set; }
        public int ResourceInfoId { get; set; }
        public float Count { get; set; }
        public int WarehouseId { get; set; }
    
        public virtual ResourceInfoes ResourceInfoes { get; set; }
        public virtual Warehouses Warehouses { get; set; }
    }
}
