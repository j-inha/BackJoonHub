import sys

# 여러 줄 입력받기
lines = sys.stdin.read().splitlines()

# 결과를 저장할 변수 초기화
answer = ""

if lines:  # 입력이 있을 경우
    # 가장 긴 줄의 길이 계산
    max_length = max(len(line) for line in lines)

    # 각 열(column) 기준으로 순회
    for j in range(max_length):
        for line in lines:
            try:
                answer += line[j]
            except IndexError:
                pass  # 인덱스 초과를 무시

    print(answer)