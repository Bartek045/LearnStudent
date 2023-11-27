using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnS.Models
{
    public class ApplicationUser : IdentityUser
    {
        [ValidateNever]
        public List<ForumPost> ForumPost { get; set; }
        [ValidateNever]
        public List<ForumThread> ForumThreads { get; set; }

    }
}
