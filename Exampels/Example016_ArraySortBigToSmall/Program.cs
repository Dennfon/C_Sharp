int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void ShowArray(int[] arr)
{
    int count = arr.Length;

    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
    System.Console.WriteLine();
}

ShowArray(arr);

void SelectionSort(int[] array)
{

    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition])
            {
                maxPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

SelectionSort(arr);
ShowArray(arr);