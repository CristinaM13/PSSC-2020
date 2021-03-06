// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using CSharp.Choices;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab4.Question.Domain.AskQuestionWorkflow
{
    public static partial class AuthorAcknowledgement
    {
        public static IAuthorAcknowledgement Match(this IAuthorAcknowledgement self, System.Func<AuthorAcknowledgementSent, IAuthorAcknowledgement> whenAuthorAcknowledgementSent, System.Func<AuthorAcknowledgementNotSent, IAuthorAcknowledgement> whenAuthorAcknowledgementNotSent)
        {
            switch ((self))
            {
                case AuthorAcknowledgementSent authoracknowledgementsent:
                    return whenAuthorAcknowledgementSent(authoracknowledgementsent);
                case AuthorAcknowledgementNotSent authoracknowledgementnotsent:
                    return whenAuthorAcknowledgementNotSent(authoracknowledgementnotsent);
                default:
                    throw new System.NotSupportedException("This switch statement should be exhaustive");
            }
        }

        public static async System.Threading.Tasks.Task<IAuthorAcknowledgement> MatchAsync(this IAuthorAcknowledgement self, System.Func<AuthorAcknowledgementSent, System.Threading.Tasks.Task<IAuthorAcknowledgement>> whenAuthorAcknowledgementSent, System.Func<AuthorAcknowledgementNotSent, System.Threading.Tasks.Task<IAuthorAcknowledgement>> whenAuthorAcknowledgementNotSent)
        {
            switch ((self))
            {
                case AuthorAcknowledgementSent authoracknowledgementsent:
                    return await whenAuthorAcknowledgementSent(authoracknowledgementsent);
                case AuthorAcknowledgementNotSent authoracknowledgementnotsent:
                    return await whenAuthorAcknowledgementNotSent(authoracknowledgementnotsent);
                default:
                    throw new System.NotSupportedException("This switch statement should be exhaustive");
            }
        }

        public static R Match<R>(this IAuthorAcknowledgement self, System.Func<AuthorAcknowledgementSent, R> whenAuthorAcknowledgementSent, System.Func<AuthorAcknowledgementNotSent, R> whenAuthorAcknowledgementNotSent)
        {
            switch ((self))
            {
                case AuthorAcknowledgementSent authoracknowledgementsent:
                    return whenAuthorAcknowledgementSent(authoracknowledgementsent);
                case AuthorAcknowledgementNotSent authoracknowledgementnotsent:
                    return whenAuthorAcknowledgementNotSent(authoracknowledgementnotsent);
                default:
                    throw new System.NotSupportedException("This switch statement should be exhaustive");
            }
        }

        public static async System.Threading.Tasks.Task<R> MatchAsync<R>(this IAuthorAcknowledgement self, System.Func<AuthorAcknowledgementSent, System.Threading.Tasks.Task<R>> whenAuthorAcknowledgementSent, System.Func<AuthorAcknowledgementNotSent, System.Threading.Tasks.Task<R>> whenAuthorAcknowledgementNotSent)
        {
            switch ((self))
            {
                case AuthorAcknowledgementSent authoracknowledgementsent:
                    return await whenAuthorAcknowledgementSent(authoracknowledgementsent);
                case AuthorAcknowledgementNotSent authoracknowledgementnotsent:
                    return await whenAuthorAcknowledgementNotSent(authoracknowledgementnotsent);
                default:
                    throw new System.NotSupportedException("This switch statement should be exhaustive");
            }
        }
    }
}