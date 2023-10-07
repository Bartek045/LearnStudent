using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnS.Models
{
    public class AvatarsUpload
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Prześlij zdjęcie")]
        public int Display {  get; set; }
        public string imgPath { get; set; }
    }
}
