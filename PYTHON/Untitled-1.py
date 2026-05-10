#print(" * "*4)
'''
import math
from turtle import*
def heart_a(k):
    return 15*math.sin(k)**3
def heart_b(k):
    return 12*math.cos(k)-5*\
    math.cos(2*k)-2*\
    math.cos(3*k)-\
    math.cos(4*k)

speed(0)
bgcolor("black")
for i in range(6000):
    goto(heart_a(i)*20,heart_b(i)*20)
    for j in range(1):
        color("red")
    goto(0,0)
done()
'''

import math
from turtle import *

def heart_a(t):
    return 15 * math.sin(t) ** 3

def heart_b(t):
    return 12 * math.cos(t) - 5 * math.cos(2*t) - 2 * math.cos(3*t) - math.cos(4*t)

speed(0.0001)
bgcolor("black")
color("red")
penup()

for i in range(6000):
    t = i * 0.01
    x = heart_a(t) * 20
    y = heart_b(t) * 20
    goto(x, y)
    pendown()

done()

'''
from turtle import *
from colorsys import *
tracer(10)
bgcolor("black")
pensize(1)
h = 0
goto(0,20)
def draw(ang, n):
    circle(5+n,60)
    left(ang)
    circle(5+n*2,60)
for i in range(200):
    color(hsv_to_rgb(h,1,1))
    h += 0.0062
    up()
    draw(90,i)
    draw(180,0)
    down()
    draw(1/2,0)
    draw(180,i/2)
    draw(120, 0)
    draw(1/2,0)
    draw(120,0)
hideturtle()
done()
'''