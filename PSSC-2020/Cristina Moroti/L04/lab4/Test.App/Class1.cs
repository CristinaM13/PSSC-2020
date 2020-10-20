using lab4.Question.Domain;
using System;
using lab4.Question.Domain.AskQuestionWorkflow;
using static lab4.Question.Domain.AskQuestionWorkflow.AddQuestionResult;
using System.Collections.Generic;

namespace lab4
{
    public class Class1
    {
        static void Main(string[] args)
        {
            var cmd = new AddQuestionCmd("username", "Problem in C#", "A question is written here", "#csharp");
            var result = AddQuestion(cmd);

            result.Match(
                    ProcessQuestionPosted,
                    ProcessQuestionRejected,
                    ProcessInvalidQuestion
                );

            Console.ReadLine();
        }

        private static IAddQuestionResult ProcessInvalidQuestion(QuestionValidationFailed validationErrors)
        {
            Console.WriteLine("Question validation failed: ");
            foreach (var error in validationErrors.ValidationErrors)
            {
                Console.WriteLine(error);
            }
            return validationErrors;
        }

        private static IAddQuestionResult ProcessQuestionRejected(QuestionRejected questionRejected)
        {
            Console.WriteLine($"Question not posted: {questionRejected.Reason}");
            return questionRejected;
        }

        private static IAddQuestionResult ProcessQuestionPosted(QuestionPosted questionPosted)
        {
            Console.WriteLine($"Question {questionPosted.QuestionId}");
            return questionPosted;
        }

        public static IAddQuestionResult AddQuestion(AddQuestionCmd addQuestionCommand)
        {
            if (string.IsNullOrWhiteSpace(addQuestionCommand.User))
            {
                var errors = new List<string>() { "User not connected" };
                return new QuestionValidationFailed(errors);
            }

            if (new Random().Next(10) > 1)
            {
                return new QuestionRejected("User not connected");
            }

            var questionId = Guid.NewGuid();
            var result = new QuestionPosted(questionId, addQuestionCommand.Title);

            //execute logic
            return result;
        }
    }
}
