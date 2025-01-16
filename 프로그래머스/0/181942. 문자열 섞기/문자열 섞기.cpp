#include <string>
#include <vector>

using namespace std;

string solution(string str1, string str2) {
    string answer = ""; // 결과를 저장할 문자열
    for (int i = 0; i < str1.length(); i++) 
    {
        answer += str1[i]; // str1의 i번째 문자 추가
        answer += str2[i]; // str2의 i번째 문자 추가
    }
    return answer;
}