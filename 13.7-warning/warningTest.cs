// warning directive test

#define DEBUG
public class MyClass
{
    public static void Main()
    {
#if DEBUG
#warning DEBUG is defined
//#error DEBUG is defined
#endif
    }
}
