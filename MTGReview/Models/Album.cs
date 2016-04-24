using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RemixReview.Models
{
    public class Album
    {
        [Required]
        [Key]
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [RegularExpression(@"(http:\/\/[a-zA-z]*\.ocremix\.org\/?)|(http:\/\/ocremix\.org\/info\/[a-zA-z_:\d]*)")]
        [Url]
        public string HomepageLink { get; set; }

        [Required]
        [RegularExpression(@"http:\/\/ocremix.org\/thumbs\/[a-zA-z_:\d\/\-\.]*")]
        [Url]
        public string ImageLink { get; set; }
    }
}