using System;
using System.Collections.Generic;
using System.Text;

namespace lab4.Question.Domain.AskQuestionWorkflow
{
    public class OwnerAcknowledgementCmd
    {
        public int questionId { get; }
        public int userId { get; }
        public OwnerAcknowledgementCmd(int qId, int uId)
        {
            questionId = qId;
            userId = uId;
        }
    }
}
