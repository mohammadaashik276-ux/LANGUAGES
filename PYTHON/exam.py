
import turtle

def Draw_a_tree(t, length):
    if length<5:
        return
    
    else:
        t.forward(length)
        t.left(25)
        Draw_a_tree(t, length-10)
        t.right(50)
        Draw_a_tree(t, length-10)
        t.left(25)
        t.penup()
        t.backward(length)
        t.pendown()

pen = turtle.Turtle()
turtle.bgcolor('white')
pen.color('green')
pen.speed(0)
pen.left(90)
pen.penup()
pen.backward(200)
pen.pendown()
Draw_a_tree(pen, 100)
pen.hideturtle()
turtle.done()