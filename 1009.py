name = input()
salary = float(input())
sales = float(input())
bonus = float(sales * (15/100))

total = salary + bonus

print("TOTAL = R$ %0.2f" %total)
