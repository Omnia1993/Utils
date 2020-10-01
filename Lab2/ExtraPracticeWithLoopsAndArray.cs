using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class ExtraPracticeWithLoopsAndArray
    {
        static void Main(string[] args)
        {
            int input = Utils.GetNumber("Enter Array size: ");
      int[] arrayOfNum= new int[input];
            int min = 0;
            int max = 0;
            for(int i=0;i<arrayOfNum.Length;i++)
                arrayOfNum[i]=Utils.GetNumber($"#{i}: ");
          
        }
    }
}
