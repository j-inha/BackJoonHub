using System;

namespace Compare
{
    class Program
    {
        static void Main(string[] args)
        {
            // 첫 번째 입력: 공백으로 구분된 숫자들 (number1 배열에 저장) 정수의개수 / 비교숫자
            string[] number1 = Console.ReadLine().Split();

            // 두 번째 입력: 비교할 정수 number2
            string[] number2 = Console.ReadLine().Split();

            // 비교할 숫자 (number1[1]으로 들어오며 정수로 변환)
            int comparisonValue = int.Parse(number1[1]);

            // 배열의 크기를 나타낼 count (비교숫자보다 작은 값들의 개수)
            int count = 0;

            // number2 배열을 순회하여 비교
            for (int i = 0; i < number2.Length; i++)
            {
                if (int.Parse(number2[i]) < comparisonValue)  // number2[i]를 int로 변환하여 비교
                {
                    count++;
                }
            }

            // 비교한 숫자들을 저장할 number3 배열 (size: count)
            int[] number3 = new int[count];
            int index = 0;

            // number2 배열을 다시 순회하며 number3 배열에 값 저장
            for (int i = 0; i < number2.Length; i++)
            {
                if (int.Parse(number2[i]) < comparisonValue)
                {
                    number3[index++] = int.Parse(number2[i]);  // number3에 값을 추가하면서 인덱스를 증가시킴
                }
            }

            // number3 배열 출력 (공백으로 구분하여 출력)
            Console.WriteLine(string.Join(" ", number3));
        }
    }
}
