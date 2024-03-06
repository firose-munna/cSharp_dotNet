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


            //This is second class... primitive data type 
            DataType data1 = new DataType();
            data1.number1 = 45;
            data1.number2 = 455.45f;
            data1.letter = 'b';

            data1.showData();

           // this is the range 
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);


            //this is the constant value which is  not reassignable.....
            Console.WriteLine("This is the constant value-");
            const int number = 45;
            const float Pi = 3.1416f;

            Console.WriteLine("the integer const number is : " + number + " and the float consttnt number is : " + Pi);

            //convertion the value
            string textNumber = "12345";
            int number3 = int.Parse(textNumber);
            Console.WriteLine("The Converted Number is : " + number3);

            int number4 = Convert.ToInt32(textNumber);
            Console.WriteLine("This is the another way to change the text number : " + number4);

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



            Console.ReadLine();
        }
    }
}
