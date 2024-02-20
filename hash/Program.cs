using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int[] setData = new int[3]; // 배열의 크기를 3으로 가정

        HashSet<int> usedNumbers = new HashSet<int>();

        for (int i = 0; i < setData.Length; i++)
        {
            int randomNumber;
            do
            {
                randomNumber = rand.Next(100, 1000); // 100부터 999까지의 범위에서 랜덤한 값을 생성
            } while (usedNumbers.Contains(randomNumber)); // 중복 확인

            setData[i] = randomNumber;
            usedNumbers.Add(randomNumber);
        }

        // 결과 출력
        Console.WriteLine("중복되지 않는 3자리 숫자 배열:");
        foreach (int num in setData)
        {
            Console.WriteLine(num);
        }
    }
}
