
import pygame

pygame.init() # Initialize pygame
screen = pygame.display.set_mode((600, 400)) # Set the window size: width=600, height=400

pygame.display.set_caption("Moving Rectangle") # Set the window title

icon = pygame.image.load('py.jpeg') # Load an icon image
pygame.display.set_icon(icon) # Set the window icon

playerImg = pygame.image.load('spaceship.png') # Load the player image
playerX = 270 # Initial X position of the player
playerY = 300 # Initial Y position of the player

def player():
    screen.blit(playerImg, (playerX, playerY)) # Draw the player image at (x, y)

running = True
while running: # Main loop
    for event in pygame.event.get(): # Get all events
        if event.type == pygame.QUIT: # Check for window close event
            running = False

    # RGB color (red, green, blue)
    screen.fill((0, 0, 0)) # Fill the screen RGB color (0, 255, 255) = cyan
    player() # Draw the player
    pygame.display.update() # Update the display