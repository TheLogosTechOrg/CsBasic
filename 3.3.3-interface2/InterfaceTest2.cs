// another example with explicit interface implementation

interface IEnglishDimensions 
{
    float Length();
    float Width();
}
interface IMetricDimensions 
{
    float Length();
    float Width();
}

class Box : IEnglishDimensions, IMetricDimensions 
{
    float lengthInches;
    float widthInches;
    public Box(float length, float width) 
    {
        lengthInches = length;
        widthInches = width;
    }
    float IEnglishDimensions.Length() 
    {
        return lengthInches;
    }
    float IEnglishDimensions.Width() 
    {
        return widthInches;      
    }
    float IMetricDimensions.Length() 
    {
        return lengthInches * 2.54f;
    }
    float IMetricDimensions.Width() 
    {
        return widthInches * 2.54f;
    }
    public static void Main() 
    {
        Box myBox = new Box(30.0f, 20.0f);
        IEnglishDimensions eDimensions = (IEnglishDimensions) myBox;
        IMetricDimensions mDimensions = (IMetricDimensions) myBox;
        System.Console.WriteLine("Length(in): {0}", eDimensions.Length());
        System.Console.WriteLine("Width(in): {0}", eDimensions.Width());   
        System.Console.WriteLine("Length(cm): {0}", mDimensions.Length());
        System.Console.WriteLine("Width(cm): {0}", mDimensions.Width());
        System.Console.ReadLine();
    }
}
