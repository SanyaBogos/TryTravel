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
    
    public partial class PostType
    {
        public PostType()
        {
            this.Posts = new HashSet<Post>();
        }
    
        public System.Guid PostTypeId { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Post> Posts { get; set; }
    }
}