// trying to use an internal class from another assembly causes errors
class TestAccess
{
    public static void Main()
    {
        BaseClass myBase = new BaseClass();   //错误：在组合的外部BaseClass不可见
    }
}
