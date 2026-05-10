'''
import turtle
t = turtle.Turtle()
screen = turtle.Screen()
screen.bgcolor("black")
t.color("red")              # t.pencolor("red") =======> only turtle pen border color is red
t.speed(0)
t.goto(0,0)


def draw_a_shape(num_slides,len):
    angle = 360/num_slides
    for i in range(num_slides):
        t.forward(len)
        t.right(angle)

draw_a_shape(4,50)
draw_a_shape(5,60)
turtle.done()
'''
'''
import turtle

t = turtle.Turtle()
scr = turtle.Screen()
scr.bgcolor("black")
t.color("red")
t.speed(0)
def drw_star(x):
    for i in range(5):
        t.forward(x)
        t.right(144)

drw_star(100)
turtle.done()
'''


import turtle

t = turtle.Turtle()
s = turtle.Screen()
s.bgcolor("black")
t.pencolor("red")
t.speed(0)
t.left(90)
def drw_tree(size):
    for i in range(6):

        t.forward(size)
        size -= 25
        t.left(30)

t.penup()
t.goto(-100,-250)
t.pendown()
drw_tree(150)
turtle.done()
