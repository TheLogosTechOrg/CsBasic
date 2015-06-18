// test explicit interface implementation

interface IDimensions 
{
    float Length();
    float Width();
}

class Box : IDimensions 
{
    float lengthInches;
    float widthInches;
    
    public Box(float length, float width) 
    {
        lengthInches = length;
        widthInches = width;
    }
    
    // Note the interface name is used for the interface methods implementation
    float IDimensions.Length() 
    {
        return lengthInches;
    }
    float IDimensions.Width() 
    {
        return widthInches;      
    }
    
    public static void Main() 
    {
        Box myBox = new Box(30.0f, 20.0f);
        IDimensions myDimensions = (IDimensions) myBox;

        System.Console.WriteLine("Length: {0}", myDimensions.Length());
        System.Console.WriteLine("Width: {0}", myDimensions.Width());

        //System.Console.WriteLine("Length: {0}", myBox.Length()); // compile errors
        //System.Console.WriteLine("Width: {0}", myBox.Width());

        System.Console.ReadLine();
    }
}
