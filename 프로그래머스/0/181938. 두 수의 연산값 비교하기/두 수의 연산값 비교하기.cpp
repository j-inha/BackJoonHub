#include <string>
#include <vector>

using namespace std;

int solution(int a, int b) {
    int answer = 0;
    int s = stoi(to_string(a) + to_string(b));
    if(s >= 2*a*b)
        answer = s;
        
    else  answer = 2*a*b;
    return answer;
}