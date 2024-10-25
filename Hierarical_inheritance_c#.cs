using System;
class Animal
{
    public void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
}
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog barks");
    }
}
class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine("Cat meows");
    }
}
class Program
{
    static void Main()
    {
        Dog dog = new Dog();
        dog.Speak();  
        dog.Bark();  

        Cat cat = new Cat();
        cat.Speak();  
        cat.Meow();   
    }
}
