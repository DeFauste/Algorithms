
int[] array = new int[] { -2, 0, 3, 5, 7, 9, 11, 15, 18 };

Console.WriteLine(BinarySearch(array, 9));
Console.WriteLine(BinarySearch(array, 5));

int BinarySearch(int[] sequence, int requairedElement)
{
    int l = 0;
    int r = sequence.Length - 1;
    while (l <= r) 
    {
        int m = (l + r) / 2;
        int element = sequence[m];
        if (element == requairedElement)
        {
            return m;
        }
        else if (element < requairedElement)
        {
            l = m + 1;
        } else
        {
            r = m - 1;
        }
    }
    return -1;
}