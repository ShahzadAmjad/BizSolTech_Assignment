using System.ComponentModel.DataAnnotations;

namespace BizSolTech_Assignment.Models
{
    public class Developer
    {
        [Key]
        public int developerId { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string jobTitle { get; set; }
        
    }
}
