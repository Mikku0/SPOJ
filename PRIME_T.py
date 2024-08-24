def is_prime(num):
    if num < 2:
        return "NIE"
    for i in range(2, int(num**0.5) + 1):
        if num % i == 0:
            return "NIE"
    return "TAK"

n = int(input())
if 1 <= n <= 100000:
    for _ in range(n):
        print(is_prime(int(input())))
