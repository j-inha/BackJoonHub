namespace MaxMin
{
	class Program
	{
		static void Main()
		{
			
			// 배열 선언
			int[] numbers = new int[9];

			// 사용자로부터 값을 입력 받음
			for (int i = 0; i < 9; i++)
			{
				numbers[i] = int.Parse(Console.ReadLine());  // 배열에 값 저장
			}

			//배열의 최대
			int max = numbers.Max();
			
			// 배열에서 최대값이 있는 인덱스 찾기
            		int maxIndex = Array.IndexOf(numbers, max) + 1;
			
			Console.WriteLine(max);
			Console.WriteLine(maxIndex);
		}
	}
}
