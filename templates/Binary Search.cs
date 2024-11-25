public static int BinarySearch(List<int> arr, int target)
{
    int left = 0;
    int right = arr.Count - 1;
    int firstTrueIndex = -1;
    while (left <= right)
    {
        int mid = (left + right) / 2;
        if (feasible(mid))
        {
            firstTrueIndex = mid;
            right = mid - 1;
        }
        else
        {
            left = mid + 1;
        }
    }
    return firstTrueIndex;
}
