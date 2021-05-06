C=int(input())
count=1
while(C>=count):
    take_input=input().split(" ")
    N=int(take_input[0])
    M=int(take_input[1])
    if(N>=1 and M<=100):
        z=N**M
        string=str(z)
        print(len(string))
        count+=1
