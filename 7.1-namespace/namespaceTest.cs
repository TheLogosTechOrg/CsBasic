// namespace test
using System;

namespace SomeNameSpace
{
    public class MyClass
    {
        public static void Main()
        {
            Nested.NestedNameSpaceClass.SayHello();
            Console.ReadLine();
        }
    }

    namespace Nested   // 嵌套名字空间
    {
        public class NestedNameSpaceClass
        {
            public static void SayHello()
            {
                Console.WriteLine("Hello");
            }
        }
    }
}
