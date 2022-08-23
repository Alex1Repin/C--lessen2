int[] array = {23, 16, 8, 37, 4, 26, 12, 34, 8};

int n = array.Length;
int find = 8;
int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}