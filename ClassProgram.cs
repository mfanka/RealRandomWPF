using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealRandomWPF
{
    class ClassProgram
    {

        private static int Number1;
        private static int Number2;
        public void InputOne(int number)
        {
            Number1 = number;
        }
        public void InputTwo(int number)
        {
            Number2 = number + 1;
        }
        public int OutPutOne()
        {
            Random random = new Random();
            return random.Next(Number1,Number2);
        }
        
    }
}
