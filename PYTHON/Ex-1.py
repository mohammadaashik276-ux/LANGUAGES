
#print(list(range(1,101)))
'''
sum = 0
a = []
for i in range(5):
    num = int(input(f"Enter Your Number {i+1}:"))
    a.append(num)
print(a)
for i in a:
    sum = sum + i
aver = num/5 
print("Summation:", sum)
print("Average:",aver)
'''

for i in range(6):
    print()
    for j in range(1,i+1):
        print("*",end=" ")


n = 5
for i in range(1,6):
    print()
    n = n-1 
    print(" "*n,end = " ") 
    for j in range(1,i+1):
        print("*",end = " ")


