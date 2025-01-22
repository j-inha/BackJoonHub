count = int(input())
gradiant = input().split()
orgradiant = input().split()

for g in gradiant:
    if g not in orgradiant:
        print(g)