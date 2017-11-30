using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace Exercise6QuickSort
{
  public class QuickSort : IQuickSort
  {
    public QuickSort(int[] arr)
    {
      Contract.Requires(arr != null);
      Sort(arr);
    }

    public void Sort(int[] array)
    {
      Contract.Requires(array != null);
      Contract.Ensures(Contract.ForAll(0, array.Length, i => Contract.ForAll(i + 1, array.Length, j => array[i] <= array[j])));

      Sort(array,0,array.Length - 1);
    }
    

    public void Sort(int[] array, int left, int right)
    {
      Contract.Requires(array != null);
      Contract.Ensures(left >= 0 && right >= 0);
      if (left < right)
      {
        int pivot = Partition(array, left, right);

        if (pivot > 1)
          Sort(array, left, pivot - 1);

        if (pivot + 1 < right)
          Sort(array, pivot + 1, right);
      }
    }

    public int Partition(int[] array,int left, int right,int pivot)
    {
      return 0;
    }
    
    public int Partition(int[] array, int left, int right)
    {
      Contract.Requires(array != null);
      Contract.Ensures(Contract.Exists(0, array.Length,x =>  x < array.Length-1 && array[x] <= array[x + 1]));

      int pivot = array[left];

      while (true)
      {
        while (array[left] < pivot)
          left++;

        while (array[right] > pivot)
          right--;

        if (left < right)
        {
          Swap(array,left,right);
        }
        else
        {
          return right;
        }
      }
    }

    public void Swap(int[] array, int index1, int index2)
    {
      Contract.Requires(array != null);
      Contract.Ensures(index1 >= 0 && index2 >= 0);
      int temp = array[index1];
      array[index1] = array[index2];
      array[index2] = temp;
    }
  }
}