void insertion_sort(int[] sorting_array, int i = 1)
{
    int k = i;
    int temp;
    while (k > 0 && sorting_array[k] < sorting_array[k - 1])
    {
        temp = sorting_array[k];
        sorting_array[k] = sorting_array[k - 1];
        sorting_array[k - 1] = temp;
        k--;
    }
    if (i < sorting_array.Length - 1)
    {
        i++;
        insertion_sort(sorting_array, i);
    }
}
int[] array = [5, 7, 4, 2, 8, 3, 1, 6, 9, 3];
insertion_sort(array);

for (int j = 0; j < array.Length; j++)
{
    Console.Write(array[j] + " ");
}


// Queue
List<int> queue_list = new List<int>();
void enqueue(int item)
{
    queue_list.Add(item);
}
int dequeue()
{
    int temp;
    temp = queue_list[0];
    List<int> list = queue_list.GetRange(1, queue_list.Count - 1);
    queue_list.Clear();
    queue_list.AddRange(list);
    return temp;
}

enqueue(0);
enqueue(1);
enqueue(2);
enqueue(3);
enqueue(4);
Console.WriteLine(queue_list[0]);
Console.WriteLine(queue_list[1]);
Console.WriteLine(dequeue());
Console.WriteLine(queue_list[0]);
Console.WriteLine(queue_list[3]);