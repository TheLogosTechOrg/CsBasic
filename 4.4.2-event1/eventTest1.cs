// event test 2: using event property to realize different event combinations 

using System;
using System.Collections;

public delegate void MyDelegate1(int i);
public delegate void MyDelegate2(string s);
public delegate void MyDelegate3(int i, object o);
public delegate void MyDelegate4();

public class PropertyEventsSample 
{
   private Hashtable eventTable = new Hashtable();

   public event MyDelegate1 Event1 
   {
      add 
      {
         eventTable["Event1"] = (MyDelegate1) eventTable["Event1"] + value; 
      }
      remove 
      {
         eventTable["Event1"] = (MyDelegate1) eventTable["Event1"] - value; 
      }
   }

   public event MyDelegate1 Event2 
   {
      add 
      {
         eventTable["Event2"] = (MyDelegate1) eventTable["Event2"] + value;  
      }
      remove 
      {
          eventTable["Event2"] = (MyDelegate1)eventTable["Event2"] - value; 
      }
   }

   public event MyDelegate2 Event3 
   {
      add 
      {
         eventTable["Event3"] = (MyDelegate2) eventTable["Event3"] + value; 
      }
      remove 
      {
          eventTable["Event3"] = (MyDelegate2)eventTable["Event3"] - value; 
      }
   }

   public event MyDelegate3 Event4 
   {
      add 
      {
         eventTable["Event4"] = (MyDelegate3) eventTable["Event4"] + value; 
      }
      remove 
      {
          eventTable["Event4"] = (MyDelegate3)eventTable["Event4"] - value; 
      }
   }

   public event MyDelegate3 Event5 
   {
      add 
      {
         eventTable["Event5"] = (MyDelegate3) eventTable["Event5"] + value; 
      }
      remove 
      {
          eventTable["Event5"] = (MyDelegate3)eventTable["Event5"] - value; 
      }
   }

   public event MyDelegate4 Event6 
   {
      add 
      {
         eventTable["Event6"] = (MyDelegate4) eventTable["Event6"] + value; 
      }
      remove 
      {
          eventTable["Event6"] = (MyDelegate4)eventTable["Event6"] - value; 
      }
   }
}

public class MyClass 
{
   public static void Main() 
   {
   }
}
