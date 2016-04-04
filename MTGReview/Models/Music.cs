using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RemixReview.Models
{
    public class Music
    {
        [Required]
        [Key]
        public int ID { get; set; }
        [Required]
        public string FileName { get; set; }

        [Required]
        public string Source { get; set; }

        [Required]
        public TimeSpan Duration { get; set; }

        public virtual ICollection<Review> reviews { get; set; }

        public string Artist { get; set; }
    }
}