using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace lab4.Question.Domain
{
    class AddQuestionCmd
    {
        [Required]
        public string User { get; set; }
        public string Title { get; set; }
        public string Question { get; set; }
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
