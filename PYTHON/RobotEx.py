
import turtle
screen = turtle.Screen()
screen.bgcolor("lightblue")
pen = turtle.Turtle()
pen.shape("turtle")
pen.color("green")
pen.speed(4)


def draw_polygon(num_slides,length):
    angle = 360/num_slides
    for i in range(num_slides):
        pen.forward(length)
        pen.right(angle)


draw_polygon(10,50)
draw_polygon(9,50)
draw_polygon(8,50)
draw_polygon(6,50)
draw_polygon(5,50)

