using System;
using System.Collections.Generic;

namespace BlazorApp.Data
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ParentId { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}