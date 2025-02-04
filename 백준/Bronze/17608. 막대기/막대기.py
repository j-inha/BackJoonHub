import sys

# 입력 최적화
input = sys.stdin.read
data = input().splitlines()

n = int(data[0])
sticks = list(map(int, data[1:]))

# 스택을 사용하여 보이는 막대기 찾기
stack = []  # 보이는 막대기의 높이만 저장

# 오른쪽에서 왼쪽으로 탐색
for stick in reversed(sticks):
    if not stack or stick > stack[-1]:
        stack.append(stick)

# 보이는 막대기의 개수는 스택의 크기
print(len(stack))
