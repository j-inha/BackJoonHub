count = int(input())
s = b = p = l = 0 

for _ in range(count):
    x, y = input().split()
    y = int(y)
    if x == "STRAWBERRY":
        s += y
    elif x == "BANANA":
        b += y
    elif x == "PLUM":
        p += y
    elif x == "LIME":
        l += y

if s == 5 or b == 5 or p == 5 or l == 5:
    print("YES")
else:
    print("NO")

