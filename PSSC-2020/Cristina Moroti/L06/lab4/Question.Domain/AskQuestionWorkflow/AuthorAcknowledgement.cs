using CSharp.Choices;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab4.Question.Domain.AskQuestionWorkflow
{
    [AsChoice]
    public static partial class AuthorAcknowledgement
    {
        public interface IAuthorAcknowledgement { }
        public class AuthorAcknowledgementSent:IAuthorAcknowledgement
        {
            public int replyId { get; }
            public int userId { get; }
            public AuthorAcknowledgementSent(int rId, int uId)
            {
                replyId = rId;
                userId = uId;
            }
        }

        public class AuthorAcknowledgementNotSent : IAuthorAcknowledgement
        {
            public string Message { get; }
            public AuthorAcknowledgementNotSent(string mess)
            {
                Message = mess;
            }
        }
    }
}
