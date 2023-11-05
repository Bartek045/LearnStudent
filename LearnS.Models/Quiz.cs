using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [DisplayName("Pytanie")]
        public string Question { get; set; }
        [DisplayName("Odpowiedź 1")]
        public string AnswerI { get; set; }
        [DisplayName("Odpowiedź 2")]
        public string AnswerII { get; set; }
        [DisplayName("Odpowiedź 3")]
        public string AnswerIII { get; set; }
        [DisplayName("Odpowiedź 4")]
        public string AnswerIV { get; set; }

        [DisplayName("Prawidłowa odpowiedź")]
        public int CorrectAnswer { get; set; }
        [DisplayName("Dział")]
        public int SectionId { get; set; }
        [ForeignKey("SectionId")]
        [ValidateNever]
        public Section Section { get; set; }
    }
}
