using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateTest
{
    public class LamdaTest
    {
        public void ExecuteTest()
        {
            Action[] actions = new Action[3];

            for (int i = 0; i < 3; i++)
                actions[i] = () => Console.Write(i);
            foreach (Action a in actions) a(); // 333
        }
    }
}
