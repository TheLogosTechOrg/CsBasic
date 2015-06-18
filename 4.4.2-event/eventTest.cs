// event test

using System;

// step1: delegate definition
//声明代表，在声明事件之前必须先要有事件处理代表（完成前面介绍的第1步）
public delegate void EventHandlerDelegate();

// step2: event publisher
//声明带有事件的类，其中包含调用事件处理代表的方法（完成前面介绍的第2步）
public class ClassWithEvent
{
    // step2.1: event definition
    //创建事件处理代表
    public event EventHandlerDelegate EventHandler;

    // step2.2: event trigger
    //当事件发生时
    public void OnEvent()
    {
        if (EventHandler != null)
            //调用事件处理代表
            EventHandler();
    }
}

// step3: event listener 
//创建把方法和事件连接起来的类（完成前面介绍的第3步）
public class EventListener
{
    public EventListener(ClassWithEvent class_with_event)
    {
        // step3.1: linking event to event hanlder(s)
        class_with_event.EventHandler += new EventHandlerDelegate(fun1);
        class_with_event.EventHandler += fun2;
    }

    // step3.2: event handler(s)
    //和事件关联的方法
    static private void fun1()
    {
        Console.WriteLine("fun1: This is one method called when the event fires.");
    }

    //和事件关联的方法
    static private void fun2()
    {
        Console.WriteLine("fun2: This is another method called when the event fires.");
    }
}

//使用事件（完成前面介绍的第4步）
public class MainClass
{
    static public void Main()
    {
        //创建一个包含事件声明的类的对象
        ClassWithEvent event_object = new ClassWithEvent();

        //创建一个包含方法定义的类的对象
        EventListener event_listener = new EventListener(event_object);

        // step4: firing event
        //发出事件
        event_object.OnEvent();

        Console.ReadLine();
    }
}
