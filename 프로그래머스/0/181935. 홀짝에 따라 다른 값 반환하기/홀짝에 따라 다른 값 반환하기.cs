using System;

public class Solution {
    public int solution(int n) {
        int count = 0;

        if (n % 2 == 0) {
            // n이 짝수일 경우, 1부터 n까지의 제곱 합 계산
            for (int i = 0; i <= n; i+=2) {
                count += i * i;
            }
        } else {
            for (int i = 1; i <= n; i+=2) {
                count += i;
            }
            // n이 홀수일 경우, 1부터 n까지의 합 계산
            
        }

        return count;
    }
}