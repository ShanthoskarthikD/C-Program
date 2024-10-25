using System;
interface IAnimal
{
    void Eat();
}

interface IMammal
{
    void Walk();
}
class Dog : IAnimal, IMammal
{
    public void Eat()
    {
        Console.WriteLine("Dog is eating");
    }

    public void Walk()
    {
        Console.WriteLine("Dog is walking");
    }

    public void Bark()
    {
        Console.WriteLine("Dog is barking");
    }
}
class Program
{
    static void Main()
    {
        Dog dog = new Dog();
        dog.Eat(); 
        dog.Walk(); 
        dog.Bark(); 
    }
}
