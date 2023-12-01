using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnS.Models
{
    public class UserAvatar
    {
        [Key]
        public int Id { get; set; }

        public string UserId { get; set; }

        public int AvatarId { get; set; }
        public bool IsOwned { get; set; }

        public bool IsLocked { get; set; }
        [ValidateNever]
        public virtual ApplicationUser User { get; set; }
        [ValidateNever]
        public virtual AvatarsUpload Avatar { get; set; }
    }
}
