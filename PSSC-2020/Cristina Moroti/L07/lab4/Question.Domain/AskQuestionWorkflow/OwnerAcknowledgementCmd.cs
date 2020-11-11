using System;
using System.Collections.Generic;
using System.Text;

namespace lab4.Question.Domain.AskQuestionWorkflow
{
    public class OwnerAcknowledgementCmd
    {
        public int questionId { get; }
        public Guid userId { get; }
        public OwnerAcknowledgementCmd(int qId, Guid uId)
        {
            questionId = qId;
            userId = uId;
        }
    }
}
