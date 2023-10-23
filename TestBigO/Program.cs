using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.Intrinsics.Arm;
using System.Text.Json.Serialization;
using Console = Colorful.Console;

class SortingComparison
{
    static void Main()
    {
        int[] arr = GenerateRandomArray(10000);
        int[] arrCopy = new int[arr.Length];
        
        //Imprimir Array
        Console.WriteWithGradient("ARRAY:  " + string.Join(", ", arr), Color.Green, Color.Fuchsia, 14);
        Console.ReplaceAllColorsWithDefaults();
        System.Console.ReadLine();

        // Ordenado Rápido
        Array.Copy(arr, arrCopy, arr.Length);
        Console.WriteAscii("Rapido: " + TestSortingAlgorithm(QuickSort, arrCopy).ToString() + "MS", Color.Green);
        System.Console.ReadLine();
        // Ordanado Merge
        Array.Copy(arr, arrCopy, arr.Length);
        Console.WriteAscii("Merge: " + TestSortingAlgorithm(MergeSort, arrCopy) + "MS" , Color.Blue);
        System.Console.ReadLine();

        // Burbuja
        Array.Copy(arr, arrCopy, arr.Length);
        Console.WriteAscii("Burbuja: " + TestSortingAlgorithm(BubbleSort, arrCopy )+ "MS",Color.Orange);
        System.Console.ReadLine();


        // Burbuja Clásica
        Array.Copy(arr, arrCopy, arr.Length);
        Console.WriteAscii("C. Burb: " + TestSortingAlgorithm(ClasssicBubbleSort, arrCopy) + "MS", Color.Red);
    }

    static double TestSortingAlgorithm(Action<int[]> sortingAlgorithm, int[] arr)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        sortingAlgorithm(arr);
        stopwatch.Stop();
        return stopwatch.Elapsed.TotalMilliseconds;
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length
        bool swapped;
        do
        {
            swapped = false;
            for (int i = 1; i < n; i++)
            {
                if (arr[i - 1] > arr[i])
                {
                    int temp = arr[i - 1];
                    arr[i - 1] = arr[i];
                    arr[i] = temp;
                    swapped = true;
                }
            }
        } while (swapped);
    }

    static void ClasssicBubbleSort(int[] arr)
    {
        int n = arr.Length;
        
        for(int j = 1; j < n; j++)
        {
            for (int i = 1; i < n; i++)
            {
                if (arr[i - 1] > arr[i])
                {
                    int temp = arr[i - 1];
                    arr[i - 1] = arr[i];
                    arr[i] = temp;
                }
            }
        }
    }

    static void QuickSort(int[] arr)
    {
        QuickSort(arr, 0, arr.Length - 1);
    }

    static void QuickSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = Partition(arr, left, right);
            QuickSort(arr, left, pivotIndex - 1);
            QuickSort(arr, pivotIndex + 1, right);
        }
    }

    static int Partition(int[] arr, int left, int right)
    {
        int pivot = arr[right];
        int i = left - 1;
        for (int j = left; j < right; j++)
        {
            if (arr[j] <= pivot)
            {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
        int temp2 = arr[i + 1];
        arr[i + 1] = arr[right];
        arr[right] = temp2;
        return i + 1;
    }

    static void MergeSort(int[] arr)
    {
        MergeSort(arr, 0, arr.Length - 1);
    }

    static void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);
            Merge(arr, left, mid, right);
        }
    }

    static void Merge(int[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;
        int[] leftArray = new int[n1];
        int[] rightArray = new int[n2];

        for (int i = 0; i < n1; i++)
        {
            leftArray[i] = arr[left + i];
        }
        for (int j = 0; j < n2; j++)
        {
            rightArray[j] = arr[mid + 1 + j];
        }

        int k = left;
        int x = 0, y = 0;

        while (x < n1 && y < n2)
        {
            if (leftArray[x] <= rightArray[y])
            {
                arr[k] = leftArray[x];
                x++;
            }
            else
            {
                arr[k] = rightArray[y];
                y++;
            }
            k++;
        }

        while (x < n1)
        {
            arr[k] = leftArray[x];
            x++;
            k++;
        }

        while (y < n2)
        {
            arr[k] = rightArray[y];
            y++;
            k++;
        }
    }

    static int[] GenerateRandomArray(int size)
    {
        Random random = new Random();
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = random.Next(1, 10000); // Adjust the range as needed
        }
        return arr;
    }
}
