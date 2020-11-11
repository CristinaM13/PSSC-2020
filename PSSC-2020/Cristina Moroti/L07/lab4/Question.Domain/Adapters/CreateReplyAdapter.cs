using Access.Primitives.Extensions.ObjectExtensions;
using lab4.Primitives.IO;
using lab4.Question.Domain.AskQuestionWorkflow;
using lab4.Question.Domain.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static lab4.Question.Domain.AskQuestionWorkflow.CreateReplyResult;

namespace lab4.Question.Domain.Adapters
{
    public partial class CreateReplyAdapter: Adapter<CreateReplyCmd, ICreateReplyResult, QuestionReadContext>
    {
        public override Task PostConditions(CreateReplyCmd cmd, ICreateReplyResult result, QuestionReadContext state)
        {
            throw new NotImplementedException();
        }
        public async override Task<ICreateReplyResult> Work(CreateReplyCmd cmd, QuestionReadContext state)
        {
            var result = from validate in cmd.TryValidate()
                         select validate;
            return await result.Match(
                Succ: valid => (ICreateReplyResult)(new ReplyCreated(1, cmd.QuestionId, cmd.Body)),
                Fail: ex => (ICreateReplyResult)(new InvalidIdRequest(ex.Message)));
        }
    }
}
