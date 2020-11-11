using LanguageExt.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab4.Question.Domain.AskQuestionWorkflow
{
    public class PublishedQuestion
    {
        public Result<QuestionAsked> PublishQuestion(QuestionAsked question)
        {
            return new QuestionAsked(question.question, question.tag);
        }
    }
}
