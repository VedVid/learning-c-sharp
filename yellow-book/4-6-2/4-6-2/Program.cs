using System;

class Foo
{
    public static int bar = 0;
    private static int baz = 5;
    public int GetBaz()
    {
        return baz;
    }
}

class StaticTest
{
    public static void Main()
    {
        Foo test = new Foo();
        // Since 'bar' is static, writing 'test.bar' will not compile.
        Console.WriteLine(Foo.bar);
        // 'baz' is private so it can't be printed directly at all
        // Console.WriteLine(Foo.baz); will not compile
        // Public methods are called by the instance, and not a class.
        Console.WriteLine(test.GetBaz());
    }
}
