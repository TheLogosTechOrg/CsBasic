// test string

using System;

class StringTest 
{
    public static void Main( String[] args ) 
    {
        string a = "\u0068ello ";
        string b = "world";
        Console.WriteLine( a + b );
        Console.WriteLine( a + b == "hello world" );
        Console.ReadLine();
    }
}
