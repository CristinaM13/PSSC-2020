using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace lab4.Question.Domain.AskQuestionWorkflow
{
    class AddQuestionResult
    {
        public interface IAddQuestionResult{}
        public class QuestionPosted : IAddQuestionResult
        {
            public Guid QuestionId { get; private set; }
            public string User { get; private set; }

            public QuestionPosted(Guid questionId, string user)
            {
                QuestionId = questionId;
                User = user;
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
