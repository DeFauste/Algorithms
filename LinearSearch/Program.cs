
using System.Collections;

int[] sequince = new int[6] {1,5,6,-7,3,-4};
int element = 3;

Console.WriteLine($"index = {LineSearch(sequince, element)}");
int LineSearch(int[] sequince, int element)
{
    for(int i = 0; i < sequince.Length; i++)
    {
        if(sequince[i] == element)
        {
            return i;
        }
    }
    return -1;
}
List<int> listSequince = new List<int>() {1, 5, 6, -7, 3, -4 };
Console.WriteLine($"index = {LineSearchModified(listSequince, element)}");
int LineSearchModified(List<int> sequince, int element)
{
    sequince.Add(element);
    int lastIndex = sequince.Count - 1;
    int i = 0;
    for (; sequince[i] != element ;)
    {
        i++;
    }
    sequince.Remove(lastIndex);
    if (i != lastIndex)
    {
        return i;
    }
    return -1;
}
