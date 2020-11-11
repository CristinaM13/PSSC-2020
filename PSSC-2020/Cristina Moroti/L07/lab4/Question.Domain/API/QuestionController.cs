using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using lab4.Primitives.IO;
using lab4.Question.Domain.AskQuestionWorkflow;
using static lab4.Question.Domain.AskQuestionWorkflow.CreateReplyResult;
using LanguageExt;
using lab4.Question.Domain.Context;
using Microsoft.Graph;
using LanguageExt.Common;
using Access.Primitives.Extensions.ObjectExtensions;

namespace StackUnderflow.API.Rest.Controllers
{
    [ApiController]
    [Route("question")]
    public class QuestionController : ControllerBase
    {
        private readonly IInterpreterAsync _interpreter;
        private readonly QuestionContext _dbContext;

        public QuestionController(IInterpreterAsync interpreter, QuestionContext dbContext)
        {
            _interpreter = interpreter;
            _dbContext = dbContext;
        }

        [HttpPost("CreateReply")]
        public async Task<IActionResult> CreateTenantAsyncAndInviteAdmin([FromBody] CreateReplyCmd createReplyCmd)
        {


            var expr = from createReplyResult in QuestionDomain.CreateReply(createReplyCmd.QuestionId, createReplyCmd.AuthorQuestionId, createReplyCmd.QuestionOwnerId, createReplyCmd.Body)
                       let reply = createReplyResult.SafeCast<ReplyCreated>().Select(re => re)
                       from checkLanguageResult in QuestionDomain.CheckLanguage(createReplyCmd.Body)
                       from ownerAcknowledgementResult in QuestionDomain.QuestionOwnerAcknowledgement(createReplyCmd.QuestionId, createReplyCmd.QuestionOwnerId)
                       from authorAcknowledgementResult in QuestionDomain.ReplyAuthorAcknowledgement(createReplyCmd.QuestionId, createReplyCmd.AuthorQuestionId, reply)
                       select new { createReplyResult, checkLanguageResult, ownerAcknowledgementResult, authorAcknowledgementResult };

            var ctx = new QuestionReadContext(new List<Post>());
            var r = await _interpreter.Interpret(expr, ctx);

            return r.createReplyResult.Match(
                created => (IActionResult)Ok("Reply added"),
                notCreated => BadRequest("Reply not added")
                );
            
        }



    }
}
