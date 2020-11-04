using Docker.DotNet.Models;
using lab4.Primitives.IO;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using static lab4.Question.Domain.AskQuestionWorkflow.AuthorAcknowledgement;
using static lab4.Question.Domain.AskQuestionWorkflow.CheckLanguageResult;
using static lab4.Question.Domain.AskQuestionWorkflow.CreateReplyResult;
using static lab4.Question.Domain.AskQuestionWorkflow.OwnerAcknowledgement;
using static PortExt;

namespace lab4.Question.Domain.AskQuestionWorkflow
{
    public static class QuestionDomain
    {
        public static Port<ICreateReplyResult> CreateReply(int questionId, string answerBody) =>
            NewPort<CreateReplyCmd, ICreateReplyResult>(new CreateReplyCmd(questionId, answerBody));
        public static Port<ICheckLanguageResult> CheckLanguage(string body) =>
            NewPort<CheckLanguageCmd, ICheckLanguageResult>(new CheckLanguageCmd(body));
        public static Port<IOwnerAcknowledgement> QuestionOwnerAcknowledgement(int questionId, int userId) =>
            NewPort<OwnerAcknowledgementCmd, IOwnerAcknowledgement>(new OwnerAcknowledgementCmd(questionId, userId));
        public static Port<IAuthorAcknowledgement> ReplyAuthorAcknowledgement(int replyId, int userId) =>
            NewPort<AuthorAcknowledgementCmd, IAuthorAcknowledgement>(new AuthorAcknowledgementCmd(replyId, userId));

    }
}
