int[] array = { 43, 65, 7, 877, 32, 5, 98, 3, 32 };
int n = array.Length;
int find = 32;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}