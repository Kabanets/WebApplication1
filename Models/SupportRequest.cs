using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class SupportRequest
    {
        [Key]
        public int SupportRequestId { get; set; }
        [StringLength(50, ErrorMessage ="Не более 50 символов")]
        public string Subject { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public DateTime Date { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}