using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace lab4.Question.Domain.AskQuestionWorkflow
{
    public class CheckLanguageCmd
    {
        [Required]
        public string Body { get; }
        public CheckLanguageCmd(string body)
        {
            Body = body;
        }
    }
}
