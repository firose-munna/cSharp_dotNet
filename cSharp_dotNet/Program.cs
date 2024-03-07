using cSharp_dotNet.Array_String;
using cSharp_dotNet.calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_dotNet
{
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
        public void showData() {
            Console.WriteLine("The Integer Valu is : " + number1);
            Console.WriteLine("The Float Value is : " + number2);
            Console.WriteLine("The Char is : " + letter);
        }
    }
    


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
    }
}
