using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Text;
using static PortExt;

namespace lab4.Question.Domain.Context
{
    public class QuestionReadContext
    {
        public QuestionReadContext(IEnumerable<Post> questions)
        {
            Questions = questions;
        }

        public IEnumerable<Post> Questions { get; }

    }
}
