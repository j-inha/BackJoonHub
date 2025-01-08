class Program
{
    static void Main(string[] args)
    {
        // 학생 번호 배열 초기화 (1부터 30까지)
        bool[] students = new bool[31]; // 0번은 사용하지 않음

        // 과제 제출한 학생 번호 입력받기
        for (int i = 0; i < 28; i++) // 반복문을 반복하는 횟수 0이면 <28 , 1이면 <29
        {
            int s = int.Parse(Console.ReadLine());
            students[s] = true; // 제출한 학생 28명이 true로 표시
        }

        // 제출하지 않은 학생 번호 출력
        for (int i = 1; i <= 30; i++)
        {
            if (!students[i]) // false인 학생 번호 출력
            {
                Console.WriteLine(i);
            }
        }
    }
}