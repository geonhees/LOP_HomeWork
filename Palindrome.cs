using System;

class Palindrome
{
    static void Main()
    {
        Console.Write("입력 : ");
        int palindromeNumber = int.Parse(Console.ReadLine());
        int reverseNumber = 0;
        int temp = palindromeNumber;

        while(temp > 0)
        {
            reverseNumber = (reverseNumber*10) + (temp%10);
            temp /= 10;
        }

        Console.WriteLine($"뒤집은 수 : {reverseNumber}");

        if(reverseNumber == palindromeNumber)
        {
            Console.WriteLine("팰린드롬 여부 : YES");
        }
        else
        {
            Console.WriteLine("팰린드롬 여부 : NO");
        }
    }
}