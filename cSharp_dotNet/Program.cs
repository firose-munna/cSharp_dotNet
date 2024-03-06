using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_dotNet
{
    public class WelcomeClass
    {
        public string welcome = "Hello, My name is Firose Munna. I am a Trainee Software Engineer of BSS.";

        public void ShowMessage()
        {
            Console.WriteLine(welcome);
        }
    }

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





            Console.ReadLine();
        }
    }
}
