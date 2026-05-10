
import random

def check_valid__num(num):
    while True:
        try:
            num = float(num)
            if not num.is_integer():
                print("Please enter a whole number only.")
                num = input("Enter Your Number Again: ")
                continue

            num = int(num)
            if not (1 <= num <= 100):
                print("Number must be between 1 and 100.")
                num = input("Enter Your Number Again: ")
                continue
            return num

        except ValueError:
            print("Invalid Input, Please Try Again!")
            num = input("Enter Your Number Again: ")



def high_low_correct_check(num,secret_number):
    while True:
        if num < secret_number:
            print("Your guess is too low.")
            return False

        elif num > secret_number:
            print("Your guess is too high.")
            return False

        else:
            print("Congratulations! You guessed the correct number!")
            return True



def main():
    print("~~ Welcome to the Secret Number Guessing Game! ~~")
    print("I'm thinking of a number between 1 and 100.")
    print()

    while True:
        secret_number = random.randint(1, 100)
        while True:
            num = input("Enter Your Guessed Number between 1 and 100: ")
            num = check_valid__num(num)
            if high_low_correct_check(num,secret_number):
                break

        ch = input("Do you want to play again? [Y/N]: ")
        if ch.lower() != 'y':
            print("-- Thank You --")
            break

main()