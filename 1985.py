p=int(input())
if(p>=1 and p<=5):
    dit={"1001":"1.50","1002":"2.50","1003":"3.50","1004":"4.50","1005":"5.50"}
    g=0.0
    for i in range (p):
        q=input().split()
        if(int(q[1])>=1 and int(q[1])<=500):
            mul=float(dit[q[0]])*int(q[1])
            g=mul+g
    print("%.2f" % g)
