using LanguageExt;
using System;
using System.Collections.Generic;
using System.Text;
using static lab4.Question.Domain.AskQuestionWorkflow.CreateReplyResult;

namespace lab4.Question.Domain.AskQuestionWorkflow
{
    public class AuthorAcknowledgementCmd
    {
        public int questionId { get; }
        public Guid userId { get; }
        public Option<ReplyCreated> Reply { get; }
        public AuthorAcknowledgementCmd(int rId, Guid uId, Option<ReplyCreated> reply)
        {
            questionId = rId;
            userId = uId;
            Reply = reply;
        }
    }
}
