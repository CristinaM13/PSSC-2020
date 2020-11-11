using CSharp.Choices;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab4.Question.Domain.AskQuestionWorkflow
{
    [AsChoice]
    public static partial class OwnerAcknowledgement
    {
        public interface IOwnerAcknowledgement { }
        public class OwnerAcknowledgementSent:IOwnerAcknowledgement
        {
            public int questionId { get; }
            public int userId { get; }
            public OwnerAcknowledgementSent(int qId, int uId)
            {
                questionId = qId;
                userId = uId;
            }
        }

        public class OwnerAcknowledgementNotSent : IOwnerAcknowledgement
        {
            public string Message { get; }
            public OwnerAcknowledgementNotSent(string mess)
            {
                Message = mess;
            }
        }
    }
}
