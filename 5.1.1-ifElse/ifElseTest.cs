//if-else test

using System;
public class IfTest
{
    public static void Main()
    {
        // if - else
        Console.Write("Enter a character: ");
        char c = (char)Console.Read();
        if (Char.IsLetter(c))
            if (Char.IsLower(c))
                Console.WriteLine("The character is lowercase.");
            else
                Console.WriteLine("The character is uppercase.");
        else
            Console.WriteLine("The character is not an alphabetic character.");
        Console.ReadLine();

        // else if
        Console.Write("Enter a character: ");
        c = (char)Console.Read();
        if (Char.IsUpper(c))
            Console.WriteLine("The character is uppercase.");
        else if (Char.IsLower(c))
            Console.WriteLine("The character is lowercase.");
        else if (Char.IsDigit(c))
            Console.WriteLine("The character is a number.");
        else
            Console.WriteLine("The character is not alphanumeric.");
        Console.ReadLine();
        Console.ReadLine();
    }
}
