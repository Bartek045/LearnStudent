using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnS.Models
{
    public class Quiz
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Tytuł")]
        [Required]
        public string Title { get; set; }
        public List<Question> Questions { get; set; }
    }
}
