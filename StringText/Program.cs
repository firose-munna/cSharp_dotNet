using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringText
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //This is the different type of String operation here...
            var fullName = "   Firose Munna   ";

            Console.WriteLine("Without Trimming : '{0}'", fullName);
            Console.WriteLine("After Trimming : '{0}'", fullName.Trim());

            Console.WriteLine("After trim and convert uppercase : '{0}'", fullName.Trim().ToUpper());
            Console.WriteLine("After trim and convert uppercase : '{0}'", fullName.Trim().ToLower());


            var finalName = fullName.Trim();

            var index = finalName.IndexOf(' ');

            var firstName = finalName.Substring(0, index);

            var lastName = finalName.Substring(index + 1);

            Console.WriteLine("First Name :  {0} and Last Name : {1}", firstName, lastName);


            var str = "My name is Firose Mahmud Munna. I am the Trainee Software Engineer of BSS.";

            var newStr = str.Split(' ');

            foreach (var item in newStr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(str.Replace("name", "Name"));


            //This is for string to int or float convertion...
            var intStr = "12225";
            var floatNumber = 4552.52f;



            Console.WriteLine(Convert.ToInt32(intStr));
            Console.WriteLine(floatNumber.ToString("C0"));
            Console.WriteLine(floatNumber.ToString("C"));

            //this is for text summerization....
            var longSentence = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.";
            const int maxLength = 30;

            if(longSentence.Length < maxLength)
            {
                Console.WriteLine(longSentence);
            }
            else
            {
                var words = longSentence.Split(' ');
                var totaChar = 0;
                var summeryWords= new List<string>();
                 foreach (var word in words)
                {
                    summeryWords.Add(word);

                    totaChar += word.Length + 1;
                    if(totaChar > maxLength)
                    {
                        break;
                    }
                }
                var summary = String.Join(" ", summeryWords) + "...";

                Console.WriteLine(summary);
            }

            //this is for string builder
            var builder = new StringBuilder();

            builder.Append('-', 20);
            builder.AppendLine();
            builder.Append("Firose Munna");
            builder.AppendLine();
            builder.Append('-', 20);

            Console.WriteLine(builder);

            Console.ReadLine(); 
        }
    }
}
