def solution(nums):
    count = len(nums)
    get_pokemon = count/2
    num = set(nums)
    count2 = len(num)
    if get_pokemon > count2 :
        answer = count2
    else:
        answer = get_pokemon
    return answer