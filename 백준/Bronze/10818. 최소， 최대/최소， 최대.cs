using System;
using System.Linq;

namespace Compare
{
    class Program
    {
        static void Main(string[] args)
        {
            //첫 번째 입력 : 주어지는 정수의 개수 설정
			int a = int.Parse(Console.ReadLine());
			
            // 두 번째 입력: 비교할 정수값들의 문자열 배열
            string[] number = Console.ReadLine().Split();
			
			 // 문자열 배열을 정수 배열로 변환
			int[] numbers = number.Select(int.Parse).ToArray();

            int max = numbers.Max();
			int min = numbers.Min();
            

            // 최소, 최대를 출력
            Console.WriteLine(min + " " + max);
        }
    }
}