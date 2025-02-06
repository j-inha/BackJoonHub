from collections import deque
import sys

queue = deque()

input = sys.stdin.read
data = input().splitlines()

for command in data:
    if command.startswith("push"):
        _, x = command.split()
        queue.append(int(x))
    elif command == "pop":
        if queue:
            print(queue.popleft())
        else:
            print(-1)
    elif command == "size":
        print(len(queue))
    elif command == "empty":
        if queue:
            print(0)
        else:
            print(1)
    elif command == "front":
        if queue:
            print(queue[0])
        else:
            print(-1)
    elif command == "back":
        if queue:
            print(queue[-1])
        else:
            print(-1)
