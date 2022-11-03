// Задачка по сортировке массива по возрастанию

int[] Array = { 5, 8, 6, 4, 8, 15, 65, 2555, 12, 4586 };

void SelectionSort(int[] Array);
{
    for (int i = 0; i < Array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < Array.Length; j++)
        {
            if (Array[j] < Array[maxPosition])
            {
                maxPosition = j;
            }
        }
        int temp = Array[i];
        Array[i] = Array[maxPosition];
        Array[maxPosition] = temp;
    }
}

void printArray(int[] Array)
{
    int count = Array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{Array[i]} ");
    }
    Console.WriteLine();
}
