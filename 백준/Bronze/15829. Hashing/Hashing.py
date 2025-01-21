count = int(input())
number = input()
text = list(number)
answer = 0
custom_mapping = {chr(i): i - 96 for i in range(97,123)}
for i in range(count):
    
    if  text[i] in custom_mapping:                                                                                                                 
        answer += custom_mapping[text[i]] * 31**i
print(answer)