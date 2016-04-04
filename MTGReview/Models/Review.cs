using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RemixReview.Models
{
    public class Review
    {
        [Required]
        [Key]
        public int ID { get; set; }

        [Required]
        public string UserId { get; set; }

        public virtual User User { get; set; }

        [Required]
        public int MusicID { get; set; }

        public virtual Music Music { get; set; }

        public string ReviewText { get; set; }

    }
}