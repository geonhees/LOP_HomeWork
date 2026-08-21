using System;

class consecutive_Length
{
    static void Main()
    {
        int maxLength = 1;
        int nowLength = 1;
        int inputNum = int.Parse(Console.ReadLine());
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        for(int i=1; i<inputNum; i++)
        {
            if(numbers[i] == numbers[i - 1] + 1)
            {
                nowLength++;
                continue;
            }
            else
            {
                if(maxLength < nowLength)
                {
                    maxLength = nowLength;
                    nowLength = 0;
                }
            }
        }
        Console.WriteLine($"가장 긴 길이 : {maxLength}");
    }
}