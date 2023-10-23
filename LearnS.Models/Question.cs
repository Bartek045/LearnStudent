using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnS.Models
{
    public class Question
    {
        [Key]

        public int Id { get; set; }
        public string Text { get; set; }
        public List<Answer> Answers { get; set; }
        public int QuizId { get; set; }
        public Quiz Quiz { get; set; }
    }
}
