using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp.Data
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        [ForeignKey(nameof(CategoryId))] public Category Category { get; set; }
        public int CategoryId { get; set; }
        public bool IsActive { get; set; }
        
    }
}