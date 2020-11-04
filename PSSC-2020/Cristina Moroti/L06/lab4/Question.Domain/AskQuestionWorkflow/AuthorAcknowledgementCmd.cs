using System;
using System.Collections.Generic;
using System.Text;

namespace lab4.Question.Domain.AskQuestionWorkflow
{
    public class AuthorAcknowledgementCmd
    {
        public int replyId { get; }
        public int userId { get; }
        public AuthorAcknowledgementCmd(int rId, int uId)
        {
            replyId = rId;
            userId = uId;
        }
    }
}
