//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TravelMap.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserMap
    {
        public System.Guid UserMapId { get; set; }
        public Nullable<System.Guid> UserId { get; set; }
        public Nullable<System.Guid> CountryId { get; set; }
    
        public virtual Country Country { get; set; }
        public virtual UserProfile UserProfile { get; set; }
    }
}
