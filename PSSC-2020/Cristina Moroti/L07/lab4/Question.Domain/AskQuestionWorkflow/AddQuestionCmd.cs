using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace lab4.Question.Domain
{
    public struct AddQuestionCmd
    {
        [Required]
        public string User { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Title { get; set; }
        [Required]
        [MaxLength(1000)]
        public string Question { get; set; }
        [Required]
        public string Tag { get; set; }

        public AddQuestionCmd(string user, string title, string question, string tag)
        {
            User = user;
            Title = title;
            Question = question;
            Tag = tag;
        }
    }
}
