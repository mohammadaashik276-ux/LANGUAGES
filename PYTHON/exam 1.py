
import turtle
import math


def draw_triangles(x, y, size, depth, t):
    if depth == 0:
        t.up()
        t.goto(x, y)
        t.down()
        for i in range(3):
            t.forward(size)
            t.left(120)

    else:
        new_size = size /2
        h = new_size*math.sin(math.radians(60))
        draw_triangles(x, y, new_size, depth - 1, t)
        draw_triangles(x + new_size, y, new_size, depth - 1, t)
        draw_triangles(x + new_size /2, y + h, new_size, depth - 1, t)
        



pen=turtle.Turtle()
turtle.bgcolor("white") 
pen.speed(0)
pen.color("red")
draw_triangles(-200, -150, 400, 4, pen)
pen.hideturtle()
turtle.done()