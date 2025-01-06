namespace Count
{
    class Program
    {
        static void Main(string[] args)
        {
            // 첫 번째 입력: 정수 a (사용되지 않음)
            int a = int.Parse(Console.ReadLine());
            
            // 두 번째 입력: 공백으로 구분된 숫자들 (number 배열에 저장)
            string[] number = Console.ReadLine().Split();
            
            // 세 번째 입력: 비교할 정수 b
            int b = int.Parse(Console.ReadLine());
            
            // b와 일치하는 숫자의 개수 카운트
            int count = 0;
            
            // number 배열을 순회하며 b와 일치하는 값이 있는지 확인
            for (int i = 0; i < number.Length; i++)
            {
                if (b == int.Parse(number[i]))  // number[i]를 int로 변환하여 비교
                {
                    count++;
                }
            }
            
            // 결과 출력
            Console.WriteLine(count);
        }
    }
}