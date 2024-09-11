
int[] sequince = new int[12] {-12,-8,-4,-1,3,5,7,9,12,24,26,27};
int element = 9;

Console.WriteLine($"index = {InterpolationSearch(sequince, element)}");
int InterpolationSearch(int[] sequince, int element)
{
    int l = 0;
    int r = sequince.Length - 1;
    for (; sequince[l] < element && element < sequince[r];)
    {
        if (sequince[l] == sequince[r])
        {
            break;
        }
        int index = (element - sequince[l]) * (l - r) / (sequince[l] - sequince[r]) + l;
        if (sequince[index] > element)
        {
            r = index - 1;
        } else if(sequince[index] < element)
        {
            l = index + 1;
        } else
        {
            return index;
        }
    }

    if (sequince[l] == element)
    {
        return l;
    }
    if (sequince[r] == element)
    {
        return r;
    }
    return -1;
}