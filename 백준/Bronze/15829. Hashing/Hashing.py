count = int(input())
number = input()
text = list(number)
answer = 0
r = 31
M = 1234567891
custom_mapping = {chr(i): i - 96 for i in range(97,123)}
for i in range(count):
    if  text[i] in custom_mapping:                                                                                                                 
        answer = (answer + custom_mapping[text[i]] * pow(r, i, M)) % M
        
print(answer)
