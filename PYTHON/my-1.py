'''
from turtle import*
bgcolor("white")
speed(0)
pencolor("black")
from sketchpy import canvas
x = (canvas.trace_from_image
    ("passpord 4to.jpg",save = False,
     scale = 0.75))
up()
goto(-250,-250)
down()
style = ("andalus",50,"bold")
write("AASHIK",
      font=style)
x.draw()
'''

from sketchpy import canvas
from turtle import *

# Sketchpy image trace
x = canvas.trace_from_image("passpord 4to.jpg", save=False, scale=0.75)
x.draw()

# Turtle settings
bgcolor("white")
speed(0)
pencolor("black")

# Move and write text
up()
goto(-250, -250)
down()
style = ("andalus", 50, "bold")
write("AASHIK", font=style)
done()
