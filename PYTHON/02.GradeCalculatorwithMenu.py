
def check_valid_grade(grade):
    while True:
        try:
            grade = float(grade)
            if not grade.is_integer():
                print("please Enter Whole Number only")
                grade = input("Please Enter your grade Again: ")
                continue
            grade = int(grade)

            if not 0 < grade < 100:
                print("Please Enter Your grade between 0 and 100")
                grade = input("Please Enter Your Grade Again: ")
                continue
            return grade

        except ValueError:
            print("Invalid Input, Please Try Again")
            grade = input("Please Enter Your Grade Again: ")


def find_grade(average):
    if average >= 90:
        return "A+"
    elif average >= 80:
        return "A"
    elif average >= 75:
        return "A-"
    elif average >= 70:
        return "B+"
    elif average >= 65:
        return "B"
    elif average >= 60:
        return "B-"
    elif average >= 55:
        return "C+"
    elif average >= 50:
        return "C"
    elif average >= 45:
        return "C-"
    elif average >= 35:
        return "S"
    else:
        return "F"


def display_grade(student_name, marks):
    average = round(sum(marks) / len(marks), 2)
    grade = find_grade(average)
    print(f"{student_name}'s average: {average}")
    print(f"{student_name}'s grade: {grade}")
    print(f"Highest mark: {max(marks)}")
    print(f"Lowest mark: {min(marks)}")


def main():
    marks = []
    while True:
        print("\n------ Welcome to Grade Calculator ------")
        print()
        print("1. Enter Marks")
        print("2. Calculate Grade")
        print("3. Exit")
        print()
        choice = input("Enter your choice (1/2/3): ")

        while choice not in ['1', '2', '3']:
            print("Invalid Choice, Please try again")
            choice = input("Enter Choice ('1' , '2' , '3'): ")
            continue

        print("Your selected choice: ", choice)
        print()

        if choice == '1':
            student_name = input("Enter Student Name: ").upper()
            marks = []
            for i in range(1, 6):
                g = input(f"Enter mark for subject {i}: ")
                valid = check_valid_grade(g)
                marks.append(valid)
            print()   
            print("Marks successfully added")
            print("Your Marks List: ", marks)
            print()
            ch = input("Do you want to calculate your Average and Grade [Y/N]: ").lower()
            if ch == 'y':
                    print()
                    display_grade(student_name,marks)
                    print()

            elif ch == 'n':
                print()
                c = input("Do you want to exit [Y/N]: ").lower()
                if c == 'n':
                    continue
                else:
                    print("---- Thank You ----")
                    break

            else:
                print("Invalid Input, Please Try Again")
                continue


        elif choice == '2':
            if len(marks) < 5:
                print("Please enter all 5 marks first (option 1).")
                continue
            else:
                average = sum(marks) / len(marks)
                grade = find_grade(average)
                print(f"Your average: {average}")
                print(f"Your grade: {grade}")

        elif choice == '3':
            print("---- Thank You ----")
            break

        ch = input("Do you want to calculate for another student? [Y/N]: ")
        if ch.lower() == 'y':
            marks.clear()

        else:
            print("---- Thank You ----")
            break

main()
