using System;

class GCDLCM
{
    static void Main()
    {
        Console.Write("첫번째 수 : ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("두번째 수 : ");
        int secondNum = int.Parse(Console.ReadLine());

        int dividend = firstNum > secondNum ? firstNum : secondNum;
        int divisor = firstNum > secondNum ? secondNum : firstNum;
        int rem;

        do
        {
            rem = dividend % divisor;
            dividend = divisor;
            divisor = rem;
        }while (rem != 0);
        
        int gcd = dividend;
        int lcm = (firstNum * secondNum)/gcd;

        Console.WriteLine($"최대 공약수 : {gcd}");
        Console.WriteLine($"최소 공배수 : {lcm}");
    }
}