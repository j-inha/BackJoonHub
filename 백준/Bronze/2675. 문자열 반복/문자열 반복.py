count = int(input())  # 반복할 횟수
num = []  # 결과를 저장할 리스트

for i in range(count):
    x, y = input().split()  # 두 값을 공백으로 나누어 입력받음
    result = ''.join([char * int(x) for char in y])  # 각 문자를 정수 x만큼 반복하여 이어 붙임
    num.append(result)

# 각 결과를 줄별로 출력
for item in num:
    print(item)
