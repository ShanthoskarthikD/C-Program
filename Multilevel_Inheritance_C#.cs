using System;
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}
class Mammal : Animal
{
    public void Walk()
    {
        Console.WriteLine("Mammal is walking");
    }
}
class Dog : Mammal
{
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
