using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Data
{
    public static class AnswerManager
    {
        public static Answer GetPreviousAnswer()
            {
                CalculatorEntities db = new CalculatorEntities();
                Answer prevAnswer = db.Answers.FirstOrDefault();
                return prevAnswer;
            }

        public static void Update(Answer answer)
        {
            CalculatorEntities db = new CalculatorEntities();
            Answer prevAnswer = db.Answers.FirstOrDefault();
            prevAnswer.PreviousAnswer = answer.PreviousAnswer;
            db.SaveChanges();

        }
    }
}
