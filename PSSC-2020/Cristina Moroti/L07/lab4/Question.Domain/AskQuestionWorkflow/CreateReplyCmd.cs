using LanguageExt.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace lab4.Question.Domain.AskQuestionWorkflow
{
    public class CreateReplyCmd
    {
        [Required]
        public int QuestionId { get; set; }
        public Guid AuthorQuestionId { get; set; }
        public Guid QuestionOwnerId { get; set; }
        [MinLength(10)]
        [MaxLength(500)]
        [Required]
        public string Body { get; set; }

        public CreateReplyCmd(int qId, Guid aId, Guid qoId, string body)
        {
            QuestionId = qId;
            AuthorQuestionId = aId;
            QuestionOwnerId = qoId;
            Body = body;
        }

        //public static Result<CreateReplyCmd> Create (int questionId, string body)
        //{
        //    if (questionId > 0 && body.Length <= 500 && body.Length >= 10)
        //        return new CreateReplyCmd(questionId, body);
        //    else
        //        return new Result<CreateReplyCmd>(new ArgumentException("Argument invalid"));
        //}
    }
}
