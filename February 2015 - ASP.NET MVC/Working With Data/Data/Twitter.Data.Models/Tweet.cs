namespace Twitter.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Tweet
    {
        public int Id { get; set; }

        public string Author { get; set; }

        public string Text { get; set; }

        public DateTime PostedOn { get; set; }

        [Display(Name = "User")]
        public int ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}