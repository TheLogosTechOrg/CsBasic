// XML documentation test

using System;

/// <summary>
/// Class level summary documentation goes here.
/// </summary>
/// <remarks>
/// Longer comments can be associated with a type or member 
/// through the remarks tag
/// </remarks>
public class SomeClass
{
    /// <summary>
    /// Store for the name property
    /// </summary>
    private string myName = null;

    /// <summary>
    /// constructor for SomeClass
    /// </summary>
    public SomeClass()
    {
        //
        //在这里加上构造函数代码
        //
    }

    /// <summary>
    /// Name property 
    /// </summary>
    /// <value>
    /// A value tag is used to describe the property value
    /// </value>
    public string Name
    {
        get
        {
            if (myName == null)
            {
                throw new Exception("Name is null");
            }

            return myName;
        }
    }

    /// <summary>
    /// Description for <c>SomeMethod</c>, which is a method in <c>SomeClass</c>.
    /// <para>Here's how you could make a second paragraph in a description. <see cref="System.Console.WriteLine()"/> for information about output statements.</para>
    /// </summary>
    /// <param name="s"> Parameter description for s goes here</param>
    /// <seealso cref="SomeClass.Main"/>
    /// <seealso cref="String">
    /// You can use the cref attribute on any tag to reference a type or member 
    /// and the compiler will check that the reference exists. 
    /// </seealso>
    public void SomeMethod(string s)
    {
    }

    /// <summary>
    /// Some other method. 
    /// </summary>
    /// <returns>
    /// Return results are described through the returns tag, which is integer 0 in this case.
    /// </returns>
    /// <seealso cref="SomeMethod(string)">
    /// Notice the use of the cref attribute to reference a specific method 
    /// </seealso>
    /// <example> This sample shows how to call the GetZero method.
    /// <code>
    ///   class MyClass 
    ///   {
    ///      public static int Main() 
    ///      {
    ///         return GetZero();
    ///      }
    ///   }
    /// </code>
    /// </example>
    /// <permission cref="System.Security.PermissionSet">This is a public method. </permission>
    public int SomeOtherMethod()
    {
        return 0;
    }

    /// <summary>
    /// The entry point for the application. The <paramref name="args"/> parameter represents the command line arguments passed in. 
    /// </summary>
    /// <param name="args">A list of command line arguments</param>
    public static int Main(String[] args)
    {
        //
        //在这里加上开始应用程序的代码
        //
        return 0;
    }

}

/// <exception cref="System.Exception">This is an exception class.</exception>
/// <remarks>Here is an example of a bulleted list:
/// <list type="bullet">
///   <listheader>
///     <term>item 1</term>
///     <description>item 1 description</description>
///   </listheader>
/// <item>
///   <term>item 1</term>
///   <description>Item 1.</description>
/// </item>
/// <item>
///   <description>Item 2.</description>
/// </item>
/// </list>
/// </remarks>
class EClass : Exception
{
}
