T = int(input())  # 테스트 케이스 개수

for _ in range(T):
    x, y = input().split()
    result = ''.join([char * int(x) for char in y]) 
    print(result)
