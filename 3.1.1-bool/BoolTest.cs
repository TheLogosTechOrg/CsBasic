// bool and char tests
// ×Ö·û²âÊÔ

using System;

public class BoolTest 
{
    public static void Main() 
    {
        Console.Write("Enter a character: ");    
        char c = (char) Console.Read();
        if (Char.IsLetter(c)) 
            if (Char.IsLower(c))
                Console.WriteLine("The character '"+c+"' is lowercase.");
            else
                Console.WriteLine("The character '" + c + "' is uppercase.");
        else
            Console.WriteLine("The character '" + c + "' is not an alphabetic character.");
        Console.ReadLine(); // this first ReadLine will accept the Enter key after the input of the character
        Console.ReadLine();
    }
}
