n = int(input())
a = [int(i) for i in input().split()]
m = a[0]
for i in a:
	if i < m:
		m = i
print(a.index(m)+1)
