using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static lab4.Question.Domain.AskQuestionWorkflow.AddQuestionResult;

namespace lab4.Question.Domain.AskQuestionWorkflow
{
    class Vote
    {
        public Task YouCanVote(QuestionAsked question)
        {
            return Task.CompletedTask;
        }
    }
}
