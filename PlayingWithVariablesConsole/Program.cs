using System;

namespace PlayingWithVariablesConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable Declarations
           
            string name;
            int age;
            char dataType;
            bool isAnnoyed;
            double y = 4.3;
            decimal x = 2.1m;
            //Variable initializations
            age = 53;
            name = "Rob";
            dataType = 'A';
            isAnnoyed = true;





            Console.WriteLine($"{name} {age} {dataType} Software engineer. is he annoyed: {isAnnoyed}");
        }
    }
}
