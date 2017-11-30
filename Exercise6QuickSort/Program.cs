using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise6QuickSort
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("QuickSort.....Algorithm");
      int[] QNums = {7,9,13,14,16,19,24,32,37,44};
      
      QuickSort s = new QuickSort(QNums);
      for (int i = 0; i < QNums.Length; i++)
      {
        Console.WriteLine(QNums[i]);
      }
      Console.ReadLine();
    }
  }
}