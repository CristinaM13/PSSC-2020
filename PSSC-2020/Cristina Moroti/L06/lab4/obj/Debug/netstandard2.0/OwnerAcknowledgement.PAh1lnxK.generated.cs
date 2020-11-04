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
    public static partial class OwnerAcknowledgement
    {
        public static IOwnerAcknowledgement Match(this IOwnerAcknowledgement self, System.Func<OwnerAcknowledgementSent, IOwnerAcknowledgement> whenOwnerAcknowledgementSent, System.Func<OwnerAcknowledgementNotSent, IOwnerAcknowledgement> whenOwnerAcknowledgementNotSent)
        {
            switch ((self))
            {
                case OwnerAcknowledgementSent owneracknowledgementsent:
                    return whenOwnerAcknowledgementSent(owneracknowledgementsent);
                case OwnerAcknowledgementNotSent owneracknowledgementnotsent:
                    return whenOwnerAcknowledgementNotSent(owneracknowledgementnotsent);
                default:
                    throw new System.NotSupportedException("This switch statement should be exhaustive");
            }
        }

        public static async System.Threading.Tasks.Task<IOwnerAcknowledgement> MatchAsync(this IOwnerAcknowledgement self, System.Func<OwnerAcknowledgementSent, System.Threading.Tasks.Task<IOwnerAcknowledgement>> whenOwnerAcknowledgementSent, System.Func<OwnerAcknowledgementNotSent, System.Threading.Tasks.Task<IOwnerAcknowledgement>> whenOwnerAcknowledgementNotSent)
        {
            switch ((self))
            {
                case OwnerAcknowledgementSent owneracknowledgementsent:
                    return await whenOwnerAcknowledgementSent(owneracknowledgementsent);
                case OwnerAcknowledgementNotSent owneracknowledgementnotsent:
                    return await whenOwnerAcknowledgementNotSent(owneracknowledgementnotsent);
                default:
                    throw new System.NotSupportedException("This switch statement should be exhaustive");
            }
        }

        public static R Match<R>(this IOwnerAcknowledgement self, System.Func<OwnerAcknowledgementSent, R> whenOwnerAcknowledgementSent, System.Func<OwnerAcknowledgementNotSent, R> whenOwnerAcknowledgementNotSent)
        {
            switch ((self))
            {
                case OwnerAcknowledgementSent owneracknowledgementsent:
                    return whenOwnerAcknowledgementSent(owneracknowledgementsent);
                case OwnerAcknowledgementNotSent owneracknowledgementnotsent:
                    return whenOwnerAcknowledgementNotSent(owneracknowledgementnotsent);
                default:
                    throw new System.NotSupportedException("This switch statement should be exhaustive");
            }
        }

        public static async System.Threading.Tasks.Task<R> MatchAsync<R>(this IOwnerAcknowledgement self, System.Func<OwnerAcknowledgementSent, System.Threading.Tasks.Task<R>> whenOwnerAcknowledgementSent, System.Func<OwnerAcknowledgementNotSent, System.Threading.Tasks.Task<R>> whenOwnerAcknowledgementNotSent)
        {
            switch ((self))
            {
                case OwnerAcknowledgementSent owneracknowledgementsent:
                    return await whenOwnerAcknowledgementSent(owneracknowledgementsent);
                case OwnerAcknowledgementNotSent owneracknowledgementnotsent:
                    return await whenOwnerAcknowledgementNotSent(owneracknowledgementnotsent);
                default:
                    throw new System.NotSupportedException("This switch statement should be exhaustive");
            }
        }
    }
}