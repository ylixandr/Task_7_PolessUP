static int FindNearestGreater(int n)
{
    List<int> digits = new List<int>();
    int temp = n;
    while (temp > 0)
    {
        digits.Add(temp % 10);
        temp /= 10;
    }
    digits.Reverse();
    int[] arr = digits.ToArray();
    for (int i = arr.Length - 2; i >= 0; i--)
    {
        Array.Sort(arr, i + 1, arr.Length - i - 1);
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] > arr[i])
            {
                int temp1 = arr[i];
                arr[i] = arr[j];
                arr[j] = temp1;
                Array.Sort(arr, i + 1, arr.Length - i - 1);
                int result = 0;
                foreach (int digit in arr)
                {
                    result = result * 10 + digit;
                }
                return result;
            }
        }
    }
    return 0;
}

int n = 2017;
Console.WriteLine(FindNearestGreater(n));