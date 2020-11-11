using CSharp.Choices;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab4.Question.Domain.AskQuestionWorkflow
{
    [AsChoice]
    public static partial class CheckLanguageResult
    {
        public interface ICheckLanguageResult { }
        public class ValidReply : ICheckLanguageResult
        {
            public string Body { get; }
            public ValidReply(string body)
            {
                Body = body;
            }
        }

        public class InvalidReply : ICheckLanguageResult
        {
            public string Message { get; }
            public InvalidReply(string mess)
            {
                Message = mess;
            }
        }
        public class ManualReview:ICheckLanguageResult
        {
            public string Body { get; }
            public ManualReview(string body)
            {
                Body = body;
            }
        }
    }
}
