# a, b를 입력받음
a, b = map(int, input().split())

# b번 반복하며 각 줄을 입력받고 뒤집어서 출력
for _ in range(a):
    k_values = input()  # 한 줄의 숫자를 입력받음
    print(k_values[::-1])  # 입력받은 숫자들을 뒤집어서 출력

