// event test 2: explicit event

using System;

public delegate void MyDelegate1();

public interface I1 
{
   event MyDelegate1 MyEvent;
}

public delegate int MyDelegate2(string s);

public interface I2 
{
   event MyDelegate2 MyEvent;
}

public class ExplicitEventsSample: I1, I2 
{
   public event MyDelegate1 MyEvent;  //I1.MyEvent的普通实现

   event MyDelegate2 I2.MyEvent   //I2.MyEvent的显式实现
   {
      add
      {
         MyEvent2Storage += value; 
      }
      remove 
      {
         MyEvent2Storage -= value; 
      }
   }

   private MyDelegate2 MyEvent2Storage;  //存储I2.MyEvent

   private void FireEvents() 
   {
      if (MyEvent != null)
         MyEvent();
      if (MyEvent2Storage != null)
         MyEvent2Storage("hello");
   }
}

public class MyClass 
{
   public static void Main() 
   {
   }
}
