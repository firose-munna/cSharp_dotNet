using cSharp_dotNet.Array_String;
using cSharp_dotNet.calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_dotNet
{
   


    internal class Program
    {
        



        static void Main(string[] args)
        {
            
            //This is My first classes instant.....
            WelcomeClass hello = new WelcomeClass();

            hello.ShowMessage();

            Console.WriteLine();
            //This is second class... primitive data type 
            DataType data1 = new DataType();
            data1.number1 = 45;
            data1.number2 = 455.45f;
            data1.letter = 'b';

            data1.showData();

            Console.WriteLine();
            // this is the range 
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);


            Console.WriteLine();
            //this is the constant value which is  not reassignable.....
            Console.WriteLine("This is the constant value-");
            const int number = 45;
            const float Pi = 3.1416f;

            Console.WriteLine("the integer const number is : " + number + " and the float consttnt number is : " + Pi);

            Console.WriteLine();
            //convertion the value
            string textNumber = "12345";
            int number3 = int.Parse(textNumber);
            Console.WriteLine("The Converted Number is : " + number3);

            int number4 = Convert.ToInt32(textNumber);
            Console.WriteLine("This is the another way to change the text number : " + number4);

            Console.WriteLine();
            //this is the try catch block
            try
            {
                byte number5 = Convert.ToByte(textNumber);
                Console.WriteLine(number5);
            }
            catch(Exception)
            {
                Console.WriteLine("It will not to convert. Because there are a exception is occured.");
            }


            Console.WriteLine();
            //Arithmetic Operator....
            int num1 = 50;
            int numb2 = 13;

            Console.WriteLine(num1 + numb2);
            Console.WriteLine(num1 - numb2);
            Console.WriteLine(num1 * numb2);
            Console.WriteLine(num1 / numb2);
            Console.WriteLine((float)num1 / (float)numb2);

            int result = Calculate.Add(num1, numb2);
            Console.WriteLine("This Add Method is define the outsite the Program.cs file : " + result);



            Console.WriteLine();
            //Array-String Class

            var arrayString = new ArrayString();
            arrayString.ShowNumbers();


            var names = new string[2] { "Firose", "Munna" };
            var joinnedName = string.Join(", ", names);
            var formattedName = string.Format("In a variable : {0} {1}", names[0], names[1]);


            Console.WriteLine(joinnedName);
            Console.WriteLine(formattedName);



            //Value and reference type 
            Console.WriteLine();
            ValueReference();

            //Conditional statement
            Console.WriteLine();
            Conditional();


            //excercise 1 
            Console.WriteLine();
            Excercise1();

            //excercise 2
            Console.WriteLine();
            int n1;
            int n2;

            Console.WriteLine("Enter the first number - ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number - ");
            n2 = Convert.ToInt32(Console.ReadLine());

            int r = MaxNumber(n1, n2);

            Console.WriteLine("Maximum number of these two number is : " + r);

            //Excercise 3
            ImageSize();

            //Iteration
            Console.WriteLine();
            Console.WriteLine("loops-");
            Iteration();



            //Random PassWord
            Console.WriteLine();
            Console.WriteLine("Random Password - ");

            RandomNumber();


            //Practice 1
            Console.WriteLine();
            Practice1();


            Console.ReadLine();
        }

        static void ValueReference()
        {
            int number1 = 10;
            int number2 = number1;

            number2++;

            Console.WriteLine(string.Format("Number 1 : {0} and Number 2 : {1}", number1, number2));


            var numbers = new int[3] { 2, 3, 5 };
            var numbers2 = numbers;

            numbers2[0] = 8;

            Console.WriteLine(string.Format("Numbers[0] : {0} and Numbers2[0] : {1}.", numbers[0], numbers2[0]));
        }

        static void Conditional()
        {
            int score = 5;
            string status;
            string grade;


            if(score >=80 && score <= 100)
            {
                status = "Pass";
                grade = "A+";
            }
            else if (score >= 70 && score < 80)
            {
                status = "Pass";
                grade = "A";
            }
            else if (score >= 60 && score < 70)
            {
                status = "Pass";
                grade = "A-";
            }
            else if (score >= 50 && score < 60)
            {
                status = "Pass";
                grade = "B";
            }
            else
            {
                status = "Fail";
                grade = "F";
            }

            Console.WriteLine(string.Format("Using If-Else Statement....Congrats, You are {0} and the Grade is {1}.", status, grade));



            string ternaryStatus = (score >=50) ? "Passed" : "Failed";
            Console.WriteLine(string.Format("Using Ternary Statement....Congrats, You are {0}.", ternaryStatus));



            int day = 5;

            switch(day)
            {
                case 1:
                    Console.WriteLine("Saterday");
                    break;
                case 2:
                    Console.WriteLine("Sunday");
                    break;
                case 3:
                    Console.WriteLine("Monday");
                    break ; 
                case 4:
                    Console.WriteLine("TuesDay");
                    break;
                case 5:
                    Console.WriteLine("Wednesday");
                    break;
                case 6:
                    Console.WriteLine("Thursday");
                    break;
                case 7:
                    Console.WriteLine("Friday" );
                    break;

                default:
                    Console.WriteLine("No day available");
                    break;

            }

        }

        static void Excercise1()
        {
            
            Console.WriteLine("Enter a number berween 1 to 10-");
            int number =  Convert.ToInt32((string) Console.ReadLine());

            string output = (number>=1 && number<=10) ? "Valid" : "Invalid";

            Console.WriteLine("The User Input is : " + output);

            
        }

        static int MaxNumber(int n1, int n2)
        {
            if (n1 > n2) { 
                return n1;
            }
            else
            {
                return n2;
            }
        }

        static void ImageSize()
        {
            Console.WriteLine("Enter the Width of the image-");
            int w = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Height of the image-");
            int h = Convert.ToInt32(Console.ReadLine());

            if(w > h)
            {
                Console.WriteLine("The Image is LandScape.");
            }
            else if(w < h)
            {
                Console.WriteLine("The Image id Portrait");
            }
            else
            {
                Console.WriteLine("Image is Square Size");
            }
        }


        static void Iteration()
        {
            //For Loop
            for (int i = 0; i < 10; i++)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();

            int[] numbers = new int[10] { 56,45,48,12,11,9,36,46,89,66};

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            while (true)
            {
                string name;
                Console.Write("Enter your name : ");
                name = Console.ReadLine();

                if (String.IsNullOrEmpty(name))
                {
                    break;
                }
                Console.WriteLine("Your name : " + name);
            }
        }

        static void RandomNumber()
        {
            const int length = 20;
            var random = new Random();
            var buffer = new char[length];

            for( int i = 0; i < length; i++ )
            {
                buffer[i] = (char)('a' + random.Next(0, 26));
            }

            var password = new string(buffer);

            Console.WriteLine("The Password is : " + password);
        }

        static void Practice1()
        {
            int count = 0;

            for(int i = 1; i<=100; i++)
            {
                if(i%3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Total number of divisible by 3 : " +count);
        }
    }
    //This is the another class outsite the Main Class
    public class WelcomeClass
    {
        public string welcome = "Hello, My name is Firose Munna. I am a Trainee Software Engineer of BSS.";

        public void ShowMessage()
        {
            Console.WriteLine(welcome);
        }
    }

    //This is also the another class outsite the Main class....
    public class DataType
    {
        public int number1;
        public float number2;
        public char letter;
        public void showData()
        {
            Console.WriteLine("The Integer Valu is : " + number1);
            Console.WriteLine("The Float Value is : " + number2);
            Console.WriteLine("The Char is : " + letter);
        }
    }

}
