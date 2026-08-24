using System;
using System.Linq;

class NumberBaseball
{
    static void Main()
    {
        int computerNum;
        int inputNum = 0;
        int tryCount = 1;

        string comString;
        string inputString;

        Random rand = new Random();

        while (true)
        {
            computerNum = rand.Next(102, 988);
            comString = computerNum.ToString();
            if(comString.Distinct().Count() == 3)
            {
                break;
            }

        }
        while(true)
        {
            Console.Write("값을 입력하세요 : ");
            inputNum = int.Parse(Console.ReadLine());
            if(inputNum == computerNum)
            {
                break;
            }

            inputString = inputNum.ToString();
            int strikeCount=0;
            int ballCount=0;
            for(int i = 0; i<3; i++)
            {
                for(int j=0; j<3; j++){
                    if(inputString[i] == comString[j]){
                        if(i == j){
                            strikeCount++;
                        }
                        else{
                            ballCount++;
                        }
                    }
                }
            }
            Console.WriteLine($"결과 : {strikeCount} strike, {ballCount} ball");
            tryCount++;
        }
        Console.WriteLine($"결과 : 정답입니다! (총 시도 횟수 : {tryCount}회)");
    }
}