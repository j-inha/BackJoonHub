def solution(s):
    # 각 문자의 개수를 세는 변수 초기화
    count_p = 0
    count_P = 0
    count_y = 0
    count_Y = 0
    
    # 문자열 입력 받기
    user_input = s
    
    # 입력받은 문자열에서 각 문자 개수 세기
    for i in range(len(user_input)):
        if user_input[i] == 'p':
            count_p += 1
        elif user_input[i] == 'P':
            count_P += 1
        elif user_input[i] == 'y':
            count_y += 1
        elif user_input[i] == 'Y':
            count_Y += 1
    
    # p와 y의 총합 계산
    p = count_p + count_P
    y = count_y + count_Y
    
    # 결과 출력
    if p == 0 and y == 0:
        s = True;
    elif p == y:
        s = True;
    else:
        s = False;
        
    return s
