using System;

class Coin
{
    static void Main()
    {
        int won = int.Parse(Console.ReadLine());
        int FiveHundred = 0;
        int OneHundred = 0;
        int Fifty = 0;
        int Ten = 0;

        while(won > 0)
        {
            if(won-500 > 0)
            {
                FiveHundred++;
                won -= 500;
                continue;
            }
            else if(won-100 > 0)
            {
                OneHundred++;
                won -= 100;
                continue;
            }
            else if(won-50 > 0)
            {
                Fifty++;
                won -= 50;
                continue;
            }
            else
            {
                Ten++;
                won -= 10;
                continue;
            }
        }

        Console.WriteLine($"500원 : {FiveHundred}\n100원 : {OneHundred}\n50원 : {Fifty}\n10원 : {Ten}");
    }
}