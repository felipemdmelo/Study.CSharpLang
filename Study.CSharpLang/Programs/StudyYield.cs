using Study.CSharpLang.Programs.Interfaces;
using System;
using System.Collections.Generic;

namespace Study.CSharpLang.Programs
{
    public class StudyYield : IProgram
    {
        public void Program()
        {
            Console.WriteLine("INICIANDO ANÁLISE DO CÓDIGO COM yield");

            var results = Power(2, 8);
            // Display powers of 2 up to the exponent 8:
            foreach (int i in results)
            {
                Console.Write("{0} ", i);
            }

            Console.ReadLine();
        }

        private IEnumerable<int> Power(int number, int exponent)
        {
            int counter = 0;
            int result = 1;
            while (counter++ < exponent)
            {
                result = result * number;
                yield return result;
            }
        }
    }
}
