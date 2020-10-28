using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using CSharp.Choices;
using LanguageExt.Common;

namespace lab4.Question.Domain.AskQuestionWorkflow
{
    [AsChoice]
    public static partial class AddQuestionResult
    {
        public interface IAddQuestionResult{}
        public class QuestionPosted : IAddQuestionResult
        {
            public Guid QuestionId { get; private set; }
            public string User { get; private set; }
            public int vote { get; private set; }
            public Collection<VoteEnum> votes { get; private set; }
            public QuestionPosted(Guid questionId, string user, int Vote, Collection<VoteEnum> vot)
            {
                QuestionId = questionId;
                User = user;
                vote = Vote;
                votes = vot;

            }
        }
        public class QuestionRejected : IAddQuestionResult
        {
            public string Reason { get; set; }

            public QuestionRejected(string reason)
            {
                Reason = reason;
            }
        }

        public class QuestionValidationFailed : IAddQuestionResult
        {
            public IEnumerable<string> ValidationErrors { get; private set; }

            public QuestionValidationFailed(IEnumerable<string> errors)
            {
                ValidationErrors = errors.AsEnumerable();
            }
        }
    }
}
