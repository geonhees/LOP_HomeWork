using System;
using System.Linq;

class NumberBaseball
{
    static void Main()
    {
        int computerNum;
        int inputNum = 0;
        int tryCount = 0;
        int strikeCount = 0;
        int ballCount = 0;

        string comString;
        string inputString;

        Random rand = new Random();

        while (true)
        {
            computerNum = rand.Next(102, 988);
            comString = computerNum.ToString();
            comString = comString.Distinct();
            if(comString.Count() == 3)
            {
                break;
            }

        }
        while(computerNum != inputNum)
        {
            inputNum = int.Parse(Console.ReadLine());
            inputString = inputNum.ToString();
            for(int i = 0; i<3; i++)
            {
                
            }
            tryCount++;
        }
    }
}