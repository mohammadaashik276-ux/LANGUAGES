'''
def factorial(n):
    if n == 0:
        return 1
    
    else:
        return n*factorial(n-1)
    

num = int(input("Enter Your value: "))
ans = factorial(num)
print(f"factorial({num}) = {ans}")

'''


import turtle

def draw_a_tree(len,tur):
    if len < 10:
        return
    tur.forward(len)
    tur.left(25)
    draw_a_tree(len-10,tur)
    tur.right(50)
    draw_a_tree(len-10,tur)
    tur.left(25)
    tur.backward(len)


screen = turtle.Screen()
screen.bgcolor("white")
t = turtle.Turtle()
t.color("green")
t.speed(0.01)
t.width(2)
t.left(90)
t.penup()
t.backward(200)
t.pendown()
draw_a_tree(100,t)
t.hideturtle()
screen.exitonclick()