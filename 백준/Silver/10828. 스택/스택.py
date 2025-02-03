import sys

stack = []
n = int(input())
result = []

for _ in range(n):
	string = sys.stdin.readline().split()
	if string[0] == "push":
		count = int(string[1])
		stack.append(count)
	elif string[0] == "pop":
		if len(stack) == 0:
			result.append("-1")
		else :
			result.append(str(stack.pop()))
	elif string[0] == "size":
		 result.append(str(len(stack)))
	elif string[0] == "empty":
		if len(stack) == 0:
			result.append("1")
		else:
			result.append("0")
	elif string[0] == "top":
		if len(stack) == 0:
			result.append("-1")
		else:
			result.append(str(stack[-1]))
            
sys.stdout.write("\n".join(result) + "\n")