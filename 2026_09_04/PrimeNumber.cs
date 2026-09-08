using System;

class PrimeNumber
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int count = 0;

        //소수인지 아닌지 확인할 배열
        bool[] isNotPrimeNum = new bool[num];
        
        //소수인지 판별하기 위한 반복문
        //어차피 1은 소수가 아니니까 2부터 시작
        for(int i=2; i<num; i++)
        {
            //소수가 아니면 반복문 다시
            if (isNotPrimeNum[i])
            {
                continue;
            }
            //j는 i의 배수니까 그 위치에 있는 수를 없애기 위한 반복문
            for(int j=i*i; j<num; j += i)
            {
                //j에 있는 수 true로 바꿔서 false인거만 걸러내기
                isNotPrimeNum[j] = true;
            }
        }
        Console.Write("소수 목록 : ");
        for(int i=2; i<num; i++)
        {
            if (!isNotPrimeNum[i])
            {
                Console.Write(i+" ");
                count++;
            }
        }
        Console.WriteLine();
        Console.WriteLine($"소수의 개수 : {count}");
    }
}