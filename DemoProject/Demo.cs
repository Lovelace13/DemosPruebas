using System;
using System.Collections.Generic;

namespace DemoProject
{
    public class Demo
    {
        public string GetMessage()
        {
            return "Hola Mundo!";
        }

        public int[] getPares()
        {
            List<int> pares = new List<int>();
            for (int i = 1; i < 100; i++)
            {
                if (i % 2 == 0) pares.Add(i);
            }

            return pares.ToArray();
        }
    }
}
