using LanguageExt.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab4.Question.Domain.AskQuestionWorkflow
{
    public class QuestionAsked
    {
        public string question { get; private set; }
        public List<string> tag { get; private set; }
        public QuestionAsked(string quest, List<string> tag1)
        {
            question = quest;
            tag = tag1;

        }
        public static Result<QuestionAsked> Create(string quest, List<string> tag)
        {
            if (IsQuestionValid(quest))
            {
                if (IsTagValid(tag))
                {
                    return new QuestionAsked(quest, tag);
                }
                else
                    return new Result<QuestionAsked>(new InvalidTagException(tag));
            }
            else
                return new Result<QuestionAsked>(new InvalidQuestionException(quest));
            
            
        }

        

        private static bool IsQuestionValid(string quest)
        {
            if (quest.Length <= 1000)
            {
                 return true;
            }
            else
                return false;
        }
        private static bool IsTagValid(List<string> tag)
        {

            if (tag.Count >= 1 && tag.Count <= 3)
                return true;
            else
                return false;
        }
        [Serializable]
        private class InvalidQuestionException : Exception
        {
            public InvalidQuestionException()
            {

            }

            public InvalidQuestionException(string quest) : base($"The value\"(quest)\"is an invalid question")
            {

            }
        }

        private class InvalidTagException : Exception
        {

            public InvalidTagException()
            {
            }
            public InvalidTagException(List<string> tag) : base($"The value\"(tag)\"is an invalid question")
            {

            }
        }
    }
}
