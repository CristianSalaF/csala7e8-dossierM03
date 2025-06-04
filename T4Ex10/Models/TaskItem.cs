using System.ComponentModel.DataAnnotations;

namespace T4Ex10.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        
        [Required]
        public string Title { get; set; } = string.Empty;
        
        public string Description { get; set; } = string.Empty;
        
        [Required]
        public DateTime DueDate { get; set; }
        
        public bool IsCompleted { get; set; }
    }
}
