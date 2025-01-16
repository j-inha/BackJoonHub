def solution(a, b):
    answer = 0
    s = int(str(a) + str(b))
    answer = max(s,2*a*b)
    return answer