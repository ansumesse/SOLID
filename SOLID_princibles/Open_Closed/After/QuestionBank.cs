using SOLID.OCP.Before;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed.After
{
    internal static class QuestionBank
    {
        public static List<Question> Generate()
        {
            return new List<Question>
            {
                new WhQuestion
                {
                    Title = "What are the four pillars of OOP?",
                    Mark = 8
                },
                new MultipleQustion
                {
                    Title = "Which of the following are value types?",
                    Mark = 6,
                    Choices = new List<string>
                    {
                        "A: Integer",
                        "B: Array",
                        "C: Single",
                        "D: String",
                        "E: Long",
                    }
                },
               new WhQuestion
                {
                    Title = "Earth is Bigger than sun?",
                    Mark = 4
                },
                new MultipleQustion
                {
                    Title = "Which of the following is an 8-byte Integer?",
                    Mark = 6,
                    Choices = new List<string>
                    {
                       "A.  Char",
                       "B.  Long",
                       "C.  Short",
                       "D.  Byte",
                       "E.  Integer"
                    }
                }

            };
        }
    }
}
