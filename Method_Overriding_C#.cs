using System;

class BaseClass
{
    public virtual void Display()
    {
        Console.WriteLine("BaseClass Display method");
    }
}
class DerivedClass : BaseClass
{
    public override void Display()
    {
        Console.WriteLine("DerivedClass Overridden Display method");
    }
}
class Program
{
    static void Main()
    {
        BaseClass baseObj = new BaseClass();
        baseObj.Display(); 

        BaseClass derivedObj = new DerivedClass();
        derivedObj.Display();  

        DerivedClass obj = new DerivedClass();
        obj.Display();  // Calls DerivedClass method
    }
}
