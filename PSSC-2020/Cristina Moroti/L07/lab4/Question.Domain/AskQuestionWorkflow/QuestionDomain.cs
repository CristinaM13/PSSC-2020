using Docker.DotNet.Models;
using lab4.Primitives.IO;
using LanguageExt;
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
        public static Port<ICreateReplyResult> CreateReply(int questionId, Guid authorId, Guid questionOvnerId, string answerBody) =>
            NewPort<CreateReplyCmd, ICreateReplyResult>(new CreateReplyCmd(questionId, authorId, questionOvnerId, answerBody));
        public static Port<ICheckLanguageResult> CheckLanguage(string body) =>
            NewPort<CheckLanguageCmd, ICheckLanguageResult>(new CheckLanguageCmd(body));
        public static Port<IOwnerAcknowledgement> QuestionOwnerAcknowledgement(int questionId, Guid userId) =>
            NewPort<OwnerAcknowledgementCmd, IOwnerAcknowledgement>(new OwnerAcknowledgementCmd(questionId, userId));
        public static Port<IAuthorAcknowledgement> ReplyAuthorAcknowledgement(int questionId, Guid userId, Option<ReplyCreated> r) =>
            NewPort<AuthorAcknowledgementCmd, IAuthorAcknowledgement>(new AuthorAcknowledgementCmd(questionId, userId, r));

    }
}
