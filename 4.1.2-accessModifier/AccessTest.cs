// access modifier test

using System;

namespace Logos.Cs.Basic
{
    public class T1
    {
        public static int myPublicInt;
        internal static int myInternalInt;
        private static int myPrivateInt = 0;

        public class M1
        {
            public static int myPublicInt;
            internal static int myInternalInt;
            private static int myPrivateInt = 0;
        }

        private class M2
        {
            public static int myPublicInt = 0;
            internal static int myInternalInt = 0;
            private static int myPrivateInt = 0;
        }
    }

    public class MainClass
    {
        public static int Main()
        {
            //访问T1的域：
            T1.myPublicInt = 1;      //访问不受限制
            T1.myInternalInt = 2;    //只能在当前工程中访问
            // T1.myPrivateInt = 3;  //错误：不能在T1外部访问

            //访问M1的域：
            T1.M1.myPublicInt = 1;     //访问不受限制
            T1.M1.myInternalInt = 2;   //只能在当前工程中访问
            // T1.M1.myPrivateInt = 3; //错误：不能在M1的外部访问

            //访问M2的域：
            // T1.M2.myPublicInt = 1;   //错误：不能在T1的外部访问
            // T1.M2.myInternalInt = 2; //错误：不能在T1的外部访问
            // T1.M2.myPrivateInt = 3;  //错误：不能在M2的外部访问

            return 0;
        }
    }
}
