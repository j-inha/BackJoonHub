def solution(phone_book):
    phone = set(phone_book)
    
    for i in phone_book:
        for j in range(len(i)):
            if i[:j] in phone:
                return False
                                           
    return True;