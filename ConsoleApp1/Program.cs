using System;
public class Program
{
    
    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter a binary number to convert to decimals");   
        Converter();
        static void Converter()
        {
            bool alreadySaid = false;
            string value = Console.ReadLine();
            double number = 0;
            for (int i = value.Length-1; i >= 0; i--)
            { 
                if (Char.ToString(value[i]) == "0" || Char.ToString(value[i]) == "1")
                {
                    if (Char.ToString(value[i]) == "1")
                    {
                        number = number + Math.Pow(2,(value.Length-1)-i);
                    }             
                }
                else
                {
                    if (alreadySaid==false)
                    {
                        alreadySaid=true;
                        Console.WriteLine("Not a binary number");
                    }                   
                }
            }
        Console.WriteLine("Outbut: "+number);
        Console.WriteLine("Please enter a binary number to convert to decimals");
        Converter();

        }
    }
}