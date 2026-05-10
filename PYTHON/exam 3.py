'''
def factorial(n):
    if n == 0 or n == 1:
        return 1
    
    return n * factorial(n - 1)
    
print(factorial(5))  # Output: 120
print(factorial(0))  # Output: 1
print(factorial(1))  # Output: 1
print(factorial(10)) # Output: 3628800
print(factorial(20)) # Output: 2432902008176640000
print(factorial(50)) # Output: 30414093201713378043612608166064768844377641568960512000000000000

'''
'''
for i in range(1,5):
    for j in range(i):
        print(j+1, end=" ")
    print()
'''
'''
for i in range(1,5):
    for j in range(1,i+1):
        print(j, end=" ")
    print()
'''
'''
for i in range(5):
    for j in range(i+1):
        print("*", end=" ")
    
    print()

'''
'''
for i in range(5,0,-1):
    for j in range(i):
        print("*", end=" ")
    
    print( )

'''
'''
for i in range(5,0,-1):
    print(" "*(5-i), end="")
    for j in range(i):
        print("*", end=" ")
    print()
'''
'''
for i in range(5):
    print(" "*(5-i), end="")
    for j in range(i+1):
        print("*", end=" ")
    print()
'''
'''
for i in range(5):
    print(" "*(5-i), end="")
    for j in range(2*i+1):
        print("*", end="")
    print()
'''
'''
# Function to count vowels
def count_vowels(input_string):
    vowels = "aeiou"             # List of vowels
    count = 0                     # Initialize count
    # Convert string to lowercase
    normalized_string = input_string.lower()
    
    # Loop through each character
    for char in normalized_string:
        # Check if the character is a vowel
        if char in vowels:
            count += 1
    
    return count                  # Return the total count

# --- Main part of the script ---
my_text = "Hello World! This is a test."
vowel_count = count_vowels(my_text)
print(f"The text is: '{my_text}'")
print(f"Number of vowels: {vowel_count}")

'''
'''
# Student data
student_data = [
    ('Alice', 1023, 3.85),
    ('Bob', 1024, 3.5),
    ('Charlie', 1025, 4.0)
]

print(f"{'Student Name':<15} | {'ID No.':^8} | {'GPA':>6}")
print("-"*35)

for i in student_data:
    name, id, gpa = i
    print(f"{name:<15} | {id:^8} | {gpa:>6.1f}")
'''
'''
for i in range(4):
    print(" "*(4-i), end="")
    for i in range(2*i+1):
        print("*", end="")
    
    print()

'''
'''
import turtle
import math

def draw_a_triangle(x, y, size, depth, t):

    if depth == 0:
        t.penup()
        t.goto(x, y)
        t.pendown()
        for i in range(3):
            t.forward(size)
            t.left(120)

    else:
        new_size = size/2
        h = new_size*math.sin(math.radians(60))
        draw_a_triangle(x, y , new_size, depth - 1, t)
        draw_a_triangle(x+new_size, y, new_size, depth -1, t)
        draw_a_triangle(x+new_size/2, y + h, new_size, depth -1, t)

pen = turtle.Turtle()
turtle.bgcolor("white")
pen.speed(0)
pen.color("red")
draw_a_triangle(-200, -150, 400, 4, pen)
pen.hideturtle()
turtle.done()

'''

import pygame

BLACK = (0, 0, 0)
pygame.init()
screen = pygame.display.set_mode((600, 400))
rect_x = 0
rect_y = 0
rect_w = 70
rect_h = 30
rect = pygame.Rect(rect_x, rect_y, rect_w, rect_h)
clock = pygame.time.Clock()
FPS = 60
speed_x = 1
speed_y = 1


running = True
while running:
    screen.fill(BLACK)
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            running = False
    if rect.x + rect_w > 600:
        speed_x = -1 * speed_x
    if rect.x < 0:
        speed_x = -1 * speed_x
    if rect.y + rect_h > 400:
        speed_y = -1 * speed_y
    if rect.y < 0:
        speed_y = -1 * speed_y

    rect.x = rect.x + speed_x
    rect.y = rect.y + speed_y
    pygame.draw.rect(screen, (255, 0, 0), rect, 0)



    pygame.display.update()
    clock.tick(FPS)

pygame.quit()