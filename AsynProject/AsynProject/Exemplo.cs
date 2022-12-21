using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynProject
{
    internal class Exemplo
    {
        bool Task_TResult()
        {
            return DateTime.IsLeapYear(DateTime.Now.Year);
        }
        void Task_Void()
        {
            Task.Delay(2000);
            Form1.lstBox.Items.Add("Long task executed");
        }

        public void Task_LongTime()
        {
            bool isLeapYear = Task_TResult();
            Form1.lstBox.Items.Add($"{DateTime.Now.Year} {(isLeapYear? "is " : "is not ")} Leap Year");
            Task_Void();
        }
    }
}
