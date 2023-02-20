int[] array = { 1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] arr)
{
  int items = arr.Length;
  // items = new Random().Next(1, 10);
  for (int i = 0; i < items; i++)
  {
    Console.Write($"{arr[i]} ");
  }
  Console.WriteLine();
}

void SelectionSort(int[] arr)
{
  for (int i = 0; i < arr.Length; i++) // [0]-1
  {
    int minPosition = i;
    for (int j = i; j < arr.Length; j++) // [0]-1
    {
      if (arr[j] < arr[minPosition]) minPosition = j;
    }
    int temp = arr[i]; // 1
    arr[i] = arr[minPosition]; 
    arr[minPosition] = temp;
  }
}

PrintArray(array);
SelectionSort(array);
PrintArray(array);