using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Entities
{
    public class Comment
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }
        [Required]
        public string Author { get; set; }
        
        public string Content { get; set; }
        
        public EState State { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid PostId { get; set; }
        
        
    }
}