using System;

class Stair
{
    static void Main()
    {
        Console.Write("계단의 높이 : ");
        int N = int.Parse(Console.ReadLine());
        int temp1 = 1;
        int temp2 = 2;
        int current = 0;

        switch (N)
        {
            case 1:
                Console.WriteLine(temp1);
                break;
            case 2:
                Console.WriteLine(temp2);
                break;
            
            default:
                for(int i=3; i<N+1; i++)
                {
                    current = temp1+temp2;
                    temp1 = temp2;
                    temp2 = current;
                }
                Console.WriteLine($"올라가는 방법의 수 : {current}");
                break;
        }
    }
}