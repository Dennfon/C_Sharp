//Сортировка массива методом Мини Макса

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
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition])
            {
                minPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

SelectionSort(arr);
ShowArray(arr);