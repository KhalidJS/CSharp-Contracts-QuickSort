using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6QuickSort
{
  interface IQuickSort
  {
     void Sort(int[] array);
     void Sort(int[] array,int left,int right);
     int Partition(int[] array, int left, int right, int pivot);
     void Swap(int[] array,int index1,int index2);
  }
}