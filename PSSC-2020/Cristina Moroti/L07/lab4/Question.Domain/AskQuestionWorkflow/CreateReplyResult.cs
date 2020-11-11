using CSharp.Choices;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab4.Question.Domain.AskQuestionWorkflow
{
    [AsChoice]
    public static partial class CreateReplyResult 
    {
        public interface ICreateReplyResult
        {
        }
        public class ReplyCreated:ICreateReplyResult
        {
            public int Id { get; set; }
            public int QuestionId { get; set; }
            public string Body { get; set; }

            public ReplyCreated(int id, int qId, string body)
            {
                Id = id;
                QuestionId = qId;
                Body = body;
            }
        }
        
        public class InvalidIdRequest:ICreateReplyResult
        {
            public string Message { get; }
            public InvalidIdRequest(string mess)
            {
                Message = mess;
            }
        }
    }
}
