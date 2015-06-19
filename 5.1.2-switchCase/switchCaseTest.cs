// switch-case test

using System;
using System.IO;
class SwitchTest
{
    public static void Main()
    {
        Console.WriteLine("Coffee sizes: 1=Small 2=Medium 3=Large");
        Console.Write("Please enter your selection: ");
        string s = Console.ReadLine();
        int n = int.Parse(s);
        switch (n)
        {
            case 0:
                goto case 1;
            case 1:
                Console.WriteLine("You selected small size. Insert 50 cents.");
                break;
            case 2:
                Console.WriteLine("You selected medium size. Insert 75 cents.");
                break;
            case 3:
                Console.WriteLine("You selected large size. Insert $1.00.");
                break;
            default:
                Console.WriteLine("Invalid selection. Please select 1, 2, or 3.");
                break;
        }
        Console.WriteLine("Thank you for your business.");
        Console.ReadLine();
    }
}
