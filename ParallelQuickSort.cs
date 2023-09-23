using System;
using System.Threading.Tasks;
using System.Collections.Generic;

class HelloWorld
{
    static int Threshold = 10;

    static void ParallelQuickSortAscending(List<int> list, int from, int to, int depthRemaining)
    {
        if (to - from <= Threshold)
        {
            AscendingSort(list, from, to);
        }
        else
        {
            int pivot = from + (to - from) / 2;
            pivot = Partition(list, from, to, pivot);
            if (depthRemaining > 0)
            {
                Parallel.Invoke(() => ParallelQuickSortAscending(list, from, pivot - 1, depthRemaining - 1),
                                 () => ParallelQuickSortAscending(list, pivot + 1, to, depthRemaining - 1));
            }
            else
            {
                ParallelQuickSortAscending(list, from, pivot - 1, 0);
                ParallelQuickSortAscending(list, pivot + 1, to, 0);
            }
        }
    }

    static void ParallelQuickSortDescending(List<int> list, int from, int to, int depthRemaining)
    {
        if (to - from <= Threshold)
        {
            DescendingSort(list, from, to);
        }
        else
        {
            int pivot = from + (to - from) / 2;
            pivot = Partition(list, from, to, pivot);
            if (depthRemaining > 0)
            {
                Parallel.Invoke(() => ParallelQuickSortDescending(list, from, pivot - 1, depthRemaining - 1),
                                 () => ParallelQuickSortDescending(list, pivot + 1, to, depthRemaining - 1));
            }
            else
            {
                ParallelQuickSortDescending(list, from, pivot - 1, 0);
                ParallelQuickSortDescending(list, pivot + 1, to, 0);
            }
        }
    }

    static void AscendingSort(List<int> list, int from, int to)
    {
        for (int i = from + 1; i <= to; i++)
        {
            int value = list[i];
            int j = i - 1;
            while (j >= from && list[j] > value)
            {
                list[j + 1] = list[j];
                j--;
            }
            list[j + 1] = value;
        }
    }

    static void DescendingSort(List<int> list, int from, int to)
    {
        for (int i = from + 1; i <= to; i++)
        {
            int value = list[i];
            int j = i - 1;
            while (j >= from && list[j] < value)
            {
                list[j + 1] = list[j];
                j--;
            }
            list[j + 1] = value;
        }
    }

    static int Partition(List<int> list, int from, int to, int pivotIndex)
    {
        int pivotValue = list[pivotIndex];
        Swap(list, pivotIndex, to);
        int storeIndex = from;
        for (int i = from; i < to; i++)
        {
            if (list[i] < pivotValue)
            {
                Swap(list, i, storeIndex);
                storeIndex++;
            }
        }
        Swap(list, storeIndex, to);
        return storeIndex;
    }

    static void Swap(List<int> list, int i, int j)
    {
        int tmp = list[i];
        list[i] = list[j];
        list[j] = tmp;
    }

    static void Main()
    {
        var list = new List<int>();
        var list2 = new List<int>();
        Console.WriteLine("Input 5 numbers: ");

        for (int i = 0; i < 5; i++)
        {
            int num = int.Parse(Console.ReadLine());
            list.Add(num);
            list2.Add(num);
        }

        ParallelQuickSortAscending(list, 0, list.Count - 1, 2);
        Console.WriteLine("Sorted List: " + string.Join(",", list));

        ParallelQuickSortDescending(list2, 0, list2.Count - 1, 2);
        Console.WriteLine("Reverse Sorted List: " + string.Join(",", list2));
    }
}
