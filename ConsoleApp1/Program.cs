using System;
using System.Runtime.CompilerServices;
internal class Program
{
    private static void Main(string[] args)
    {
        string response;
        string anwser;
        response = Console.ReadLine();
        Converter(response);
        static void Converter(string value)
        {
        for (int i = value.Length-1; i >= 0; i--)
        { 
            Console.WriteLine(value[i]);
            if (Char.ToString(value[i]) == "0" || Char.ToString(value[i]) == "1")
            {
                
            }
            else
            {
                value = "Not a binary number";
                Console.WriteLine(value);
            }
        }
        }

    }
     //Binary To Decimal converter
}