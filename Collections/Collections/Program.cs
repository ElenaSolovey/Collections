using System;
using System.Collections;
using System.Collections.Generic;


namespace Collections
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ArrayList test = Number(3, 5);
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(test[i]);
            }
        }

        public static ArrayList Number(double a, double q)
        {
          
            ArrayList numberList = new ArrayList();

            for(int i = 0;  i< 20; i++)
            {
                a += q ;
                numberList.Add(a);
            }
            return numberList;
        }

    }
}
