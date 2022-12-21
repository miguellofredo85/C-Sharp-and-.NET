using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynProject
{
    internal class ExemploAsync
    {
        async Task<bool> Task_TResult()
        {
            return await Task.FromResult<bool>(DateTime.IsLeapYear(DateTime.Now.Year));
        }
        async Task Task_Void()
        {
            await Task.Delay(2000);
            Form1.lstBox.Items.Add("Long task executed");
        }

        public async Task Task_LongTime()
        {
            bool isLeapYear = await Task_TResult();
            Form1.lstBox.Items.Add($"{DateTime.Now.Year} {(isLeapYear ? "is " : "is not ")} Leap Year");
            await Task_Void();
        }
    }
}
