
import turtle
import time

pen = turtle.Turtle()
pen.color('black', 'red')  # pen color & fill color
pen.speed(0)

'''
pen.forward(100)
time.sleep(1)
pen.right(90)
time.sleep(1)
pen.forward(200)
time.sleep(1)
pen.left(90)
time.sleep(1)
pen.forward(100)
time.sleep(0.5)
pen.left(45)
time.sleep(0.5)
pen.forward(100)
'''
'''
for i in range(6):  
    pen.forward(100)
    pen.right(60)

time.sleep(1)
pen.left(120)
time.sleep(1)
pen.forward(100)

for i in range(6): 
    pen.backward(100)
    pen.right(60)
'''
'''
time.sleep(1)
pen.goto(0,300)
print(pen.pos()) 

time.sleep(1)
pen.setpos(-130,0)  # goto() & setpos() are same
print(pen.pos())

time.sleep(1)
pen.setpos(0,0)
print(pen.pos())     #📊 Position values பார்க்கணும்னா print() தேவை.
'''
'''
time.sleep(1)
pen.setx(200)  # x axis மட்டும் 200 ஆகும்

time.sleep(1)
pen.sety(100) # y axis மட்டும் 100 ஆகும்

time.sleep(1)
pen.setx(0)  # x axis மட்டும் 0 ஆகும்

time.sleep(1)
pen.sety(0) # y axis மட்டும் 0 ஆகும்
'''
'''
time.sleep(1)
pen.setheading(90) # 0 - East, 90 - North, 180 - West, 270 - South

time.sleep(1)
pen.forward(300) 

time.sleep(1)
pen.setheading(0)  # East

time.sleep(1)
pen.forward(300)

time.sleep(1)
pen.setheading(270) # South

time.sleep(1)
pen.forward(300)

time.sleep(1)
pen.setheading(180)  # West

time.sleep(1)
pen.forward(300) 
'''

'''
time.sleep(1)
pen.goto(-250,0)

time.sleep(1)
pen.home()  # (0,0) & heading 0 ஆகும்

time.sleep(1)
pen.goto(250,0)

time.sleep(1)
pen.home()

time.sleep(1)
pen.goto(0,250)

time.sleep(1)
pen.goto(0,-250)

time.sleep(1)
pen.circle(250)  # radius 250 ஆகும்

time.sleep(1)
pen.home()
'''
'''
pen.setx(250)

time.sleep(1)
pen.dot(50, "red")  # dot size 50 & color red

time.sleep(1)
pen.goto(-250,0)

time.sleep(1)
pen.dot(25, "blue")  # dot size 25 & color blue

time.sleep(1)
pen.home()

time.sleep(1)
pen.sety(250)

time.sleep(1)
pen.dot(75, "green")  # dot size 75 & color green

time.sleep(1)
pen.goto(0,-250)    

time.sleep(1)
pen.dot(100, "yellow")  # dot size 100 & color yellow

time.sleep(1)
pen.circle(250)

time.sleep(1)
pen.home()  

time.sleep(1)
pen.dot(200, "black")  # dot size 200 & color black
'''
'''
for i in range(4):
    time.sleep(1)
    pen.forward(200)
    time.sleep(1)
    pen.stamp()  # current position & heading ல் ஒரு copy வச்சிடும்
    time.sleep(1)
    pen.right(90)
'''
'''
for i in range(6):
    stamp_no = pen.stamp()
    pen.forward(100)
    pen.right(60)
    
time.sleep(1)
pen.clearstamps()  # all stamps will be cleared or clearstamp(stamp_no) ====> particular stamp will be cleared
'''

'''
stamp_no_list = []
for i in range(6):
    stamp_no = pen.stamp()
    stamp_no_list.append(stamp_no)    # stamp number களை ஒரு list ல் சேமிக்கலாம்
    print(stamp_no_list)              # print the stamp number list
    pen.forward(100)
    pen.right(60)

for i in range(6):
    time.sleep(1)
    pen.clearstamp(stamp_no_list[i])  # particular stamp will be cleared    
'''
'''
for i in range(8):     #  _
    pen.stamp()        # 1 |
    pen.forward(100)   # 1 |- total 3
    pen.right(45)      # 1_|

for i in range(24):                       # use 24 to clear all stamps one by one    /   8x3 = 24
    time.sleep(0.5)
    pen.undo()                            # last action will be undone
'''
'''
pen.goto(0,100)
print(f"x: {pen.xcor()}, y: {pen.ycor()}") # x & y coordinates will be printed  # output: x: 0.0, y: 100.0

pen.goto(100,0)
print(f"x: {pen.xcor()}, y: {pen.ycor()}") # x & y coordinates will be printed  # output: x: 100.0, y: 0.0
'''
'''
for i in range(12):
    pen.forward(100)
    pen.right(30)
    time.sleep(0.5)
    print(f"x: {pen.xcor()}, y: {pen.ycor()}") # x & y coordinates will be printed  
'''
'''
print(pen.heading()) # current heading will be printed  # output: 0.0
for i in range(4):
    pen.forward(100)
    pen.right(90)
    print(pen.heading()) # current heading will be printed  # output: 90.0, 180.0, 270.0, 0.0
'''
'''
x,y = pen.position()  # current position will be stored in x & y variables
print(f"x: {x}, y: {y}") # x & y coordinates will be printed  # output: x: 0.0, y: 0.0

pen.goto(180,0)
time.sleep(1)
pen.goto(180,240)
distance = pen.distance(0,0)  # distance from current position to (0,0)
print(f"Distance from (0,0) to (180,240) is: {distance}") # output: Distance from (0,0) to (180,240) is: 300.0
'''
'''
pen.fd(150)
time.sleep(1)
pen.left(90)

pen.up() # Turtle move during pen-up → line வராது

pen.fd(150)
time.sleep(1)
pen.left(90)

pen.down() # Turtle move during pen-down → line வரும்

pen.fd(150)
time.sleep(1)
pen.left(90)

pen.up()

pen.fd(150)
time.sleep(1)
pen.left(90)
'''
'''
pen.turtlesize(3,3,3)  # stretch_wid, stretch_len, outline
pen.pensize(5)  # pen size 5

for i in range(6):
    pen.forward(100)
    pen.right(60)
    time.sleep(1)
'''
'''
pen.turtlesize(10,10,10)  # stretch_wid, stretch_len, outline
pen.color('red', 'green')  # pen color & fill color
pen.pensize(5)  # pen size 5        

for i in range(6):
    pen.forward(100)
    pen.right(60)
    time.sleep(1)
'''
'''
pen.up()   # The turtle moves without drawing
pen.goto(0,150)
pen.down() # The turtle will draw again when moving
pen.pensize(3)
pen.color('red', 'green')  # pen color & fill color
pen.turtlesize(5)

pen.shape('turtle')  # turtle, arrow, circle, square, triangle, classic

for i in range(4):
    if i ==2:
        pen.shape('circle')
    pen.forward(300)
    pen.right(90)
    time.sleep(1)
'''
pen.shapesize(5)
turtle.done()
'''
for i in range(5):
    print(" "*(5-i), end="")
    for j in range(i+1):
        print("* ", end="")
    print()
'''
'''
import turtle
import math

def draw_triangles(x, y, size, depth, pen):
    if depth == 0:
        pen.penup()
        pen.goto(x, y)
        pen.pendown()
        for i in range(3):
            pen.forward(size)
            pen.left(120)
    else:
        new_size = size / 2
        h = new_size * math.sin(math.radians(60))
        draw_triangles(x, y, new_size, depth - 1, pen)
        draw_triangles(x + new_size, y, new_size, depth - 1, pen)
        draw_triangles(x + new_size / 2, y + h, new_size, depth - 1, pen)

# ---- Main ----
pen = turtle.Turtle()
pen.speed(0)
draw_triangles(-200, -150, 400, 4, pen)
turtle.done()
'''

'''
import turtle

def draw_tree(length, tur):
    if length < 10:
        return
    tur.forward(length)
    tur.left(25)
    draw_tree(length - 15, tur)
    tur.right(50)
    draw_tree(length - 15, tur)
    tur.left(25)
    tur.backward(length)

screen = turtle.Screen()
t = turtle.Turtle()
t.color("red")
t.speed(0)
t.width(2)

t.left(90)
t.penup()
t.backward(200)
t.pendown()

draw_tree(100, t)
t.hideturtle()
screen.exitonclick()
'''
'''
import pygame

# --- Setup ---
BLACK = (0, 0, 0)
RED = (255, 0, 0)

pygame.init()
screen = pygame.display.set_mode((600, 400))
pygame.display.set_caption("Moving Rectangle")

# --- Rectangle Setup ---
rect_x = 0
rect_y = 0
rect_w = 50
rect_h = 30
rect = pygame.Rect(rect_x, rect_y, rect_w, rect_h)

# --- Clock and FPS ---
clock = pygame.time.Clock()
FPS = 60

# --- Speed ---
speed_x = 2
speed_y = 1

# --- Main Loop ---
running = True
while running:
    screen.fill(BLACK)
    
    # Event handling
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            running = False

    # Move rectangle
    rect.x += speed_x
    rect.y += speed_y

    # Bounce when hitting window borders
    if rect.x + rect_w > 600 or rect.x < 0:
        speed_x = -speed_x
    if rect.y + rect_h > 400 or rect.y < 0:
        speed_y = -speed_y

    # Draw rectangle
    pygame.draw.rect(screen, RED, rect)

    # Update display
    pygame.display.flip()

    # Limit FPS
    clock.tick(FPS)

pygame.quit()
'''

for i in range(5):
    print()
    for j in range(i+1):
        print("* ", end="")


#                                                  ------------- LIST --------------
'''
nums = [2, 3, 5, 7, 9]
print(nums[2])
print(nums[-1])
nums.append(112)
print(nums)
nums.pop(5)
print(nums)
nums[2] = -1
print(nums)
'''
#                                                 -------------- TUPLE -------------
'''
nums = (2, 3, 5, 7, 9)
print(nums[2])
print(nums[-1])
nums.append(112)   # error ====> not add values in tuple 
print(nums)
nums[2] = -1       # error ====> not change values in tuple 
print(nums) 
nums.pop(5)         # error ====> not remove values in tuple 
print(nums)       
'''

#                    ----------- RETURN ----------
'''
def sum(n1 , n2):
    s  = n1 + n2
    return s

result = sum(23, 45)
print(f"Summation of Your Number: {result}")
'''
'''
def circul_data(r):
    c = 2*math.pi*r
    A = math.pi*r*r

    return c,A

import math
cir , Area = circul_data(10)
print(f"===> Circumference = {cir}")
print(f"===> Area          = {Area}")

t  = circul_data(10)
print(t)

print(f"===> Circumference = {t[0]}")
print(f"===> Area          = {t[1]}")
'''
#               ------------- ERROR HANDLING -------------
'''
result = 34 + "three"
print(result)      # ===========> error we con't add int and str   "ValueError: could not convert string to float"
'''

'''
num = float(input("Enter Tour Number: ")) # ===== ithu puriyale 
print(num)
'''
'''
numbers = [34, 7, 9]
print(numbers[5])  # =======> IndexError: list index out of range 
'''
'''
result = 4/0
print(result)  # ====> ZeroDivisionError: division by zero
'''

'''
print("Enter Your 5 Numbers")
count = 0
while True:
    try:
        num = float(input("Enter Tour Number: "))   
        print(num)
    
    except:
        print("Wrong format , Try Again")
    count = count +1                                   # ==========> count always correct and wrong input
    
    if count == 5:
        break
'''
'''
print("Enter Your 5 Numbers")
count = 0
while True:
    try:
        num = float(input("Enter Tour Number: "))
        print(num)
        count = count +1                               # ==========> count only correct input
    except:
        print("Wrong format , Try Again")
    
    if count == 5:
        break
'''

#                                    -------------- FILE HANDLING ---------------


# r ==> read file 
# w ==> write in file
# a ==> apperend (add some thing on file)

f =  open("Hello.txt",'w')
f.write("hello this is the line\n")
f.write("this is another line\n")
f.write("this is next line\n")
f.write("this line is a very long line")

f.close()

'''
try:
    f = open("Hello.txt",'r')
    content = f.read()
    print(content)

    f.close()

except:
    print("File Error")
'''

'''
try:
    f = open("Hello.txt",'r')
    line = f.readline()
    while(line):
        print(line)
        line = f.readline()

    f.close()

except:
    print("File Error")
'''
'''
try:
    f = open("Hello.txt", "r")
    line1 = f.readline()
    print(line1)   # prints only the first line
    f.close()

except:
    print("File Error")
'''
'''
try:
    f = open("Hello.txt", "r")
    f.readline()          # skip the 1st line
    second_line = f.readline()  # read the 2nd line
    print(second_line)

except:
    print("File Error")
'''
'''
try:
    f = open("Hello.txt", "r")
    f.readline()          # skip the 1st line
    f.readline()          # skip the 2nd line
    third_line = f.readline()  # read the 3rd line
    print(third_line)

except:
    print("File Error")
'''

'''
try:
    f = open("Hello.txt",'r')
    line = f.readline()
    while(line):
        word = line.split()
        print(word)
        line = f.readline()

    f.close()

except:
    print("File Error")
'''

try:
    f = open("Hello.txt",'r')
    line = f.readline()
    while(line):
        word = line.split()
        print(word)
        print(f"Number of word in line: {len(word)}")
        line = f.readline()

    f.close()

except:
    print("File Error")
