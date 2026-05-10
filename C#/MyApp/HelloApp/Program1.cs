/*
using System;

namespace Sample                                             // Added namespace for better organization
{
    class Program                                            // Changed class name to Program for clarity
    {
        public static void Main(string[] args)               // Entry point of the program and main method.  main method ===> used to execute the program.
        {
            Console.WriteLine("Hello World!");               // Print Hello World to the console
            Console.WriteLine("I am learning C#");
            Console.WriteLine("This is my first program."); 
            Console.WriteLine(3+3);                          // Print the sum of 3 + 3 to the console  


            Console.Write("Hello ");                         // Print Hello without a new line 
            Console.Write("World!");                         // Print World! on the same line
            // Here Hello World! will be printed on the same line because Console.Write does not add a new line after printing.

            Console.ReadLine();                              // Added to keep the console window open
        }
    }
}
*/

// WriteLine vs Write
// WriteLine: This method prints the specified data to the console followed by a new line.
// Write: This method prints the specified data to the console without adding a new line at the end.


/*
namespace Result                                // Added namespace for better organization
{
    class Program                               // Changed class name to Program for clarity
    {
        static void Main(string[] args)         // Entry point of the program and main method.  main method ===> used to execute the program.
        {
            System.Console.WriteLine("Hello World!");  // Print Hello World to the console
            System.Console.ReadLine();                 // Added to keep the console window open
        }
    }
}
*/


//                                         -------------- COMMENTS --------------

// TwoType of Comments in C#
//              1. Single-line comments: These comments start with // and continue to the end of the line.
//              2. Multi-line comments: These comments start with /* and end with */. They can span multiple lines.



//                                        ------------ VARIABLES IN C# ------------

/*

int : This data type is used to store integer values (whole numbers) without decimal points. It can hold both positive and negative values. 
      Example: int age = 25;

double : This data type is used to store floating-point numbers (numbers with decimal points). It can hold a wide range of values, including very large and very small numbers. 
         Example: double price = 19.99;

char : This data type is used to store a single character. It is enclosed in single quotes (' '). 
       Example: char grade = 'A';
                char a = "A";   // ❌ ERROR  // not use doubel cotation


string : This data type is used to store a sequence of characters (text). It is enclosed in double quotes (" "). 
         Example: string name = "John Doe";

bool : This data type is used to store boolean values, which can be either true or false. 
       Example: bool isStudent = true;

float : This data type is used to store floating-point numbers with single precision. It is less precise than double and is often used when memory conservation is important. A float value must be suffixed with an 'f' or 'F'. 
        Example: float temperature = 36.6f;

int i;
i = 10;  only whole numbers and start with lowercase letter not with number

float f;
f = 5.5f;

double d;
d = 19.99;

decimal dec = 19.99m;  // 'm' suffix indicates a decimal literal

string str;
str = "Hello";

char c;
c = 'A';

bool b;
b = true;

*/

/*

using System;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            float f = 5.5f;
            double d = 19.99;
            string str = "Hello";
            char c = 'A';
            bool b = true;

            const int j = 0; // Constant variable, value cannot be changed

            Console.WriteLine("Integer: " + i);
            Console.WriteLine("Float: " + f);
            Console.WriteLine("Double: " + d);
            Console.WriteLine("String: " + str);                // using + operator to concatenate string and variable
            Console.WriteLine("Character: " + c);
            Console.WriteLine("Boolean: " + b);

            Console.WriteLine("Constant Integer: " + j);


            string firstName = "Mohammad ";
            string lastName = "Aashik";
            string fullName = firstName  + lastName;      // Concatenate first name and last name with a space in between
            Console.WriteLine("Full Name: " + fullName);       // here + operator is used to concatenate  2 strings

            int a;
            a = 5;

            int e;
            e = 10;
            Console.WriteLine(e + a); // here + operator is used to add 2 integers

            int x=3 , y = 4;           // Multiple variable declaration in a single line
            Console.WriteLine(x + y);


            int l , n , m;            // Multiple variable declaration in a single line
            l = 5;
            n = 3;
            m = 4;
            Console.WriteLine(l + n + m);



            Console.ReadLine(); // Keep the console window open
        }
    }
}

*/

//                                    ------------ IDENTIFIERS IN C# ------------

// Identifiers are names used to identify variables, methods, classes, and other entities in C#. They must follow certain rules:
// 1. An identifier must start with a letter (A-Z, a-z) or an underscore (_).
// 2. Subsequent characters can be letters, digits (0-9), or underscores    
// 3. Identifiers cannot be the same as C# reserved keywords (like int, class, void, etc.).
// 4. Identifiers are case-sensitive (e.g., myVariable and MyVariable are different).
// 5. Identifiers should not contain spaces or special characters (like @, #, $, %, etc.).
// 6. It is a good practice to use meaningful names for identifiers to improve code readability.
/*
✅ Allowed
letters (a–z, A–Z)
numbers (0–9) (but not first)
underscore _
sample:
        int age1;
        int _value;
        int total_marks;
*/


//                                   --------------- C# DATA TYPES ---------------

// A data type specifies the type of data that a variable can store such as integer, floating-point numbers, characters, strings, and boolean values.

// They are 3 types of data types in C#:
//      1. Value Types: These types store data directly. Examples include int, float, double, char, and bool.

//            #  Value types are further divided into:
//                      a. Predefined Value Types: These are built-in types provided by C#. 
//                              Examples include int, float, double, char, and bool.

//                      b. User-defined Value Types: These types are defined by the user using structures (struct) or enumerations (enum).
//                              Examples include struct Point { public int x; public int y; } and enum Days { Sunday, Monday, Tuesday }.


//      2. Reference Types: These types store references to the actual data. Examples include string (array of characters), object, arrays, classes, interfaces, and delegates.

//            #  Reference types are further divided into:
//                      a. Predefined Reference Types: These are built-in types provided by C#.
//                              Examples include string, object, and dynamic.

//                      b. User-defined Reference Types: These types are defined by the user using classes (class), interfaces (interface), arrays, and delegates.
//                              Examples include class Person { public string Name; public int Age; }, interface IAnimal { void Speak(); }, int[] numbers = new int[5];, and delegate void MyDelegate(string message);  


//      3. Pointer Types: These types store memory addresses of variables. They are used in unsafe code contexts.
//            The pointer types include int*, char*, and void*.
//            Example: unsafe { int a = 10; int* p = &a; Console.WriteLine(*p); }


/*

=======> Range of some common data types in C# <=======
     ______________________________________________________________________________________________
    |Data Type   |   Size (in bytes)  |    Range (in bytes) | Range (in bytes)                     |
    |____________|____________________|____________________________________________________________|
    |  bool      |        1           |   true or false                                            |
    |  byte      |        1           |   0 to 255                                                 |
    |  sbyte     |        1           |   -128 to 127                                              |
    |  short     |        2           |   -32,768 to 32,767                                        |
    |  ushort    |        2           |   0 to 65,535                                              |
    |  int       |        4           |   -2,147,483,648 to 2,147,483,647                          |
    |  uint      |        4           |   0 to 4,294,967,295                                       |
    |  long      |        8           |   -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807  |
    |  ulong     |        8           |   0 to 18,446,744,073,709,551,615                          |
    |  float     |        4           |   -3.4 x 10^38 to +3.4 x 10^38                             |
    |  double    |        8           |   -1.7 x 10^308 to +1.7 x 10^308                           |
    |  decimal   |       16           |   -7.9 x 10^28 to +7.9 x 10^28                             |
    |____________|____________________|____________________________________________________________|

*/

// Example program demonstrating various data types in C#
/*
using System;
namespace DataTypes
{
    class Program
    {
        static void Main()
        {
            Char a = 'a';
            int i = 10;
            short s = 56;
            long l = 56789;
            uint ui = 20;
            ushort us = 21;
            ulong ul = 789456123;
            double d = 5.358674532;
            float f = 3.7330645f;             // suffix 'f' is used to indicate that it's a float literal
            decimal dec = 789.54m;            // suffix 'm' is used to indicate that it's a decimal literal

         // int j = 21474836470;  // ❌ ERROR: Value is too large for int data type So we use long data type and long variable
            long j = 21474836470;

            Console.WriteLine("Char: " + a);
            Console.WriteLine("Integer: " + i);
            Console.WriteLine("Short: " + s);
            Console.WriteLine("Long: " + l);
            Console.WriteLine("Unsigned Integer: " + ui);
            Console.WriteLine("Unsigned Short: " + us);
            Console.WriteLine("Unsigned Long: " + ul);
            Console.WriteLine("Double: " + d);
            Console.WriteLine("Float: " + f);
            Console.WriteLine("Decimal: " + dec);
            Console.WriteLine("Integer: " + j);

            Console.ReadLine(); // Keep the console window open
        }
    }

}

*/

// ====> Null
/*

string a = null;  // Here variable 'a' is assigned a null value, indicating that it does not reference any object or value.
// In C#, null is a special value that represents the absence of a value or an object
Console.WriteLine("Null Value: " + a);

int? b = null;   // Here variable 'b' is a nullable integer assigned a null value
Console.WriteLine("Nullable Integer with Null Value: " + b);

int c = null;   // ❌ ERROR: Cannot assign null to a non-nullable value type
Console.WriteLine("Non-nullable Integer with Null Value: " + c);

*/

// C# supports 9 integral types:
// byte, sbyte, short, ushort, int, uint, long, ulong, nint, char

// C# supports 3 floating-point types:
// float, double, decimal


//                             ---------------- TYPE CASTING IN C# ----------------

// Type casting is the process of converting a variable from one data type to another. In C#, there are two types of type casting:
// 1. Implicit Casting (Automatic Type Conversion): This type of casting is done automatically by the compiler when converting a smaller data type to a larger data type.
//    Example: int to long, float to double   
//    char --> int --> long --> float --> double  

// 2. Explicit Casting (Manual Type Conversion): This type of casting is done manually by the programmer when converting a larger data type to a smaller data type.
//    Example: double to float, long to int
//    double --> float --> long --> int --> char




// =====> 01. Implicit Type Casting Example

/*
using System;

namespace TypeCasting
{
    class Program
    {
        static void Main()
        {
            int i = 100;
            long l = i;               // Implicit casting from int to long
            float f = l;              // Implicit casting from long to float
            double d = f;             // Implicit casting from float to double

            double t = i;             // Implicit casting from int to double


            Console.WriteLine("Integer: " + i);
            Console.WriteLine("Long: " + l);
            Console.WriteLine("Float: " + f);
            Console.WriteLine("Double: " + d);

            Console.WriteLine("Double: " + t);


            Console.ReadLine(); // Keep the console window open
        }
    }
}
*/


// =====> 02. Explicit Type Casting Example

/*
using System;

namespace TypeCasting
{
    class Program
    {
        static void Main()
        {
            double d = 100.5;
            int i = (int)d;           // Explicit casting from double to int
            float f = (float)d;       // Explicit casting from double to float
            long l = (long)d;         // Explicit casting from double to long


            Console.WriteLine("Double: " + d);
            Console.WriteLine("Integer: " + i);   // output = 100  (decimal part will be truncated)
            Console.WriteLine("Float: " + f);
            Console.WriteLine("Long: " + l);

            Console.ReadLine(); // Keep the console window open
        }
    }
}
*/


// =====> 03. Mixed Type Casting Example

/*
using System;

namespace TypeCasting
{
    class Program
    {
        static void Main()
        {
            int i = 50;
            double d = 20.5;

            // Implicit casting from int to double
            double result1 = i + d;  
            
            // Explicit casting from double to int
            int result2 = i + (int)d;     

            Console.WriteLine("Result of Implicit Casting (int + double): " + result1);
            Console.WriteLine("Result of Explicit Casting (int + (int)double): " + result2);

            Console.ReadLine(); // Keep the console window open
        }
    }
}
*/

// =====> 04. Type conversion using Convert class

// Convert.ToBoolean()  ----------> Converts a specified value to a Boolean value.
// Convert.ToByte()     ----------> Converts a specified value to an 8-bit unsigned integer
// Convert.ToChar()     ----------> Converts a specified value to a Unicode character.
// Convert.ToDateTime() ----------> Converts a specified value to a DateTime value.
// Convert.ToDecimal()  ----------> Converts a specified value to a decimal number.
// Convert.ToDouble()   ----------> Converts a specified value to a double-precision floating-point number.
// Convert.ToInt16()   ----------> Converts a specified value to a 16-bit signed integer.
// Convert.ToInt32()   ----------> Converts a specified value to a 32-bit signed integer.
// Convert.ToInt64()   ----------> Converts a specified value to a 64-bit signed integer.

/*
using System;

namespace ConvertClass
{
    class Program
    {
        static void Main()
        {
            // Convert.ToBoolean  ----> string to boolean
            string strBool = "true";
            bool b = Convert.ToBoolean(strBool);
            Console.WriteLine("Boolean: " + b);

            // Convert.ToByte ----> string to byte
            string strByte = "255";
            byte bt = Convert.ToByte(strByte);
            Console.WriteLine("Byte: " + bt);

            // Convert.ToChar ----> string to char
            string strChar = "A";
            char ch = Convert.ToChar(strChar);
            Console.WriteLine("Char: " + ch);

            // Convert.ToDateTime ----> string to DateTime
            string strDate = "2024-12-25";
            DateTime date = Convert.ToDateTime(strDate);
            Console.WriteLine("DateTime: " + date);

            // Convert.ToDecimal ----> string to decimal
            string strDecimal = "1234.56";
            decimal dec = Convert.ToDecimal(strDecimal);
            Console.WriteLine("Decimal: " + dec);

            // Convert.ToDouble ----> string to double
            string strDouble = "45.67"; 
            double dbl = Convert.ToDouble(strDouble);
            Console.WriteLine("Double: " + dbl);

            // Convert.ToInt16 ----> string to Int16  (Int16 is short)
            string strInt16 = "1000";
            short s = Convert.ToInt16(strInt16);  // or short s = short.Parse(strInt16);
            Console.WriteLine("Int16: " + s);

            // Convert.ToInt32 ----> string to Int32  (Int32 is int)
            string strInt32 = "50000";
            int i = Convert.ToInt32(strInt32);
            Console.WriteLine("Int32: " + i);

            // Convert.ToInt64 ----> string to Int64  (Int64 is long)
            string strInt64 = "123456789";
            long l = Convert.ToInt64(strInt64);  // or long l = long.Parse(strInt64);
            Console.WriteLine("Int64: " + l);

            // Convert.ToInt32 ----> double to int
            double numDouble = 9.99;
            int numInt = Convert.ToInt32(numDouble);  // decimal part will be rounded
            Console.WriteLine("Converted Int from Double: " + numInt);

            Console.ReadLine();
        }
    }
}
*/



//                                          ---------------- USER INPUT ----------------

// Getting user input in C# we use several methods provided by the Console class.

/*
 1. Console.ReadLine(): This method reads a line of text from the console until the Enter key is pressed. It returns the input as a string.
    Example: string name = Console.ReadLine(); ====> only return string value

 2. Console.Read(): This method reads the next character from the console input stream. It returns the ASCII value of the character as an integer.
    Example: int asciiValue = Console.Read(); ====> return int value (ASCII value of character)

 3. Console.ReadKey(): This method reads a single key press from the console. It returns a ConsoleKeyInfo object that contains information about the pressed key.
    Example: ConsoleKeyInfo keyInfo = Console.ReadKey(); ====> return ConsoleKeyInfo object
*/

/*
using System;
namespace UserInput
{
    class Program
    {
        static void Main()
        {
            // Using Console.ReadLine() to get user input as a string
            Console.Write("Enter your name: ");            // we can use Console.Write() to print without a new line
            string name = Console.ReadLine() ?? "";        // only return string value
            Console.WriteLine("Hello, " + name + "!");


            Console.Write("Enter your age: ");
            int ageInput = Convert.ToInt32(Console.ReadLine() ?? "0");   // only return string value  but we Convert string to int
            Console.WriteLine($"You are {ageInput} years old.");

            // Using Console.Read() to get user input as an integer (ASCII value of character)
            // Note: Console.Read() reads a single character and returns its ASCII value
            // So, if the user inputs '2', it will return 50 (ASCII value of '2')
            // not the integer 2
            Console.Write("Enter your age: ");
            int age2 = Console.Read();                           // return int value (ASCII value of character)
            Console.WriteLine($"Your age is: {age2}");   // we can get ASCII value of character is 50 for '2'

            // Using Console.ReadKey() to get user input as a ConsoleKeyInfo object
            Console.Write("Press any key to continue...: ");
            ConsoleKeyInfo keyInfo = Console.ReadKey();         // return ConsoleKeyInfo object
            Console.WriteLine($"\nYou pressed: {keyInfo.KeyChar}"); // Display the pressed key character    

            Console.ReadLine(); // Keep the console window open
        }
    }
}
*/


// ========================================= EXERCISE - PROJECT 01 =========================================
/*
using System;
namespace ProjectOne
{
    class Program
    {
        static void Main()
        {
            Console.Write("Entr Your First Name: ");
            string firstname = Console.ReadLine()?? "";

            Console.Write("Enter Your Last Name: ");
            string lastname = Console.ReadLine() ?? "";

            Console.Write("Enter Your Age: ");
            int age = Convert.ToInt32(Console.ReadLine() ?? "");

            Console.Write("Enter Your Weight: ");
            double weight = Convert.ToDouble(Console.ReadLine() ?? "");

            Console.Write("Enter Your Country: ");
            string country = Console.ReadLine() ?? ""; 

            Console.WriteLine("\n----- Your Details -----");

            Console.WriteLine($"Your First Name is: {firstname}");
            Console.WriteLine($"Your Last Name is: {lastname}");
            Console.WriteLine($"Full Name is: {firstname} {lastname}");
            Console.WriteLine($"Your Age is: {age}"); 
            Console.WriteLine($"Your Weight is: {weight}kg");
            Console.WriteLine($"Your Country is: {country}");

            Console.ReadLine(); // Keep the console window open

        }
    }
}
*/

//                                        ----------------- C# Operators -----------------
/*
==> Types of Operators in C#:
     
1. Arithmetic Operators: These operators are used to perform mathematical operations such as addition, subtraction, multiplication, division, and modulus.
   Examples: + (Addition), - (Subtraction), * (Multiplication), / (Division), % (Modulus - remainder), ++ (Increment), -- (Decrement)

2. Assignment Operators: These operators are used to assign values to variables.
   Examples: = (Assignment), += (Addition Assignment), -= (Subtraction Assignment), *= (Multiplication Assignment), 
   /= (Division Assignment), %= (Modulus Assignment), <<= (Left Shift Assignment), >>= (Right Shift Assignment), &= (Bitwise AND Assignment),
    |= (Bitwise OR Assignment), ^= (Bitwise XOR Assignment), ++= (Increment Assignment), --= (Decrement Assignment)

3. Comparison Operators: These operators are used to compare two values and return a boolean result (true or false).
   Examples: == (Equal), != (Not Equal), > (Greater Than), < (Less Than), >= (Greater Than or Equal), <= (Less Than or Equal)

4. Logical Operators: These operators are used to perform logical operations on boolean values.
   Examples: && (Logical AND), || (Logical OR), ! (Logical NOT)

5. Bitwise Operators: These operators are used to perform bit-level operations on integer types.
   Examples: & (Bitwise AND), | (Bitwise OR), ^ (Bitwise XOR), ~ (Bitwise NOT), << (Left Shift), >> (Right Shift)

6. Unary Operators: These operators operate on a single operand to produce a new value.
   Examples: + (Unary Plus), - (Unary Minus), ++ (Increment), -- (Decrement), ! (Logical NOT)

7. Ternary Operator: This operator is a shorthand for an if-else statement and takes three operands.
   Example: condition ? value_if_true : value_if_false (also known as conditional operator)

8. Null-coalescing Operator: This operator is used to define a default value for nullable types.
    Example: ?? (null-coalescing operator)

*/

// Example program demonstrating various operators in C#
/*
using System;
namespace OperatorsDemo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine();
            Console.WriteLine("========= C# Operators Demonstration =========\n");

            Console.Write("Enter First Number: ");
            int a = Convert.ToInt32(Console.ReadLine() ?? "0");
            Console.WriteLine();
            Console.Write("Enter Second Number: ");
            int b = Convert.ToInt32(Console.ReadLine() ?? "0");
            Console.WriteLine();

            // Arithmetic Operators
            Console.WriteLine("----------- Arithmetic Operators -----------");
            Console.WriteLine();
            Console.WriteLine($"Addition: {a} + {b} = {a + b}");
            Console.WriteLine($"Subtraction: {a} - {b} = {a - b}");
            Console.WriteLine($"Multiplication: {a} * {b} = {a * b}");
            Console.WriteLine($"Division: {a} / {b} = {a / b}");
            Console.WriteLine($"Modulus: {a} % {b} = {a % b}");
            Console.WriteLine($"Increment: ++{a} = {++a}");             // pre-increment(++a  ⇒  a = a + 1)
            Console.WriteLine($"Decrement: --{b} = {--b}");             // pre-decrement(--b  ⇒  b = b - 1)
            Console.WriteLine($"Post-increment: {a}++ = {a++}");        // post-increment(a++  ⇒  a = a + 1)
            Console.WriteLine($"Post-decrement: {b}-- = {b--}");        // post-decrement(b--  ⇒  b = b - 1)
            Console.WriteLine();

            // Assignment Operators
            int c = 5;
            Console.WriteLine("----------- Assignment Operators -----------");
            Console.WriteLine();
            Console.WriteLine($"Initial value: c = {c}");
            c += 2; // c = c + 2
            Console.WriteLine($"After c += 2: c = {c}");
            c *= 3; // c = c * 3
            Console.WriteLine($"After c *= 3: c = {c}");
            c -= 4; // c = c - 4
            Console.WriteLine($"After c -= 4: c = {c}");
            c /= 2; // c = c / 2
            Console.WriteLine($"After c /= 2: c = {c}");
            c %= 3; // c = c % 3
            Console.WriteLine($"After c %= 3: c = {c}");   
            Console.WriteLine();
            
            // Bitwise Assignment Operators
            Console.WriteLine("------- Bitwise Assignment Operators -------");
            Console.WriteLine();
            Console.WriteLine($"Current value: c = {c}");
            Console.WriteLine();
            c |= 2; // c = c | 2
            Console.WriteLine($"After c |= 2: c = {c}");   // Bitwise OR assignment
            c &= 1; // c = c & 1
            Console.WriteLine($"After c &= 1: c = {c}");   // Bitwise AND assignment
            c ^= 3; // c = c ^ 3
            Console.WriteLine($"After c ^= 3: c = {c}");   // Bitwise XOR assignment 
            c <<= 1; // c = c << 1
            Console.WriteLine($"After c <<= 1: c = {c}");  // Left shift assignment 
            c >>= 1; // c = c >> 1
            Console.WriteLine($"After c >>= 1: c = {c}");  // Right shift assignment
            Console.WriteLine();

            // Comparison Operators
            Console.WriteLine("----------- Comparison Operators -----------");
            Console.WriteLine();   
            Console.WriteLine($"a = {a}, b = {b}");
            Console.WriteLine();
            Console.WriteLine($"{a} == {b}: {a == b}");
            Console.WriteLine($"{a} != {b}: {a != b}");
            Console.WriteLine($"{a} > {b}: {a > b}");
            Console.WriteLine($"{a} < {b}: {a < b}");
            Console.WriteLine($"{a} >= {b}: {a >= b}");
            Console.WriteLine($"{a} <= {b}: {a <= b}");
            Console.WriteLine();

            // Ternary Operator
            Console.WriteLine("----------- Ternary Operator -----------");
            Console.WriteLine();
            int max ;
            if(a > b)
            {
                max = a;                              // or we can use ternary operator  max = (a > b) ? a : b;
            }
            else
            {
                max = b;
            }
            Console.WriteLine($"Max of {a} and {b} is: {max}");
            Console.WriteLine();


            // Logical Operators
            bool x = true;
            bool y = false;
            Console.WriteLine("----------- Logical Operators -----------");

            Console.WriteLine($"{x} && {y}: {x && y}");  // Logical AND
            Console.WriteLine($"{x} || {y}: {x || y}");  // Logical OR
            Console.WriteLine($"!{x}: {!x}");
            Console.WriteLine();

            Console.Write("Enter a number for logical operations: ");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            // Logical AND (&&) Operatot
            Console.WriteLine("----------- Logical AND Operator -----------");
            Console.WriteLine();
            Console.WriteLine(z > 3 && z < 10); // ==> and opretor (true)
            Console.WriteLine(z > 3 && z > 10); // false
            Console.WriteLine(); 

            // Logical OR (||) Operator
            Console.WriteLine("----------- Logical OR Operator -----------");
            Console.WriteLine();
            Console.WriteLine(z < 3 || z < 10); // ==> or operator (true)
            Console.WriteLine(z < 3 || z > 10); // false
            Console.WriteLine();

            // Logical NOT (!) Operator
            Console.WriteLine("----------- Logical NOT Operator -----------");
            Console.WriteLine();
            Console.WriteLine(!(z > 3)); // false   
            Console.WriteLine(!(z < 3)); // true
            Console.WriteLine();

            // Combined Logical Operators
            Console.WriteLine("----------- Combined Logical Operators -----------");
            Console.WriteLine();
            Console.WriteLine(!(z > 3 && z < 10)); // false
            Console.WriteLine(!(z < 3 || z > 10)); // true
            Console.WriteLine();


            

            Console.ReadLine(); // Keep the console window open

        }
    }
}
*/

// ========================================= EXERCISE - PROJECT 02 (Calculator) =========================================
/*
using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("========= Simple Calculator =========\n");
                Console.WriteLine("Select an operation:\n");
                Console.WriteLine("1. Addition (+)");
                Console.WriteLine("2. Subtraction (-)");
                Console.WriteLine("3. Multiplication (*)");
                Console.WriteLine("4. Division (/)");
                Console.WriteLine("5. Modulus (%)\n");

                Console.Write("Enter Choice (+, -, *, /, %): ");
                string choice = Console.ReadLine() ?? "";
                Console.WriteLine();

                if (choice != "+" && choice != "-" && choice != "*" && choice != "/" && choice != "%")
                {
                    Console.WriteLine("Invalid choice. Please try again.\n");
                    continue; // go back to menu
                }

                Console.Write("Enter First Number: ");
                double num1 = Convert.ToDouble(Console.ReadLine() ?? "0");

                Console.Write("Enter Second Number: ");
                double num2 = Convert.ToDouble(Console.ReadLine() ?? "0");

                if (choice == "+")
                    Console.WriteLine($"Addition: {num1 + num2}");
                else if (choice == "-")
                    Console.WriteLine($"Subtraction: {num1 - num2}");
                else if (choice == "*")
                    Console.WriteLine($"Multiplication: {num1 * num2}");
                else if (choice == "/")
                {
                    if (num2 == 0)
                        Console.WriteLine("Division by zero not allowed");
                    else
                        Console.WriteLine($"Division: {num1 / num2}");
                }
                else if (choice == "%")
                {
                    if (num2 == 0)
                        Console.WriteLine("Modulus by zero not allowed");
                    else
                        Console.WriteLine($"Modulus: {num1 % num2}");
                }

                break; // exit calculator
            }
        }
    }
}
*/


//                                            ------------------- C# Math Class -------------------

// Math class methods:
/*
1. Math.Abs(): Returns the absolute value of a number.
        EXAMPLE: int absValue = Math.Abs(-10);  // absValue will be 10

2. Math.Ceiling(): Rounds a number up to the nearest integer.
        EXAMPLE: double ceilValue = Math.Ceiling(4.3);  // ceilValue will be 5.0

3. Math.Floor(): Rounds a number down to the nearest integer.
        EXAMPLE: double floorValue = Math.Floor(4.7);  // floorValue will be 4.0

4. Math.Round(): Rounds a number to the nearest integer or specified number of decimal places.
        EXAMPLE: double roundValue = Math.Round(4.6);  // roundValue will be 5.0

5. Math.Max(): Returns the larger of two numbers.
        EXAMPLE: int maxValue = Math.Max(10, 20);  // maxValue will be 20

6. Math.Min(): Returns the smaller of two numbers.
        EXAMPLE: int minValue = Math.Min(10, 20);  // minValue will be 10

7. Math.Pow(): Raises a number to the power of another number.
        EXAMPLE: double powerValue = Math.Pow(2, 3);  // powerValue will be 8.0 (2*2*2)

8. Math.Sqrt(): Returns the square root of a number.
        EXAMPLE: double sqrtValue = Math.Sqrt(16);  // sqrtValue will be 4.0 

9. Math.Sin(): Returns the sine of an angle (in radians).   
        EXAMPLE: double sinValue = Math.Sin(Math.PI / 2);  // sinValue will be 1.0

10. Math.Cos(): Returns the cosine of an angle (in radians).
        EXAMPLE: double cosValue = Math.Cos(0);  // cosValue will be 1.0

11. Math.Tan(): Returns the tangent of an angle (in radians).   
        EXAMPLE: double tanValue = Math.Tan(Math.PI / 4);  // tanValue will be 1.0

12. Math.Log(): Returns the natural logarithm (base e) of a number.
        EXAMPLE: double logValue = Math.Log(2.718281828459045);  // logValue will be approximately 1.0

13. Math.Log10(): Returns the base 10 logarithm of a number.
        EXAMPLE: double log10Value = Math.Log10(100);  // log10Value will be 2.0    

14. Math.Exp(): Returns e raised to the specified power.
        EXAMPLE: double expValue = Math.Exp(1);  // expValue will be approximately 2.718281828459045 (e^1 = e = 2.718...)

15. Math.Truncate(): Returns the integral part of a number by removing the fractional part.
        EXAMPLE: double truncateValue = Math.Truncate(4.7);  // truncateValue will be 4.0
        EXAMPLE: double truncateValue2 = Math.Truncate(-4.7);  // truncateValue2 will be -4.0
        EXAMPLE: double truncateValue3 = Math.Truncate(5.3);  // truncateValue3 will be 5.0

16. Math.Sign(): Returns an integer that indicates the sign of a number.
        EXAMPLE: int signValue = Math.Sign(-10);  // signValue will be -1
        EXAMPLE: int signValue2 = Math.Sign(0);   // signValue2 will be 0
        EXAMPLE: int signValue3 = Math.Sign(10);  // signValue3 will be 1
        ExAMPLE: int signValue4 = Math.Sign(3.5);  // signValue4 will be 1

17. Math.Random(): Returns a random number between 0.0 and 1.0.
        EXAMPLE: double randomValue = Math.Random();  // randomValue will be a random number between 0.0 and 1.0
*/

//                                    ---------------- C# String ----------------

/*
===========> String VS string <===========

1. String --> string is an alias for System.String in C#. Both represent the same data type and can be used interchangeably.
2. String --> (with uppercase 'S') is the .NET Framework type defined in the System namespace, while string (with lowercase 's') is a C# keyword.

            Example: String str1 = "Hello";  and string str2 = "World";  both are valid
            Example: String str = "Hello, World!";  and string str = "Hello, World!";  both are valid

        difference is only in naming convention, functionality and behavior are identical.
        
        string == System.String
*/

//                                    ----------------- C# Boolean -----------------


// Only two possible values: true and false.
// Boolean values are commonly used in conditional statements, loops, and logical operations to control the flow of a program based on certain conditions.
// used to represent truth values in logical expressions and conditions.
/*
using System;
namespace BooleanDemo
{
    class Program
    {
        static void Main()
        {
            int a = 10;
            int b = 20;
            bool isAGreaterThanB = a > b;  // false
            bool isALessThanB = a < b;     // true

            Console.WriteLine("Is a greater than b? " + isAGreaterThanB);
            Console.WriteLine("Is a less than b? " + isALessThanB);

            Console.ReadLine(); // Keep the console window open
        }
    }
}
*/

//                                          ---------------- C# if-else Condisonal Statement ----------------

// 1. if : The if statement is used to execute a block of code if a specified condition is true.
// 2. else : The else statement is used to execute a block of code if the specified condition in the if statement is false.
// 3. else if : The else if statement is used to specify a new condition to
// 4. switch : The switch statement is used to select one of many code blocks to be executed based on the value of a variable or expression.
//             (Use switch to specify many alternative blocks of code to be executed)

/*
using System;
namespace IfElseDemo    
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine() ?? "0");

            // Using if-else statement to check age
            if (age < 18)                                                // don't use uppercase IF, ELSE, ELSE IF
            {
                Console.WriteLine("You are a minor.");
            }
            else if (age >= 18 && age < 65)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a senior citizen.");
            }

            // switch statement to check age group
            switch (age)
            {
                case int n when (n < 18):
                    Console.WriteLine("Switch: You are a minor.");
                    break;
                case int n when (n >= 18 && n < 65):
                    Console.WriteLine("Switch: You are an adult.");   // n : variable to hold the value of age for comparison (age = n)
                    break;
                default:                                              // case int n when (n >= 65):  ( use default for all other cases that are not covered by previous cases)
                    Console.WriteLine("Switch: You are a senior citizen.");
                    break;
            }

            Console.ReadLine(); // Keep the console window open
        }
    }
}
*/

// ========> Ternary Operator as an Alternative to if-else Statement <========

// if-else ==> condition ? value_if_true : value_if_false
/*
using System;
namespace TernaryOperatorDemo
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine() ?? "0");

            // Using ternary operator to check age
            string ageGroup = (age < 18) ? "You are a minor." :
                              (age >= 18 && age < 65) ? "You are an adult." :
                              "You are a senior citizen.";

            Console.WriteLine(ageGroup);

            Console.ReadLine(); // Keep the console window open
        }
    }
}
*/

// ============================================= EXERCISE - PROJECT 03 (Grade Calculator) =============================================

/*
using System;
namespace GradeCalculatorApp
{
    class Program
    {
        static void Main()
        {
            Console.Write("\nEnter Your Student ID: ");
            string studentID = Console.ReadLine() ?? "";
            Console.WriteLine();
            Console.Write("Enter Your Name: ");
            string name = Console.ReadLine() ?? "";
            Console.WriteLine();
            Console.Write("Enter Your Com.Maths Marks: ");
            double comMathsMarks = Convert.ToDouble(Console.ReadLine() ?? "0");
            Console.WriteLine();
            if (comMathsMarks < 0 || comMathsMarks > 100)
            {
                Console.WriteLine("Invalid Com.Maths Marks. Please enter marks between 0 and 100.");
                return; // Exit the program
            }

            Console.Write("Enter Your Physics Marks: ");
            double physicsMarks = Convert.ToDouble(Console.ReadLine() ?? "0");
            Console.WriteLine();
            if (physicsMarks < 0 || physicsMarks > 100)
            {
                Console.WriteLine("Invalid Physics Marks. Please enter marks between 0 and 100.");
                return; // Exit the program
            }
            Console.Write("Enter Your Chemistry Marks: ");
            double chemistryMarks = Convert.ToDouble(Console.ReadLine() ?? "0");
            Console.WriteLine();
            if (chemistryMarks < 0 || chemistryMarks > 100)
            {
                Console.WriteLine("Invalid Chemistry Marks. Please enter marks between 0 and 100.");
                return; // Exit the program
            }

            double totalMarks = comMathsMarks + physicsMarks + chemistryMarks;
            double averageMarks = totalMarks / 3;
            string grade;
            if (averageMarks >= 85)
            {
                grade = "A+";
            }
            else if (averageMarks >= 80)
            {
                grade = "A";
            }
            else if (averageMarks >= 75)
            {
                grade = "A-";
            }
            else if (averageMarks >= 70)
            {
                grade = "B+";
            }
            else if (averageMarks >= 65)
            {
                grade = "B";
            }
            else if (averageMarks >= 60)
            {
                grade = "B-";
            }
            else if (averageMarks >= 55)
            {
                grade = "C+";
            }
            else if (averageMarks >= 50)
            {
                grade = "C";
            }
            else if (averageMarks >= 45)
            {
                grade = "C-";
            }
            else if (averageMarks >= 40)
            {
                grade = "D";
            }
            else
            {
                grade = "F";
            }
            Console.WriteLine("\n----- Student Grade Report -----\n");
            Console.WriteLine("Student ID: {0} \nStudent Name: {1} \n", studentID, name);
            Console.WriteLine("Com.Maths Marks: {0}\nPhysics Marks: {1}\nChemistry Marks: {2}\n", comMathsMarks, physicsMarks, chemistryMarks);
            Console.WriteLine("Total Marks: {0} \nAverage Marks: {1} \nGrade: {2}", totalMarks, averageMarks, grade);

            Console.Write("\nPress any key to exit...");
            Console.ReadKey(); // Keep the console window open until a key is pressed


        }
    }
}
*/

// ========> C# Switch Expression as an Alternative to if-else Statement <========

// switch expression is a more concise and readable way to perform multiple conditional checks based on the value of a variable or expression. It allows you to evaluate an expression and return a value based on matching patterns, making it a powerful alternative to traditional if-else statements for certain scenarios.

// switch expression syntax:

/*
switch (expression)
{
    case pattern1:
        // code to execute if pattern1 matches
        break;
    case pattern2:
        // code to execute if pattern2 matches
        break;
    
    default:
        // code to execute if no patterns match
        break;
}
*/
/*
using System;
namespace SwitchExpressionDemo
{
    class Program
    {
        static void Main()
        {
            Console.Write("\nEnter your Height (in cm): ");
            int height = Convert.ToInt32(Console.ReadLine() ?? "0");

            switch(height)
            {
                case int h when h < 150:
                    Console.WriteLine("You are Short.");
                    break;                                  // we use break for if condition is correct code is exit  

                case int h when h >= 150 && h < 170:
                    Console.WriteLine("You are Average Height.");
                    break;

                case int h when h >= 170 && h < 190:
                    Console.WriteLine("You are Tall.");
                    break;

                default:
                    Console.WriteLine("You are Very Tall.");
                    break;
            }
            Console.Write("Press any key to Exit");
            Console.ReadKey(); // Keep the console window open
        }
    }
}
*/

// =========> Example 01

/*
using System;
namespace SwitchExample
{
    class Program
    {
        static void Main()
        {
            Console.Write("\nEnter weekday Number (0 - 6): ");
            int weekday = Convert.ToInt32(Console.ReadLine() ?? "0");

            switch(weekday)
            {
                case 0:
                    Console.WriteLine("It is Sunday");
                    break;

                case 1:
                    Console.WriteLine("It is Monday");
                    break;

                case 2:
                    Console.WriteLine("It is Tuesday");
                    break;

                case 3:
                    Console.WriteLine("It is Wenesday");
                    break;
                
                case 4:
                    Console.WriteLine("It is Thursday");
                    break;
                
                case 5:
                    Console.WriteLine("It is Friday");
                    break;

                case 6:
                    Console.WriteLine("It is Saturday");
                    break;

                default :
                    Console.WriteLine("Your weekday value is Undefined  ");
                    break; 

            }
            Console.Write("Press any key to Exit ");
            Console.ReadKey();
        }
    }
}
*/

// Example 02
/*
using System;
namespace Example02
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\n---------------WelCome to Grade Calculater----------------");
            Console.Write("\n\nEnter Your Com.Maths Marks: ");
            int ComMaths = Convert.ToInt32(Console.ReadLine() ?? "0"); 

            Console.Write("\nEnter Your Physics Marks: ");
            int Physics = Convert.ToInt32(Console.ReadLine() ?? "0"); 

            Console.Write("\nEnter Your Chemistry Marks: ");
            int Chemistry = Convert.ToInt32(Console.ReadLine() ?? "0"); 

            double ave = (ComMaths + Physics + Chemistry) / 3 ;
            
            switch(ave)
            {
                case > 85:
                    Console.WriteLine("Your Grade is 'A+'");
                    break;

                case > 75:
                    Console.WriteLine("Your Grade is 'A'");
                    break;

                case > 70:
                    Console.WriteLine("Your Grade is 'A-'");
                    break;

                case > 65:
                    Console.WriteLine("Your Grade is 'B+'");
                    break;
                    
                case > 60:
                    Console.WriteLine("Your Grade is 'B'");
                    break;

                case > 55:
                    Console.WriteLine("Your Grade is 'B-'");
                    break;
                
                case > 50:
                    Console.WriteLine("Your Grade is 'C+'");
                    break;

                case > 45:
                    Console.WriteLine("Your Grade is 'C'");
                    break;

                case > 40:
                    Console.WriteLine("Your Grade is 'C-'");
                    break;

                default :
                    Console.WriteLine("Fail");
                    break;

            }
            Console.Write("Press any key to Exit : ");
            Console.ReadKey();
        }
    }
}
*/

//                          ---------------------------- While Loop ----------------------------

// The while loop is repeatedly executes a block of code as long as a specified condition is true. The syntax of the while loop is as follows:
/*
while (condition)
{
    // code to be executed
}
*/
/*
using System;
namespace WhileLoopDemo
{
    class Program
    {
        static void Main()
        {
            int x = 1;
            while (x <= 5)
            {
                Console.WriteLine("Hello, World! " + x);
                x++;    // Increment x to avoid infinite loop (x = x + 1)
            }
        }
    }
}
*/
/*
using System;
namespace WhileLoopExample
{
    class Program
    {
        static void Main()
        {
            int number = 1;
            while (number <= 10)
            {
                Console.WriteLine(number);
                number++;     // or may be number += 1
            }
        }
    }
}
*/
/*
using System;
namespace WhileLoopExample2
{
    class Program
    {
        static void Main()
        {
            Console.Write("\nEnter a Number to Print 2 nd multiplication table: ");
            int num = Convert.ToInt32(Console.ReadLine() ?? "0");

            int i = 2;
            while (i <= num)
            {
                Console.Write(i + " ");
                i += 2;
            }
        }
    }
}
*/
/*
using System;
namespace WhileLoopExample3
{
    class Program
    {
        static void Main()
        {
            int i = 10;
            while (i >= 1)
            {
                Console.Write(i + " ");
                i--;
            }
        }
    }
}
*/
/*
using System;
namespace WhileLoopExample4
{
    class Program
    {
        static void Main()
        {
            while(true)
            {
                Console.WriteLine("\n---------------WelCome to Height Cakculater ----------------");
                Console.Write("\n\nEnter Your Height (in cm): ");
                int h = Convert.ToInt32(Console.ReadLine() ?? "0");

                while (true)
                {
                    if (h <= 0 || h > 300)
                    {
                        Console.WriteLine("Invalid Height! Please enter height between 1 and 300 cm.");
                        Console.Write("Enter Height Again (in cm): ");
                        h = Convert.ToInt32(Console.ReadLine() ?? "0");
                    }
                    else
                    {
                        if (h < 150)
                        {
                            Console.WriteLine("You are Short.");
                        }
                        else if (h >= 150 && h < 170)
                        {
                            Console.WriteLine("You are Average Height.");
                        }
                        else if (h >= 170 && h < 190)
                        {
                            Console.WriteLine("You are Tall.");
                        }
                        else
                        {
                            Console.WriteLine("You are Very Tall.");
                        }
                        break; // exit inner while loop after valid height is processed
                    }
                }
                Console.Write("If you want to continue, enter 'y' otherwise 'n': ");
                string choice = (Console.ReadLine() ?? "n").ToLower();
                if (choice != "y")
                {
                    break;
                }
            }
                Console.Write("Press any key to Exit : ");
                Console.ReadKey();       
        }
    }
}
*/

//                          ---------------------------- For Loop ----------------------------

// The for loop is a control flow statement that allows you to execute a block of code a specific number of times. It consists of three parts:
// initialization, condition, and iteration. The syntax of the for loop is as follows:

/*
for (initialization; condition; iteration)
{
    // code to be executed
}
*/

// initialization: beginning of the loop, where you typically declare and initialize a loop control variable.
// condition: a boolean expression that is evaluated before each iteration of the loop. If the condition
//            evaluates to true, the loop body is executed. If it evaluates to false, the loop terminates.
// iteration: a statement that is executed after each iteration of the loop body, typically used to update the loop control variable.

/*
using System;
namespace ForLoopDemo
{
    class Program
    {
        static void Main()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Hello, World! {i}");
            }
        }
    }
}
*/


/*
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

for (int i = 2; i <= 20; i += 2)
{
    Console.Write(i + " ");
}

for (int i = 10; i >= 1; i--)
{
    Console.Write($"{i} ");
}
*/

//                      ---------------------------- Nested Loop ----------------------------

// A nested loop is a loop that is contained within another loop. The inner loop is executed completely for each iteration of the outer loop. 
// Nested loops are often used to work with multi-dimensional data structures, such as arrays or matrices, or to perform complex iterations that require multiple levels of looping.

/*
for (int i = 1; i <= 3; i++)
{
    for (int j = 1; j <= 3; j++)
    {
        Console.Write($"({i}, {j}) ");
    }
    Console.WriteLine(); // Move to the next line after inner loop completes
}

Console.WriteLine();

for (int i = 1; i <= 5; i++)
{
    for (int j = i; j <= 5; j++)
    {
        Console.Write($"{j} ");
    }
    Console.WriteLine(); // Move to the next line after inner loop completes
}

Console.WriteLine();

for (int i = 1; i <= 5; i++)
{
    for (int j = i; j <= 5; j++)
    {
        Console.Write($"* ");
    }
    Console.WriteLine(); // Move to the next line after inner loop completes
}

Console.WriteLine();

for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write($"{j} ");
    }
    Console.WriteLine(); // Move to the next line after inner loop completes
}

Console.WriteLine();

for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write($"* ");
    }
    Console.WriteLine(); // Move to the next line after inner loop completes
}

Console.WriteLine();

for (int i = 1; i <= 7; i++)
{
    for (int j = i; j <= 6; j++)
        Console.Write(" ");

    Console.Write("* ");
    for (int k = 1; k < i; k++)

        Console.Write("* ");
    Console.WriteLine(); // Move to the next line after inner loop completes
}

Console.WriteLine();

for (int i = 1; i <= 7; i++)
{
    for (int s = 0; s < 7 - i; s++)
        Console.Write(" ");

    for (int star = 0; star < i; star++)
        Console.Write("* ");

    Console.WriteLine();
}
*/
/*
int sum = 0;
for (int i = 1; i <= 10; i++)
{
    sum += i;
    Console.Write(i+" ");
}
Console.Write($"\nNatural Number Sum = {sum}");
*/
/*
int count = 0;
int sum = 0;
Console.Write("\nEnter Your Number : ");
int num = Convert.ToInt32(Console.ReadLine() ?? "0");
for (int i = 1; i <= num; i+=2)
{
    Console.Write(i + " ");
    count++;
    sum += i;

}
Console.WriteLine($"\nNumber of Odd Numbers between 1 and {num} is : {count} \n");
Console.Write("Sum of Odd Numbers are : "+sum);
*/
/*
Console.Write("\nEnter a Number to Print its Multiplication Table: ");
int num = Convert.ToInt32(Console.ReadLine() ?? "0");
for(int i = 1; i <= num; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}
*/
/*
Console.Write("\nEnter a Number to Print its Multiplication Table: ");
int num = Convert.ToInt32(Console.ReadLine() ?? "0");
for(int i = 1; i <= num; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(j+" ");
    }
    Console.WriteLine();
}
*/
/*
int sum = 0;
for(int i = 100; i <= 200; i++)
{
    if (i % 9 == 0)
    {
        Console.Write(i + " ");
        sum += i;
    }
}
Console.WriteLine($"\nSum of numbers divisible by 9 between 100 and 200 is: {sum}");
*/


//                      ---------------------------- C# Foreach Loop ----------------------------
/*
The foreach loop is a control flow statement that allows you to iterate over a collection of items, such as an array, list, or any object
that implements the IEnumerable interface.
*/
/*
foreach (type variable in collection)
{
    // code to be executed for each item in the collection
}
*/
/*
using System;

class Program
{
    static void Main()
    {
        int[] numbers = {10, 20, 30, 40, 50};

        foreach (int num in numbers)   // use like array name and variable name (num) to hold the value of each element in the array during iteration
        {
            Console.WriteLine(num);
        }
    }
}
*/
/*
string s = "Hello, World!";
for (int i = 0; i < s.Length; i++)   // use like string name and variable name (ch)
{
    char ch = s[i];
    Console.WriteLine(ch + " ");
}

Console.WriteLine();

foreach (char ch in s)   // use like string name and variable name (ch) to hold the value of each character in the string during iteration
{
    Console.WriteLine(ch + " ");
}
*/


// ==============> Example 01
/*
using System;
namespace LoopExamples
{
    class Program
    {
        static void Main()
        {
            Console.Write("\nEnter Your Password: ");
            string pasword = Console.ReadLine() ?? "";

            bool hasUpperCase = false;            // we use boolean variable to check the condition is true or false (if password has uppercase letter or not)
            bool hasLowerCase = false;            // we use boolean variable to check the condition is true or false (if password has lowercase letter or not)
            bool hasDigit = false;                // we use boolean variable to check the condition is true or false (if password has digit or not)
            bool hasSpecialChar = false;          // we use boolean variable to check the condition is true or false (if password has special character or not)


            for(int i = 0; i < pasword.Length; i++)     // 0 to password length - 1 (last index of the string) because string 
                                                         // index is zero-based (first character is at index 0) 
            {
                char ch = pasword[i];  // i is the index of the current character in the password string.
                if (char.IsUpper(ch))  // ch is the current character being checked in the password string. char.IsUpper(ch) is a method that checks if the character ch is an uppercase letter.
                {
                    hasUpperCase = true;
                }
                else if (char.IsLower(ch))
                {
                    hasLowerCase = true;
                }
                else if (char.IsDigit(ch))
                {
                    hasDigit = true;
                }
                else if (!char.IsLetterOrDigit(ch))
                {
                    hasSpecialChar = true;
                }
            }
            if (hasUpperCase && hasLowerCase && hasDigit && hasSpecialChar && pasword.Length >= 8)
            {
                Console.WriteLine("Your password is Strong.");
            }
            else
            {
                Console.WriteLine("Your password is Weak. \nPlease include:  \nuppercase letters \nlowercase letters \ndigits \nspecial characters");
            }
        }
    }
}
*/

/*
using System;
namespace LoopExamples
{
    class Program
    {
        static void Main()
        {
            Console.Write("\nEnter Your Password: ");
            string pasword = Console.ReadLine() ?? "";

            bool hasUpperCase = false;            // we use boolean variable to check the condition is true or false (if password has uppercase letter or not)
            bool hasLowerCase = false;            // we use boolean variable to check the condition is true or false (if password has lowercase letter or not)
            bool hasDigit = false;                // we use boolean variable to check the condition is true or false (if password has digit or not)
            bool hasSpecialChar = false;          // we use boolean variable to check the condition is true or false (if password has special character or not)


            foreach(char ch in pasword)     // 0 to password length - 1 (last index of the string) because string 
                                                         // index is zero-based (first character is at index 0) 
            {
                if (char.IsUpper(ch))  // ch is the current character being checked in the password string. char.IsUpper(ch) is a method that checks if the character ch is an uppercase letter.
                {
                    hasUpperCase = true;
                }
                else if (char.IsLower(ch))
                {
                    hasLowerCase = true;
                }
                else if (char.IsDigit(ch))
                {
                    hasDigit = true;
                }
                else if (!char.IsLetterOrDigit(ch))
                {
                    hasSpecialChar = true;
                }
            }
            if (hasUpperCase && hasLowerCase && hasDigit && hasSpecialChar && pasword.Length >= 8)
            {
                Console.WriteLine("Your password is Strong.\n");
            }
            else
            {
                Console.WriteLine("Your password is Weak. \nPlease include:  \nuppercase letters \nlowercase letters \ndigits \nspecial characters");
            }
        }
    }
}
*/
// ==============> Example 02

/*
using System;
namespace LoopExamples
{
    class Program
    {
        static void Main()
        {
            int attempts = 0;
            double balance = 10000; // initial balance

            while (true)
            {
                Console.Write("\n--------------- Welcome to BOC Bank ATM ----------------\n");
                Console.Write("\nEnter Your 4-digit Card Number: ");

                string cardNumber = Console.ReadLine() ?? "";

                // validation
                
                if (cardNumber.Length != 4 || !int.TryParse(cardNumber, out _)) // check if card number is not 4 digits or contains non-numeric characters
                {
                    attempts++;

                    Console.WriteLine("Invalid Card Number!");

                    if (attempts >= 3)
                    {
                        Console.WriteLine("Your card has been blocked!");
                        return; // exit the program after card is blocked
                    }

                    continue;   // prompt user to enter card number again
                }

                Console.WriteLine("\nCard Accepted!");
                attempts = 0;

                // transaction loop
                while (true)
                {
                    Console.WriteLine("\n1. Withdraw");
                    Console.WriteLine("2. Deposit");
                    Console.WriteLine("3. Check Balance");
                    Console.WriteLine("4. Exit");

                    Console.Write("Select option: ");
                    int option;
                    if(!int.TryParse(Console.ReadLine(), out option))
                    {
                        Console.WriteLine("Invalid option! Enter a number.");
                        continue;
                    }


                    if (option == 1)
                    {
                        Console.Write("Enter amount: ");
                        double amount;
                        if(!double.TryParse(Console.ReadLine(), out amount) || amount <= 0) // check if card number is not numeric or amount is not positive
                        {
                            Console.WriteLine("Enter a valid positive amount.");
                            continue;   // prompt user to enter amount again
                        }

                        if (amount <= balance)
                        {
                            balance -= amount;
                            Console.WriteLine($"Withdraw successful. Balance = {balance}");
                        }
                        else
                        {
                            Console.WriteLine("Insufficient balance!");
                        }
                    }
                    else if (option == 2)
                    {
                        Console.Write("Enter amount: ");
                        double amount;
                        if(!double.TryParse(Console.ReadLine(), out amount) || amount <= 0) // check if card number is not numeric or amount is not positive
                        {
                            Console.WriteLine("Enter a valid positive amount.");
                            continue;
                        }
                        balance += amount;
                        Console.WriteLine($"Deposit successful. Balance = {balance}");
                    }
                    else if (option == 3)
                    {
                        Console.WriteLine($"Current balance = {balance}");
                    }
                    else if (option == 4)
                    {
                        Console.WriteLine("Thank you for using BOC ATM.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option!");
                    }
                    Console.Write("\nDo you want another transaction? (y/n): ");
                    string choice = (Console.ReadLine() ?? "n").ToLower();

                    if (choice == "n")
                    {
                        Console.WriteLine("Thank you for using BOC ATM.");
                        Console.WriteLine("Please remove your card.");
                        Console.WriteLine("Card removed successfully.\n");
                        return; // exit the program after card is removed
                    }

                }
            }
        }
    }
}
*/


//                             ---------------------------- C# Break and Continue ----------------------------

// ===> C# Break Statement : 
//             The break statement is used to exit a loop or switch statement prematurely, before the loop condition is false or before all 
//             cases in a switch statement have been evaluated. When a break statement is encountered, the control immediately exits the innermost loop or switch statement and continues with the next statement after the loop or switch.


// ===> C# Continue Statement :
//             The continue statement is used to skip the current iteration of a loop and move to the next iteration. 
//             When a continue statement is encountered, the control immediately jumps to the next iteration of the loop, bypassing any remaining code in the current iteration. The loop condition is then evaluated again to determine if the loop should continue or terminate.



//                                 ---------------------------- C# Arrays ----------------------------

// Arrays are used to store multiple values in a single variable.
// An array is a collection of similar type data.

//  ==> Advantages of Arrays :
//                1. Less code
//                2. Random access (access any element directly using its index)
//                3. Efficient memory usage (contiguous memory allocation)
//                4. Built-in methods for manipulation (sorting, searching, etc.)
//                5. Easy to iterate (using loops or foreach)
//                6. Easy to manupulate (using loops, built-in methods, etc.)
//                7. Can store large amount of data (limited by system memory)
//                8. Can be multi-dimensional (2D, 3D, etc.)
//                8. Easy to short and search (using built-in methods or algorithms)
//                9. Can be used to implement other data structures (lists, stacks, queues, etc.)
//                10. Can be used to store objects (arrays of objects)

//  ==> Disadvantages of Arrays :
//                1. Fixed size (size must be defined at the time of declaration and cannot be changed later)
//                2. Homogeneous (can only store elements of the same type)

/*
dataType[] arrayName;
*/

/*
int[] x; //can store multiple integer values
string[] s; // can store multiple string values
double[] d; // can store multiple double values
char[] c; // can store multiple char values
bool[] b; // can store multiple boolean values
*/

// aliocate Array Memory
// Array index starts from 0 to n-1 (where n is the size of the array)
/*
int[] age = new int[5]; // array of 5 integers (default values are 0)
string[] names = new string[3]; // array of 3 strings (default values are null)
double[] marks = new double[4]; // array of 4 doubles (default values are 0.0)
char[] grades = new char[6]; // array of 6 chars (default values are '\0')
bool[] isPassed = new bool[2]; // array of 2 booleans (default values are false)
*/
/*
int[] age = new int[5] { 20, 25, 30, 35, 40 }; // array of 5 integers with initial values

Console.WriteLine(age[0]); // Output: 20
Console.WriteLine(age[1]); // Output: 25    
Console.WriteLine(age[2]); // Output: 30
Console.WriteLine(age[3]); // Output: 35
Console.WriteLine(age[4]); // Output: 40

string[] names = new string[3] { "Alice", "Bob", "Charlie" }; // array of 3 strings with initial values

Console.WriteLine(names[0]); // Output: Alice
Console.WriteLine(names[1]); // Output: Bob
Console.WriteLine(names[2]); // Output: Charlie

int[] marks = { 85, 90, 95 }; // array of integers with initial values (size is inferred)

Console.WriteLine(marks[0]); // Output: 85
Console.WriteLine(marks[1]); // Output: 90
Console.WriteLine(marks[2]); // Output: 95

Console.WriteLine(age.Length); // Output: 5 (number of elements in the age array)
Console.WriteLine(names.Length); // Output: 3 (number of elements in the names array)
Console.WriteLine(marks.Length); // Output: 3 (number of elements in the marks

*/

/*
string[] cars = { "Toyota", "Honda", "Ford", "BMW", "Audi" };

cars[2] = "Tesla"; // Update the element at index 2 (Ford is replaced by Tesla)

Console.WriteLine(cars); // Wrong way to print array (will print the type of the array instead of its elements)
Console.WriteLine(string.Join(", ", cars)); // Correct way to print array elements (using string.Join to concatenate elements with a separator)
                                            // Output: Toyota, Honda, Tesla, BMW, Audi  
// or
for (int i = 0; i < cars.Length; i++)
{
    Console.WriteLine(cars[i]); // Output: Toyota, Honda, Tesla, BMW, Audi (each on a new line)
}
//or
foreach (string car in cars)
{
    Console.WriteLine(car); // Output: Toyota, Honda, Tesla, BMW, Audi (each on a new line)
}
*/

//==============> Example 01
/* 
using System;
namespace ArrayExample  
{
    class Program
    {
        static void Main()
        {
            int numSubjects = 3;
            string[] subjects = new string[numSubjects];

            int[] marks = new int[numSubjects];

            int totalMarks = 0;
            double averageMarks = 0.0;
            Console.WriteLine("\n--------------- Welcome to Student Grade Calculator ----------------\n");
            for (int i = 0; i < numSubjects; i++)
            {
                Console.Write($"Enter Subject {i + 1} Name: ");
                subjects[i] = Console.ReadLine() ?? "";

                Console.Write($"Enter {subjects[i]} Marks: ");
                marks[i] = Convert.ToInt32(Console.ReadLine() ?? "0");

                totalMarks += marks[i];
            }
            averageMarks = totalMarks / (double)numSubjects; // or averageMarks = totalMarks / 3.0;
            Console.WriteLine("\n----- Student Grade Report -----\n");
                for (int i = 0; i < numSubjects; i++)
                {
                    Console.WriteLine($"{subjects[i]} Marks: {marks[i]}");
                }
            Console.WriteLine($"\nTotal Marks: {totalMarks}");
            Console.WriteLine($"Average Marks: {averageMarks:F2}"); // F2 format specifier to display average marks with 2 decimal places

             string grade;
             if (averageMarks >= 90)
                 grade = "A";
             else if (averageMarks >= 80)
                 grade = "B";
             else if (averageMarks >= 70)
                 grade = "C";
             else if (averageMarks >= 60)
                 grade = "D";
             else
                 grade = "F";

            Console.WriteLine($"Grade: {grade}");
        }
    }
}
*/


//                               ---------------------------- C# Methods ----------------------------

// A method is a block of code that performs a specific task and can be called from other parts of the program. 
// Methods are used to organize code, promote reusability, and improve readability. 
// They can take parameters, return values, and can be called multiple times from different parts of the program.
//👉 Method = ஒரு வேலை செய்யும் code block

// Creat a Method
/*
returnType MethodName(parameters)
{
    // code to be executed
}
*/


// returnType: The data type of the value that the method returns. If the method does not return a value, the return type is void.
// MethodName: The name of the method, which should be descriptive of its purpose and follow C# naming conventions (PascalCase).
// parameters: A comma-separated list of input values that the method can accept. Each parameter has a data type and a name. If the method does not take any 
//    parameters, this section can be left empty.

/*
using System;
class Program
{
    // static ==> 👉 object create பண்ணாமலே use பண்ண முடியும்
    
    static void Main()              // static means that the method belongs to the class and can be called without creating an instance of the class. 
                                    // void means that the method does not return any value. Main is the entry point of the program where execution starts.
    {
        Program p1 = new Program(); // Create an instance of the Program class to call the non-static method MyMethod
        p1.MyMethod(); // calling the method to execute its code

    }
    public void MyMethod()
    {
        Console.WriteLine("Hello, World!");
    }     
}

*/
/*
class Program
{
    static void Main()
    {
        for (int i = 1; i <= 5; i++)
        {
            MyMethod(); // calling the method multiple times to execute its code
        }
    }
    static void MyMethod()   // we use static so, no need object
    {
        Console.WriteLine("Hello, World!");
    }
}
*/


// ===> Prameter and Argument in Method
/*
using System;
namespace MethodExample
{
    class Program
    {
        static void MyMethod(string name) // name is a parameter of type string (input value that the method can accept)
        {
            Console.WriteLine($"Mohammad {name}");
        }
        static void Main()
        {
            MyMethod("Aashik"); // Aashik is an argument passed to the method
            MyMethod("Aashif"); // Aashif is an argument passed to the method
            MyMethod("Aadil"); // Aadil is an argument passed to the method
        }
    }
}
*/

// ===> Multiple Parameters and Arguments in Method
/*
using System;
namespace MethodExample2
{
    class Program
    {
        static void MyMethod(string name, int age, int height) // name and age are parameters of type string and int (input values that the method can accept)
        {
            Console.WriteLine($"My name is {name} and I am {age} years old and my height is {height} cm.");
        }
        static void Main()
        {
            MyMethod("Aashik", 25, 170); // Aashik and 25 are arguments passed to the method
            MyMethod("Aashif", 22, 165); // Aashif and 22 are arguments passed to the method
            MyMethod("Aadil", 17, 160); // Aadil and 17 are arguments passed to the method
        }
    }
}   
*/

// ===> Default Parameters in Method
/*
using System;
namespace MethodExample3
{
    class Program
    {
        static void MyMethod(string name, int age = 18) // age is a default parameter with a default value of 18 (if no argument is passed for age, it will use the default value)
        {
            Console.WriteLine($"My name is {name} and I am {age} years old.");
        }
        static void Main()
        {
            MyMethod("Aashik", 25); // Aashik and 25 are arguments passed to the method
            MyMethod("Aashif"); // Aashif is an argument passed to the method, age will use default value of 18
            MyMethod("Aadil", 17); // Aadil and 17 are arguments passed to the method
        }
    }
}
*/

// ===> Return Type and Return Value in Method
/*
using System;
namespace MethodExample4
{
    class Program
    {
        static int MyMethod(int a, int b) // int is the return type of the method (the data type of the value that the method returns)
        {
            int sum = a + b; // calculate the sum of a and b
            return sum; // return the calculated sum to the caller
        }
        static void Main()
        {
            Console.WriteLine("Enter two numbers to calculate their sum:");
            int num1 = Convert.ToInt32(Console.ReadLine()) ; // Parse - convert the input string to an integer (if the input is not a valid integer, it will throw an exception)
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = MyMethod(num1, num2); // calling the method and storing the returned value in a variable
            Console.WriteLine($"The sum of {num1} and {num2} is: {result}"); // Output: The sum of 10 and 20 is: 30
        }
    }
}
*/

// ===> Method Overloading in C# (👉 Overloading = same name, different parameter list)
/*
using System;
namespace MethodExample5
{
    class Program
    {
        static void MyMethod(int a, int b,int c) // Method to calculate the sum of two integers
        {
            int sum = a + b +c;
            Console.WriteLine($"The sum of {a}, {b}and {c} is: {sum}");
        }
        static void MyMethod(double a, double b) // Method to calculate the sum of two doubles (overloaded method with different parameter types)
        {
            double sum = a + b;
            Console.WriteLine($"The sum of {a} and {b} is: {sum}");
        }
        static void Main()
        {
            MyMethod(10, 20,40); // Calls the method that takes two integers (Output: The sum of 10 and 20 is: 30)
            MyMethod(5.5, 4.5); // Calls the method that takes two doubles (Output: The sum of 5.5 and 4.5 is: 10)
        }
    }
}
*/

//                       ---------------------------- C# Method Implementation ---------------------------- 
/*  

1. Without Parameter and Without Return Type
2. With Parameter and Without Return Type
3. Without Parameter and With Return Type
4. With Parameter and With Return Type

*/

// ===> 1. Without Parameter and Without Return Type
/*
static void MyMethod()
{
    Console.WriteLine("This is a method without parameters and without return type.");
}
*/

// ===> 2. With Parameter and Without Return Type
/*
static void MyMethod(string name, int age)
{
    Console.WriteLine($"My name is {name} and I am {age} years old.");
}
*/

// ===> 3. Without Parameter and With Return Type
/*
static int MyMethod()
{
    return 42;
}
*/

// ===> 4. With Parameter and With Return Type
/*
static int MyMethod(int a, int b)
{
    return a + b;
}
*/
/*
using System;
namespace MethodImplementationExample
{
    class Program
    {
        static int product()    // not use viod because we want to return a value from the method
        {
            int a = 5;
            int b = 10;

            int result = a * b;
            return result; // Error: Cannot return a value from a method with void return type
                           // Only return can stop in void method but it cannot return any value. If you want to return a value, 
                           // you need to change the return type of the method from void to the data type of the value you want to return (e.g., int, string, etc.)
        }
        static void Main()
        {
            int result = product(); // calling the method and storing the returned value in a variable
            Console.WriteLine($"The product of 5 and 10 is: {result}"); // Output: The product of 5 and 10 is: 50
        }
    }
}
*/


//                      ================= Object Oriented Programming (OOP) in C# =================
/*
Object-Oriented Programming (OOP) is a programming paradigm that organizes software design around data, or objects, rather than functions 
and logic. In OOP, objects are instances of classes, which can contain both data (attributes) and methods (functions) that operate on that 
data. OOP allows for the creation of modular, reusable, and maintainable code by encapsulating data and behavior within objects.

The four main principles of OOP are:

1. Encapsulation: The bundling of data and methods that operate on that data within a single unit (class), and restricting access to some 
                  of the object's components. This is typically achieved through access modifiers (e.g., private, public, protected).

2. Inheritance  : The mechanism by which one class (child or subclass) can inherit properties and behaviors (methods) from another class 
                  (parent or superclass). This promotes code reusability and establishes a natural hierarchical relationship between classes.

3. Polymorphism : The ability of different classes to be treated as instances of the same class through a common interface. Polymorphism 
                  allows for methods to be used interchangeably, even if they belong to different classes, as long as they share the same 
                  method signature.

4. Abstraction  : The concept of hiding the complex implementation details of a class and exposing only the necessary features and 
                  functionalities to the user. Abstraction allows for a clear separation between what an object does and how it does it, 
                  making it easier to use and maintain code.
*/

// =================> Class and Object in C#

//                                 ---------------------------- C# Class ----------------------------
//                                      (👉 Class = object create பண்ண ஒரு blueprint (model))

/*
A class is a blueprint or template for creating objects. It defines the properties (attributes) and behaviors (methods) that the objects 
created from the class will have. A class can be thought of as a user-defined data type that encapsulates data and functions that operate on
that data.        
The syntax for defining a class in C# is as follows:

class ClassName
{
    // Fields (attributes)
    // Properties
    // Methods (behaviors)
}

*/
/*
using System;
namespace OOPExample
{
    class Car
    {
        String color = "Red"; // field (attribute)

        static void Main()    // Main method is the entry point of the program where execution starts
        {
            Car myObj1 = new Car(); // creating an object (instance) of the Car class
            Car myObj2 = new Car(); // creating another object (instance) of the Car class
            Console.WriteLine($"My car color is: {myObj1.color}"); // accessing the field of the object
            Console.WriteLine($"My car color is: {myObj2.color}"); // accessing the field of the object
        }
    }    
}
*/
/*
using System;
namespace OOPExample2
{
    class Car
    {
        public string color = "Red"; // field (attribute)
        public string model = "Toyota"; // field (attribute)
    }
}
*/

//               ---------------------- C# Class Members (Fields, Properties, Methods) ----------------------
/*
using System;
namespace OOPExample2
{
    class Car
    {
        string color = "Red"; // field (attribute)
        string model = "Toyota"; // field (attribute)
        int maxSpeed = 300; // field (attribute)

        static void Main(string[] args) // method (behavior)
        {
            Car myObj = new Car(); // creating an object (instance) of the Car class
            Console.WriteLine($"My car color is: {myObj.color}"); // accessing the field of the object
            Console.WriteLine($"My car model is: {myObj.model}"); // accessing the field of the object
            Console.WriteLine($"My car max speed is: {myObj.maxSpeed} km/h"); // accessing the field of the object
        }
    }
}
*/

//                      ------------- or -----------
/*
using System;
namespace OOPExample2
{
    class Car
    {
        string? color; // field (attribute)
        string? model; // field (attribute)
        int maxSpeed; // field (attribute)

        static void Main(string[] args) // method (behavior)
        {
            Car myObj = new Car(); // creating an object (instance) of the Car class

            myObj.color = "Blue"; // setting the value of the field
            myObj.model = "Honda"; // setting the value of the field
            myObj.maxSpeed = 250; // setting the value of the field

            Console.WriteLine($"My car color is: {myObj.color}"); // accessing the field of the object
            Console.WriteLine($"My car model is: {myObj.model}"); // accessing the field of the object
            Console.WriteLine($"My car max speed is: {myObj.maxSpeed} km/h"); // accessing the field of the object
        }
    }
}
*/

/*
using System;
namespace OOPExample2
{
    class Car
    {
        string? color;
        int maxSpeed;
        int year;

        static void Main(string[] args)
        {
            Car Audi = new Car();
            Audi.color = "Black";
            Audi.maxSpeed = 320;
            Audi.year = 2022;

            Car BMW = new Car();
            BMW.color = "White";
            BMW.maxSpeed = 300;
            BMW.year = 2021;

            Console.WriteLine("\nAudi Car Details:");
            Console.WriteLine($"Color: {Audi.color}");
            Console.WriteLine($"Max Speed: {Audi.maxSpeed} km/h");
            Console.WriteLine($"Year: {Audi.year}");

            Console.WriteLine("\nBMW Car Details:");
            Console.WriteLine($"Color: {BMW.color}");
            Console.WriteLine($"Max Speed: {BMW.maxSpeed} km/h");
            Console.WriteLine($"Year: {BMW.year}");

            Console.ReadLine();
        }
    }
}
*/

//                 -------------------- Multiple Classes in C# --------------------
/*
using System;

// Class 1
class Student
{
    public string Name = "Aashik";

    public void ShowStudent()
    {
        Console.WriteLine("Student Name: " + Name);
    }
}

// Class 2
class Teacher
{
    public string Subject = "Maths";

    public void ShowTeacher()
    {
        Console.WriteLine("Teacher Subject: " + Subject);
    }
}

// Main Class
class Program
{
    static void Main()
    {
        // Student object
        Student s = new Student();
        s.ShowStudent();

        // Teacher object
        Teacher t = new Teacher();
        t.ShowTeacher();
    }
}

*/

//               ------------------------------ C# Constructor ------------------------------
/*
A constructor is a special method that is automatically called when an object of a class is created.
The purpose of a constructor is to initialize the object's properties (fields) with default or specified values.


✔ object initialize பண்ண
✔ default values set பண்ண
✔ starting work automatic execute பண்ண

👉 Constructor =
“object create ஆனதும் automatic run ஆகும் method”


//The syntax for defining a constructor in C# is as follows:

class ClassName
{
    // Constructor
    public ClassName(parameters) // the constructor has the same name as the class and can take parameters to initialize the object's properties
    {
        // code to initialize the object's properties
    }
}
*/

/*
===> Constructor has 4 types:
1. Default Constructor: A constructor that takes no parameters and initializes the object's properties with default values.

2. Parameterized Constructor: A constructor that takes parameters to initialize the object's properties with specified values.

3. Copy Constructor: A constructor that creates a new object as a copy of an existing object.

4. Static Constructor: A constructor that is used to initialize static members of the class and is called only once, when the class is first loaded.

*/  

// ===> Parameterless Constructor or Default Constructor
/*

using System;
namespace OOPExample3
{
    class Car
    {
        public string? model;       // field (attribute)
        public string? color;       // field (attribute)
        public int maxSpeed;        // field (attribute)
        public int year;            // field (attribute)

        // Parameterless Constructor
        public Car() // constructor with no parameters to initialize the object's properties with default values
        {
            model = "Toyota";
            color = "Red";
            maxSpeed = 200;
            year = 2020;
        }
        static void Main(string[] args)
        {
            Car myObj = new Car(); // creating another object (instance) of the Car class using the parameterless constructor
            Console.WriteLine($"My car color is: {myObj.color}"); // accessing the field of the object
            Console.WriteLine($"My car model is: {myObj.model}"); // accessing the field of the object
            Console.WriteLine($"My car max speed is: {myObj.maxSpeed} km/h"); // accessing the field of the object
            Console.WriteLine($"My car year is: {myObj.year}"); // accessing the field of the object
        }
    }
}
*/

// ===> Parameterized Constructor
/*
using System;
namespace OOPExample3
{
    class Car
    {
        public string? model;       // field (attribute)
        public string? color;       // field (attribute)
        public int maxSpeed;        // field (attribute)
        public int year;            // field (attribute)

        // Parameterized Constructor
        public Car(string themodel, string thecolor, int themaxSpeed, int theyear) // constructor with parameters to initialize the object's properties with specified values
        {
            model = themodel; // differentiate between the parameter and the field with the same name
            color = thecolor;
            maxSpeed = themaxSpeed;
            year = theyear;
        }
        static void Main(string[] args)
        {
            Car myObj = new Car("Honda", "Blue", 250, 2021); // creating another object (instance) of the Car class using the parameterized constructor
            Console.WriteLine($"My car color is: {myObj.color}"); // accessing the field of the object
            Console.WriteLine($"My car model is: {myObj.model}"); // accessing the field of the object
            Console.WriteLine($"My car max speed is: {myObj.maxSpeed} km/h"); // accessing the field of the object
            Console.WriteLine($"My car year is: {myObj.year}"); // accessing the field of the object
        }
    }
}
*/

// ===> Copy Constructor
/*
using System;

namespace OOPExample3
{
    class Car
    {
        public string? model;
        public string? color;
        public int maxSpeed;
        public int year;

        // Parameterized Constructor (original object create panna)
        public Car(string Model, string Color, int MaxSpeed, int Year)
        {
            model = Model;
            color = Color;
            maxSpeed = MaxSpeed;
            year = Year;
        }

        // Copy Constructor
        public Car(Car existingCar)
        {
            model = existingCar.model;
            color = existingCar.color;
            maxSpeed = existingCar.maxSpeed;
            year = existingCar.year;
        }

        static void Main(string[] args)
        {
            // Original object
            Car originalCar = new Car("BMW", "Black", 300, 2022);

            // Copy object
            Car copiedCar = new Car(originalCar);

            Console.WriteLine("ORIGINAL CAR:");
            Console.WriteLine($"{originalCar.model}, {originalCar.color}, {originalCar.maxSpeed}, {originalCar.year}");

            Console.WriteLine("\nCOPIED CAR:");
            Console.WriteLine($"{copiedCar.model}, {copiedCar.color}, {copiedCar.maxSpeed}, {copiedCar.year}");
        }
    }
}

*/

// ===> Static Constructor
/*
using System;

class Car
{
    public string model;

    // Static constructor
    static Car()
    {
        Console.WriteLine("Static Constructor called (only once)");
    }

    // Normal constructor
    public Car(string m)
    {
        model = m;
        Console.WriteLine(model + " constructor called");
    }

    static void Main()
    {
        Car car1 = new Car("Toyota");
        Car car2 = new Car("Honda");
    }
}
*/

//                      --------------------- Access Modifiers in C# ---------------------
/*
Access modifiers are keywords used to specify the accessibility of classes, methods, and other members in C#. 
They control the visibility and accessibility of these members from other parts of the code. The main access modifiers in C# are:
1. Public: The member is accessible from any other code in the same assembly or another assembly that references it.
2. Private: The member is accessible only within the body of the class or struct in which it is declared.
3. Protected: The member is accessible within its class and by derived class instances.
4. Default (internal): If no access modifier is specified, the member is accessible only within the same assembly.
5. Protected Internal: The member is accessible within its class, by derived class instances, and within the same assembly.
*/

/*
class Car
{
    public string model;        // accessible from anywhere
    private string color;       // accessible only within the Car class
    protected int maxSpeed;     // accessible within the Car class and by derived classes
    internal int year;          // accessible only within the same assembly (internal)
    protected internal string brand;     // accessible within the Car class, by derived classes, and within the same assembly

    public void SetColor(string c)
    {
        color = c; // can access private member color within the class
    }

    public string GetColor()
    {
        return color; // can access private member color within the class
    }
}
*/
// ===> Public Access Modifier Example
/*
using System;
namespace OOP
{
    class Student
    {
        public string name = "John";

        public void Display()
        {
            Console.WriteLine("Welcome to C# Programming!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Console.WriteLine($"Student Name: {student1.name}");  // here we can access the public class from another class (Program) because it is public
            student1.Display(); // Output: Student Name: John

            Console.ReadLine();
        }
    } 
}
*/

// ===> Private Access Modifier Example
/*
using System;
namespace OOP
{
    class Student
    {
        private string name = "John";

        public void Display()
        {
            Console.WriteLine("Welcome to C# Programming!");
            Console.WriteLine($"Student Name: {name}"); // here we can access the private class within the same class (Student) because it is private
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            // Console.WriteLine($"Student Name: {student1.name}");  // This will cause a compile error because name is private
            student1.Display(); // Output: Student Name: John        // we can only call but cannot access the private member name from another class (Program) because it is private

            Console.ReadLine();
        }
    } 
}
*/

// ===> Protected Access Modifier Example
/*
using System;
namespace OOP
{
    class Student
    {
        protected string name = "John";

        public void Display()
        {
            Console.WriteLine("Welcome to C# Programming!");
            Console.WriteLine($"Student Name: {name}"); // here we can access the protected member name within the same class (Student) because it is protected
        }
    }
    class Program : Student // Program class inherits from Student class to access the protected member name
    {
        static void Main(string[] args)
        {
            Program student1 = new Program();
            student1.Display();
            Console.WriteLine($"Student Name: {student1.name}");  // here we can access the protected member name from another class (Program) because it is inherited from Student class
        }
    }
}
*/

// ===> Internal Access Modifier Example
/*
using System;
namespace OPP
{
    class Student
    {
        internal string name = "John";

        public void Display()
        {
            Console.WriteLine("Welcome to C# Programming!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            Console.WriteLine($"Student Name: {s.name}"); // here same project so we can access

        }
    }
}
*/

//                  ------------------- Properties and Encapsulation ---------------------
/*

<access_modifier> <return_type> <property_name>
{
    get {// body}
    set {// body}
}
*/

/*
using System;
namespace OOP
{
    class Program
    {
        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            } 
        }
    }
}
*/
/*
class Person
{
    private string name;  // field

    public string Name    // property
    {
        get {return name;}
        set {name = value;}
    }
}
*/
//===> Sample for Properties
/*
using System;

class Person
{
    private string name;  // field

    public string Name    // property
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
}

class Program
{
    static void Main()
    {
        Person p = new Person();

        // set value
        p.Name = "Aashik";

        // get value
        Console.WriteLine("Person Name: " + p.Name);
    }
}
*/

// ===> Automatic Properties(Short Hand)
/*
using System;
namespace OPP
{
    class Person
    {
        public string? Name {get; set;}
    }

    class Program
    {
        static void Main()
        {
            Person p = new Person();
            p.Name = "Aashik";

            Console.WriteLine("Person Name: " + p.Name);
        }
    }
}
*/

// Type of Properties
/*
1. Read and Write Properties : Property contains get and set methods
2. Read only Properties      : Property contains get method only
3. Write only Properties     : Property contains set method only
*/

// ===> 1. Read and Write Properties
/*
using System;
namespace OPP
{
    class Student
    {
        private string? StudentID;
        private string? Name;
        private int Age; 

        public string studentID
        {
            get
            {
                return StudentID??" ";
            }
            set
            {
                StudentID = value;
            }
        }

        public string name
        {
            get
            {
                return Name??"";
            }
            set
            {
                Name = value;
            }
        } 
        public int age
        {
            get
            {
                return Age;
            }
            set
            {
                Age = value;
            }
        } 
        public override string ToString()
        {
            return "    StudenID:  " + StudentID+
                   "    Name    :  " + Name+
                   "    Age     :  " + Age;
        }
        
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.studentID = "2351";
            student1.name = "AASHIK";
            student1.age = 21;

            Console.WriteLine("\nStudent Info: {0}",student1 );

            // Change the Age
            student1.age = 22;
            Console.WriteLine("\nStudent Info: {0}",student1 );

            Console.ReadLine();
        }
    }
}
*/


// ===> 2. Read-Only Properties
/*
using System;
namespace OPP
{
    class Student
    {
        private string? StudentID;
        private string? Name;
        private int Age; 

        public Student(string id, string name, int age)   // Constructor
        {
            StudentID = id;
            Name = name;
            Age = age;
        }

        public string studentID
        {
            get
            {
                return StudentID??" ";
            }
        }

        public string name
        {
            get
            {
                return Name??"";
            }
        } 
        public int age
        {
            get
            {
                return Age;
            }

        } 
        public override string ToString()
        {
            return "    StudenID:  " + StudentID+
                   "    Name    :  " + Name+
                   "    Age     :  " + Age;
        }       
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("2351","AASHIK",21);

            Console.WriteLine("\nStudent Info: {0}",student1 );

            //Console.WriteLine("\nStudent Info: \nStuden ID: {0} \nName: {1} \nAge: {2}",student1.studentID, student1.name, student1.age ); 
            // If we use this method, we don't need ToString()
            // We can use either properties or ToString(), not both for the same output

            Console.ReadLine();
        }
    }
}
*/

//                  ------------------- Inheritance ---------------------
/*
using System;
namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.speed = 300;

            Bicycle b = new Bicycle();
            b.speed = 40;

            Lorry l = new Lorry();
            l.speed = 180;

            
            c.Display("Car");
            Console.WriteLine($"Car speed is {c.speed}");
            Console.WriteLine($"Car's Wheels: {c.wheel}");
            Console.WriteLine("----------------------------------\n");

            b.Display("Bicycle");
            Console.WriteLine($"Bicycle speed is {b.speed}");
            Console.WriteLine($"Bicycle's Wheels: {b.wheel}");
            Console.WriteLine("----------------------------------\n");

            l.Display("Lorry");
            Console.WriteLine($"Lorry speed is {l.speed}");
            Console.WriteLine($"Lorry's Wheels: {l.wheel}");
            Console.WriteLine("----------------------------------\n");            

        }
    }
    class Vehicle
    {
        public int speed;


        public void Display(string VehicleName)
        {
            Console.WriteLine($"\nThis is a transport method for {VehicleName}");
        }
    }
    class Car : Vehicle         // inherit
    {
        public int wheel = 4;
    }
    class Bicycle : Vehicle
    {
        public int wheel = 2;
    }
    class Lorry : Vehicle
    {
        public int wheel = 6;
    }
}
*/

/*
using System;

namespace OOP
{
    class Person
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";

        // Constructor (optional but clean OOP)
        public Person() { }

        public void GetName()
        {
            Console.WriteLine($"\n{this.GetType().Name} Full Name is: {FirstName} {LastName}");
        }
    }

    class Employee : Person
    {
        public int empID { get; set; }
        public string Company { get; set; } = "";
    }

    class Student : Person
    {
        public int studentID { get; set; }
        public string Uni { get; set; } = "";
    }

    class Program
    {
        static void Main(string[] args)
        {
            // ===== Employee =====
            Employee emp = new Employee();

            Console.Write("\nEnter Employee First Name: ");
            emp.FirstName = Console.ReadLine() ?? "";

            Console.Write("Enter Employee Last Name: ");
            emp.LastName = Console.ReadLine() ?? "";

            Console.Write("Enter Employee Id: ");
            emp.empID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Company Name: ");
            emp.Company = Console.ReadLine() ?? "";

            // ===== Student =====
            Student s = new Student();

            Console.Write("\nEnter Student First Name: ");
            s.FirstName = Console.ReadLine() ?? "";

            Console.Write("Enter Student Last Name: ");
            s.LastName = Console.ReadLine() ?? "";

            Console.Write("Enter Student Id: ");
            s.studentID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter University Name: ");
            s.Uni = Console.ReadLine() ?? "";

            // ===== Output =====
            Console.WriteLine("\n----- Employee Details -----\n");
            emp.GetName();
            Console.WriteLine($"Employee ID: {emp.empID}");
            Console.WriteLine($"Employee Company: {emp.Company}");

            Console.WriteLine("\n----- Employee Details -----\n");
            s.GetName();
            Console.WriteLine($"Student ID: {s.studentID}");
            Console.WriteLine($"Student University: {s.Uni}");

            Console.ReadLine();
        }
    }
}
*/

// ==> Type of Inheritance 
/*

1. Single Inheritance
2. Multi-Level Inheritance
3. Hierachical Inheritance
4. Hybrid Inheritance
5. Multiple Inheritance

*/

//===> 1. Single Inheritance
/*
using System;
// Parent class
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}

// Child class (Single Inheritance)
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking");
    }
}

class Program
{
    static void Main()
    {
        Dog d = new Dog();

        d.Eat();   // Parent method
        d.Bark();  // Child method
    }
}
*/

//===> 2. Multi-Level Inheritance

// Grandparent → Parent → Child

/*
using System;

// Level 1 (Base class)
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}

// Level 2 (Derived from Animal)
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking");
    }
}

// Level 3 (Derived from Dog)
class Puppy : Dog
{
    public void Weep()
    {
        Console.WriteLine("Puppy is weeping");
    }
}

class Program
{
    static void Main()
    {
        Puppy p = new Puppy();

        p.Eat();   // from Animal
        p.Bark();  // from Dog
        p.Weep();  // from Puppy
    }
}
*/

//===> 3. Hierachical Inheritance

/*
        Animal
       /   |   \
     Dog  Cat  Cow

*/
/*
using System;

// Parent class
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}

// Child 1
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking");
    }
}

// Child 2
class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine("Cat is meowing");
    }
}

// Child 3
class Cow : Animal
{
    public void Moo()
    {
        Console.WriteLine("Cow is mooing");
    }
}

class Program
{
    static void Main()
    {
        Dog d = new Dog();
        d.Eat();
        d.Bark();

        Console.WriteLine();

        Cat c = new Cat();
        c.Eat();
        c.Meow();

        Console.WriteLine();

        Cow cw = new Cow();
        cw.Eat();
        cw.Moo();
    }
}
*/

//===> 4. Hybrid Inheritance

/*
        Animal
       /      \
     Dog      Cat
       |
     Puppy
*/
/*
using System;

// Parent class
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}

// Child 1 (Hierarchical)
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking");
    }
}

// Child 2 (Hierarchical)
class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine("Cat is meowing");
    }
}

// Sub-child (Multilevel)
class Puppy : Dog
{
    public void Weep()
    {
        Console.WriteLine("Puppy is weeping");
    }
}

class Program
{
    static void Main()
    {
        Puppy p = new Puppy();
        p.Eat();   // from Animal
        p.Bark();  // from Dog
        p.Weep();  // from Puppy

        Console.WriteLine();

        Cat c = new Cat();
        c.Eat();   // from Animal
        c.Meow();  // from Cat
    }
}
*/

//===> 5. Multiple Inheritance

/*
Parent1   Parent2
    \      /
     Child

*/
/*

// ❌ WRONG (C# doesn't allow this)
class Child : Parent1, Parent2
{
}

*/
/*
using System;

// Interface 1
interface IAnimal
{
    void Eat();
}

// Interface 2
interface IMachine
{
    void Start();
}

// Child class implementing multiple interfaces
class RobotDog : IAnimal, IMachine
{
    public void Eat()
    {
        Console.WriteLine("RobotDog is charging energy");
    }

    public void Start()
    {
        Console.WriteLine("RobotDog is starting");
    }
}

class Program
{
    static void Main()
    {
        RobotDog r = new RobotDog();

        r.Eat();    // from IAnimal
        r.Start();  // from IMachine
    }
}
*/

//            ---------------------- Polymorphism ----------------------

/*
===> Types of Polymorphism

1. Compile-time (Method Overloading)
2. Run-time (Method Overriding)

*/

//===> 1. Compile-time (Method Overloading)
/*
👉 same method name
👉 different parameters

*/
/*
using System;
namespace OOP
{
    class Calculator
    {
        // 2 parameters
        public int Add(int a, int b)     // same method
        {
            return a + b;
        }

        // 3 parameters
        public int Add(int a, int b, int c)  // seme method
        {
            return a + b + c;
        }

        // double type
        public double Add(double a, double b)  // same method
        {
            return a + b;
        }
    }

    class Program
    {
        static void Main()
        {
            Calculator c = new Calculator();

            Console.WriteLine(c.Add(2, 3));        // 2 ints
            Console.WriteLine(c.Add(2, 3, 4));     // 3 ints
            Console.WriteLine(c.Add(2.5, 3.5));    // double
        }
    }
}
*/

//===> 2. Run-time (Method Overriding)

// if you want to use parameter then ucan use only same parameter for perents and child class
/*
👉 same method name
👉 same parameters or no parameter in both(child and perents) class 


*/
/*
using System;
class Animal
{
    // This is Runtime Polymorphism
    // virtual in parent allows method overriding
    // override in child changes behavior
    public virtual void Sound()  //use virtual for perents class 
    {
        Console.WriteLine("Animal makes sound");
    }
}

class Dog : Animal
{
    public override void Sound()  // use override for child class
    {
        Console.WriteLine("Dog barks");
    }
}

class Cat : Animal
{
    public override void Sound()  // use override for child class
    {
        Console.WriteLine("Cat meows");
    }
}

class Program
{
    static void Main()
    {
        Animal a;

        a = new Dog();
        a.Sound();   // Dog barks

        a = new Cat();
        a.Sound();   // Cat meows
    }
}
*/

//                   ---------------------- Abstraction ----------------------

// Abstraction = Important details மட்டும் காட்டி,
// unnecessary details hide பண்ணுவது

// Abstraction can be achieved in 2 ways:
//   1. Abstract Class
//   2. Interface

//===> 1. Abstract class 
/*
1. Abstract methods can only be declared inside an abstract class. They cannot be written inside a normal class.
2. No body for abstract method
        // public abstract void mymethod(); // only declaration

3. Abstract class-ல் abstract methods + normal methods இரண்டும் இருக்கலாம்
4. Abstract class-ஐ object create பண்ண முடியாது
5. Abstract methods must be implemented in derived (child) class
*/

/*
using System;
namespace OOP
{

    // Abstract class
    abstract class Animal
    {
        // Abstract method (no body)
        public abstract void Sound();

        // Normal method (has body)
        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
    }

    // Derived class
    class Dog : Animal
    {
        // Must override abstract method
        public override void Sound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    class Program
    {
        static void Main()
        {
            Dog d = new Dog();

            d.Sound(); // Dog implementation
            d.Eat();   // Parent normal method
        }
    }
}
*/

// ===> 2. Interface

/*
1. No implementation
2. Only method declarations (no body)
3. Cannot create objects (cannot instantiate)
4. All methods are public by default
5. A class can implement multiple interfaces
        // interface A, interface B → class
6. Used to achieve abstraction
7. Used to achieve multiple inheritance in C#
*/


/*
 using System; 
// System library - Console.WriteLine use பண்ண

// Interface definition
interface IVehicle
{
    void Start(); // method declaration மட்டும் (body இல்ல)
    void Stop();  // method declaration மட்டும் (body இல்ல)
}

// Car class implements IVehicle interface
class Car : IVehicle
{
    public void Start()
    {
        Console.WriteLine("Car is starting"); 
        // Car start ஆகுற message print ஆகும்
    }

    public void Stop()
    {
        Console.WriteLine("Car is stopping");
        // Car stop ஆகுற message print ஆகும்
    }
}

// Main program execution starts here
class Program
{
    static void Main()
    {
        Car c = new Car(); 
        // Car object create பண்ணுறோம்

        c.Start(); 
        // Start method call ஆகுது

        c.Stop();
        // Stop method call ஆகுது
    }
}
*/

//===> Implementing Multiple Interfaces
/*
using System;
namespace Implementing_Multiple_Interfaces
{
    interface IPlygon
    {
        void CalculateArea(int x, int y);
    }
    interface IColor
    {
        void GetColor();
    }
    class Rectangle : IPlygon,IColor
    {
        //Implementing IPolygon
        public void CalculateArea(int x, int y)
        {
            int area = x*y;
            Console.WriteLine($"Area of Rectangle: {area}");
        }

        //Implementing Icolor
        public void GetColor()
        {
            Console.WriteLine("Blue Rectangle");
        }
    }
    class Program
    {
        static void Main()
        {
            Rectangle rect = new Rectangle();

            rect.CalculateArea(8,9);
            rect.GetColor(); 
        }
    }
}
*/


