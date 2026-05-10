import turtle

# Turtle instance
robot = turtle.Turtle()
robot.speed(10)  # speed: 1 (slow) to 10 (fast)

# Function to draw a square
def draw_square(length):
    for _ in range(4):
        robot.forward(length)
        robot.right(90)

# Function to draw a star
def draw_star(size):
    for _ in range(5):
        robot.forward(size)
        robot.right(144)

# Function to draw a spiral
def draw_spiral():
    distance = 5
    for _ in range(100):
        robot.forward(distance)
        robot.right(20)
        distance += 2

# Main drawing area
robot.color("blue")
draw_square(100)

robot.penup()
robot.goto(-150, 0)
robot.pendown()
robot.color("red")
draw_star(100)

robot.penup()
robot.goto(150, -150)
robot.pendown()
robot.color("green")
draw_spiral()

# Exit on click
turtle.done()
