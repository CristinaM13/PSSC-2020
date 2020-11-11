using lab4.Question.Domain;
using System;
using lab4.Question.Domain.AskQuestionWorkflow;
using static lab4.Question.Domain.AskQuestionWorkflow.AddQuestionResult;
using System.Collections.Generic;
using LanguageExt;
using System.Diagnostics.Tracing;
using System.Collections.ObjectModel;

namespace lab4
{
    public class Class1
    {
        static void Main(string[] args)
        {
            var cmd = new AddQuestionCmd("username", "Problem in C#", "A question is written here", "#csharp");
            var question = QuestionAsked.Create("this is a question", new List<string>() { "tag1", "tag2" });

            
            question.Match(
                Succ: quest =>
                {
                    VoteQuestion(quest);
                    Console.WriteLine("Valid Question");
                    return Unit.Default;
                },
                Fail: ex =>
                {
                    Console.WriteLine($"Invalid Question. Reason:  {ex.Message}");
                    return Unit.Default;
                }
                );

            Console.ReadLine();

        }
        private static void VoteQuestion(QuestionAsked question)
        {
            var Result = new PublishedQuestion().PublishQuestion(question);
            Result.Match(
                    Succ: vote =>
                    {
                        new Vote().YouCanVote(vote);
                        return Unit.Default;
                    },
                    Fail: ex =>
                    {
                        Console.WriteLine("You can't vote, question not published.");
                        return Unit.Default;
                    }
                );
        }


    }
}
