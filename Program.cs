
using System.ComponentModel;
using System.Diagnostics.Metrics;

namespace ASS2_DEMO_Seesion3C__3mr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ASS2_DEMO_session3_3MR

            #region DEMO 

            #region value type casting

            #region implicit casting --> safe 

            //int x = 4;//4 bytes 
            //long y = x;  // (long)x do not important because int less thn from long 



            #endregion

            #region  explicit casting --> unsafe 
            //long x = 1010101000; // 8bytes  
            ////int y = x; // error because int less than from long

            ////int y = (int)x;
            ////Console.WriteLine(y);    // result is garbage 

            //int y;
            //checked
            //{
            //     y = (int)x;

            //    unchecked
            //    {

            //    }
            //    Console.WriteLine(y);
            //}
            // but double and int easy remove fractions 



            #endregion

            #region parse // convert from string to any data type 

            //int number = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Data User");

            //Console.Write("Enter Name: ");
            //string Name = Console.ReadLine();

            //Console.Write("Enter Age: ");
            //int Age = int.Parse(Console.ReadLine());

            //Console.Write("Enter Salary: ");
            //double Salary = double.Parse(Console.ReadLine());

            //Console.Clear();

            //Console.WriteLine("Name: " + Name + " Age: " + Age + " Salary: " + Salary);

            #endregion

            #region convert // convert from any data type to any data type 

            //int number = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Data User");

            //Console.Write("Enter Name: ");
            //string Name = Console.ReadLine();

            //Console.Write("Enter Age: ");
            //int Age = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter Salary: ");
            //double Salary = Convert.ToDouble(Console.ReadLine());

            //Console.Clear();

            //Console.WriteLine("Name: " + Name + " Age: " + Age + " Salary: " + Salary);


            #endregion




            #endregion

            #region Operators

            #region Unary Operators [++, --]

            //int x = 5;

            // ++x;  
            // x++;  

            // Console.WriteLine(++x); 
            // Console.WriteLine(x);   

            // Console.WriteLine(--x); 
            // Console.WriteLine(x--);  
            // Console.WriteLine(x);    

            #endregion

            #region Binary Operators

            //int Sum, Mul, Sub, Div, Mod;

            //int A = 8;
            //int B = 5;

            //Sum = A + B; // 15
            //Sub = A - B; // 3
            //Div = A / B; // 2
            //Mul = A * B; // 4
            //Mod = A % B; // 3

            //Console.WriteLine(Sum);

            #endregion

            #region Assignment Operators

            //int x = 10;

            //x += 10; //20
            //x -= 10; //0
            //x *= 10; //100
            //x /= 10; //1
            //x %= 10; //0

            #endregion

            #region Relational Operators

            //int A = 5;
            //int B = 10;

            //Console.WriteLine(A < B);

            #endregion

            #region Logical Operators [short circut] // check first condition enough if don not need second conditional

            //Console.WriteLine(!true);  

            //Console.WriteLine(true && false); 
            // True && True => True             
            // True && False => False           
            // False && True => False           
            // False && False => False          

            //Console.WriteLine(true || false); 
            // True || True => True
            // True || False => True
            // False || True => True
            // False || False => False

            #endregion

            #region Bitwise Operators [Long Circuit]

            // Console.WriteLine(true & false); 

            // True & True => True
            // True & False => False
            // False & True => False
            // False & False => False

            // Console.WriteLine(true || false);

            // True || True => True
            // True || False => True
            // False || True => True
            // False || False => False

            #endregion

            #region Ternary Operator [Conditional Operator]

            //int x = 3;

            //string message = x > 4 ? "X Greater Than 4" : "X Less than Or Equal 4";

            //Console.WriteLine(message);

            #endregion

            #endregion

            #region Operator Priority

            // 1. Unary Operator [PreFix]
            // 2. ()
            // 3. *, /, %
            // 4. +, -

            //int A = 20;
            //int B = 15;
            //int C = 10;
            //int D = 5;

            //int Result;

            //Result = (A + B) * C / D; 

            //Result = ++A * C; 

            //Result = A * C; 

            //Console.WriteLine(Result);

            #endregion

            #region String Formatting

            // Equation = X + Y = Result
            // Equation = 10 + 5 = 15

            //int X = 5;
            //int Y = 10;
            //int Result = X + Y;

            //Console.WriteLine("Equation : " + X + " + " + Y + " = " + Result);
            // // String => Immutable Datatype
            // //string Name = "Ahmed";
            // //Name = "Ali";

            #region 1. Composite Format
            //string message = string.Format("Equation = {0} + {1} = {2}", X, Y, Result);
            //Console.WriteLine(message);
            //Console.WriteLine("Equation = {0} + {1} = {2}", X, Y, Result);
            #endregion

            #region 2.String Manipulation
            // string Interpolation => $

            //Console.WriteLine($"Equation = {X} + {Y} = {Result}");
            #endregion

            #endregion

            #region IF Else - Switch Case
            //Console.WriteLine("Enter Month Number");
            //int MonthNumber = int.Parse(Console.ReadLine());
            //// 1 => Month is Jan
            //// 2 => Month is Feb
            //// 3 => Month is Mar
            //// Invalid Input
            //if (MonthNumber == 1)
            //{
            //    Console.WriteLine("Month is Jan");
            //}
            //else if (MonthNumber == 2)
            //{
            //    Console.WriteLine("Month is feb");
            //} else if (MonthNumber == 3)
            //{
            //    Console.WriteLine("Month is mar");
            //} else  
            //{
            //    Console.WriteLine("invalid input");
            //}



            //switch (MonthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Month is Jan");
            //        break;
            //    case 2:
            //        Console.WriteLine("Month is Feb");
            //        break;
            //    case 3:
            //        Console.WriteLine("Month is Mar");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Input");
            //        break;
            //}








            #endregion

            #region GoTo
            //Console.WriteLine("Enter Option");

            //// 3000 => "Option 01", "Option 02", "Option 03"
            //// 2000 => "Option 01", "Option 02"
            //// 1000 => "Option 01"

            //int Option = int.Parse(Console.ReadLine());

            //switch (Option)
            //{
            //    case 3000:
            //        Console.WriteLine("Option 03");
            //        goto case 2000;
            //    case 2000:
            //        Console.WriteLine("Option 02");
            //        goto case 1000;
            //    case 1000:
            //        Console.WriteLine("Option 01");
            //        break;
            //}
            #endregion


            #endregion

            #region Answer ASS

            #region q1
            //q1)
            // 1 - Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.

            //Console.WriteLine("please enter number for check ? ");
            //int number =  int.Parse(Console.ReadLine()); 

            //if (number % 3 == 0 && number % 4 ==0 )
            //{
            //    Console.WriteLine("Input :" + number ); 
            //    Console.WriteLine(" Outputr : YES ");

            //}
            //else
            //{
            //    Console.WriteLine("Input :" + number);

            //    Console.WriteLine("Output : NO ");

            //}

            #endregion

            #region q2

            //Q2)
            // 2 - Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.

            //Console.WriteLine("please enter number for check ? ");
            //int number = int.Parse(Console.ReadLine());

            //if (number < 0)
            //{
            //    Console.WriteLine("Input :" + number);
            //    Console.WriteLine("Outputr : Negative ");

            //}
            //else
            //{
            //    Console.WriteLine("Input :" + number);
            //    Console.WriteLine("Output : Positive ");

            //}


            #endregion

            #region q3

            //Q3)
            //3- Write a program that takes 3 integers from the user then prints the max element and the min element.


            // Console.WriteLine("please enter number1 for check ? ");
            // int number1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("please enter number2 for check ? ");
            //int number2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("please enter number3 for check ? ");
            //int number3 = int.Parse(Console.ReadLine());


            // int max = number1; 
            // int min = number1;

            // if (number1 > number2 && number1> number3 && number2< number3)
            // {
            //    max = number1;
            //    min = number2; 

            // }

            //else if (number1 > number2 && number1 > number3 && number3 < number2)
            //{
            //    max = number1;
            //    min = number3;

            //}
            //else if(number2 > number1 && number2 > number3 && number1 < number3)
            // {
            //    max = number2;
            //    min = number1;

            //}
            //else if (number2 > number1 && number2 > number3 && number3 < number2)
            //{
            //    max = number2;
            //    min = number3;

            //}
            //else if(number3 > number1 && number3 > number2 && number1 < number2)
            //{
            //    max = number3;
            //    min = number1;
            //}
            //else
            //{
            //    max = number3;
            //    min = number2;
            //}

            //Console.WriteLine("Input :" + number1 + "," + number2 + ',' + number3);
            //Console.WriteLine("Output : ");
            //Console.WriteLine("max element = " + max);
            //Console.WriteLine("min element = " + min);

            #endregion

            #region q4
            //q4)
            //  Write a program that allows the user to insert an integer number then check If a number is even or odd.

            //Console.WriteLine("please enter number for check ? ");
            //int number =  int.Parse(Console.ReadLine()); 

            //if (number % 2 == 0 )
            //{
            //    Console.WriteLine("Input :" + number ); 
            //    Console.WriteLine(" Outputr : EVEN ");

            //}
            //else
            //{
            //    Console.WriteLine("Input :" + number);

            //    Console.WriteLine("Output : ODD ");

            //}
            #endregion

            #region q5
            //q5)
            //  5- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).


            //Console.WriteLine("please enter character for check ? ");
            //char character =  char.Parse(Console.ReadLine()); 

            //if (character  == 'a' )
            //{
            //    Console.WriteLine("Input :" + character ); 
            //    Console.WriteLine(" Outputr : vowel ");

            //}
            //else if (character  == 'e' )
            //{
            //    Console.WriteLine("Input :" + character);

            //    Console.WriteLine("Output : vowel ");

            //}
            //else if (character  == 'I' )
            //{
            //    Console.WriteLine("Input :" + character);

            //    Console.WriteLine("Output : vowel ");

            //} 
            //else if (character  == 'o' )
            //{
            //    Console.WriteLine("Input :" + character);

            //    Console.WriteLine("Output : vowel ");

            //}
            //else if (character  == 'u' )
            //{
            //    Console.WriteLine("Input :" + character);

            //    Console.WriteLine("Output : vowel ");

            //}
            // else 
            //{
            //    Console.WriteLine("Input :" + character);
            //    Console.WriteLine("Output : consonant ");
            //}
            #endregion

            #region q7

            //Q7)
            // 7 - Write a program that allows the user to insert an integer then
            //print a multiplication table up to 12.

            //Console.WriteLine("please enter number for process ? ");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 1 ; i <= 12; i++)
            //{
            //    Console.Write(number * i + "   ");
            //}



            #endregion

            #region q9

            //Q9)
            // 9- Write a program that takes two integers then prints the power.

            //Console.WriteLine("please enter number1 ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("please enter power ");
            //int power = int.Parse(Console.ReadLine());

            //Console.WriteLine("input :" + number1 + " power " + power);
            //int result=1; 
            //for (int i = 1 ; i <= power; i++)
            //{
            //    result *= number1 ;
            //}

            // Console.WriteLine("output :" + result); 



            #endregion

            #region q10

            //Q10)
            //Write a program to enter marks of five subjects and calculate total, average and percentage.

            //int sum=0; 
            //for (int i = 1 ; i <= 5; i++)
            //{
            //Console.WriteLine("please enter sub "+ i);
            //sum += int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("total marks : " + sum );
            //Console.WriteLine("average : " + sum/5);
            //double percent = (sum / 5);
            //Console.WriteLine("percent : " + percent); 



            #endregion

            #region q11
            //Q11)
            //11 - Write a program to input the month number and print the number of days in that month.

            //Console.WriteLine("Enter Month Number (1-12):");
            //int monthNumber = int.Parse(Console.ReadLine());

            //int daysInMonth;

            //switch (monthNumber)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        daysInMonth = 31;
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        daysInMonth = 30;
            //        break;
            //    case 2:
            //        Console.WriteLine("Enter Year:");
            //        int year = int.Parse(Console.ReadLine());
            //        daysInMonth = (year % 4 == 0 && year % 100 != 0) || year % 400 == 0 ? 29 : 28;
            //        break;
            //    default:
            //        Console.WriteLine("Invalid month number.");
            //        return;
            //}

            //Console.WriteLine("Days in Month: " + daysInMonth);


            #endregion

            #region q17
            //q17)
            //17- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.

            //Console.WriteLine("Enter the coordinates of three points:");

            //Console.Write("x1: ");
            //int x1 = int.Parse(Console.ReadLine());

            //Console.Write("y1: ");
            //int y1 = int.Parse(Console.ReadLine());

            //Console.Write("x2: ");
            //int x2 = int.Parse(Console.ReadLine());

            //Console.Write("y2: ");
            //int y2 = int.Parse(Console.ReadLine());

            //Console.Write("x3: ");
            //int x3 = int.Parse(Console.ReadLine());

            //Console.Write("y3: ");
            //int y3 = int.Parse(Console.ReadLine());

            //// Calculate slopes between pairs of points
            //double slope12 = (double)(y2 - y1) / (x2 - x1);
            //double slope23 = (double)(y3 - y2) / (x3 - x2);
            //double slope13 = (double)(y3 - y1) / (x3 - x1);

            //if (slope12 == slope23 && slope12 == slope13)
            //{
            //    Console.WriteLine("The points are collinear.");
            //}
            //else
            //{
            //    Console.WriteLine("The points are not collinear.");
            //}


            #endregion

            #region q18
            //q18)
            //18- Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows: 
            //    -If the worker completes the job within 2 to 3 hours, they are considered highly efficient.
            //    - If the worker takes 3 to 4 hours, they are instructed to increase their speed.
            //    - If the worker takes 4 to 5 hours, they are provided with training to enhance their speed.
            //    - If the worker takes more than 5 hours, they are required to leave the company.
            //    To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.

            //Console.WriteLine("Enter the time taken to complete the task (in hours):");
            //double timeTaken = double.Parse(Console.ReadLine());

            //if (timeTaken >= 2 && timeTaken < 3)
            //{
            //    Console.WriteLine("Highly Efficient Worker!");
            //}
            //else if (timeTaken >= 3 && timeTaken < 4)
            //{
            //    Console.WriteLine("Please increase your speed.");
            //}
            //else if (timeTaken >= 4 && timeTaken < 5)
            //{
            //    Console.WriteLine("Training required to enhance speed.");
            //}
            //else if (timeTaken >= 5)
            //{
            //    Console.WriteLine("Worker needs to leave the company.");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a positive number.");
            //}

            #endregion

            #region q21
            //q21)
            //Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen



            //int a = 10;
            //int b = a;
            //b = 20;

            //Console.WriteLine("Original variable a:" + a);
            //Console.WriteLine("Modified variable b:" + b);
            //Console.WriteLine("Value types store a copy of the value. Modifying one does not affect the other.");
            #endregion

            #region  q22
            //q22)
            /*Write a C# program that assigns one reference type variable
             to another and modifies the object through one variable,
             and mention what will happen.*/

            //string text1 = "Hello";
            //string text2 = text1;


            //text2 = "Helloooooooooooooooooooo";


            //Console.WriteLine("Value of text1: " + text1);
            //Console.WriteLine("Value of text2: " + text2);
            //Console.WriteLine("Reference types share the same memory address. Modifying one affects the other.");




            #endregion

            #region q23
            //q23)
            //23 - Which of the following statements is correct about the C#.NET code snippet given below?

            //b)A value 1 will be assigned to d Because (!(30<20)) = true = 1 

            #endregion

            #region q24
            //q24)
            //24 - Which of the following is the correct output for the C# code given below?

            //d)6 1 Because int remove fraction 

            #endregion

            #region q25
            //q25)
            //25 - What will be the output of the C# code given below?


            //int num = 1, z = 5;


            //if (!(num <= 0)) // true
            //    Console.WriteLine(++num + z++ + " " + ++z);
                                                                //condition = true so 
                                                                // ++num = 2 
                                                                // z++ = 5 in process , 6 after process
                                                                // this is part = 7 
                                                                // " " 
                                                                // ++z = 6 +1 = 7 
                                                                // output  7 7 
            //else
            //    Console.WriteLine(--num + z-- + " " + --z);



            #endregion

            #endregion


            #endregion
        }
    }
}
