using System.Drawing;

namespace Labb6___OOP_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creat a list
            List<Animal> Animals = new List<Animal>();
            //Wolf class
            Wolf wolf = new Wolf(color: "Black",name: "Vargen",eyeColor: "Brown",age: 5,weight: 50,scar: "big scar on the side"); 
            Animals.Add(wolf);
            wolf.MakeSound();
            wolf.PrintInfo();
            
            //Cat class 
            Cat cat = new Cat(color: "White", name: "Siri", eyeColor: "Red", age: 15, weight: 15, flexibility: "The cat is very flexible");
            Animals.Add(cat);
            cat.MakeSound();
            cat.PrintInfo();

            Dog dog = new Dog(color: "Black", name: "Dog", eyeColor: "Brown", age: 2, weight: 10, rowdy: "The dog is very rowdy");
            Animals.Add(dog);
            dog.MakeSound();
            dog.PrintInfo();
            //Terier class, inheritance from dog
            Terier terier = new Terier(color: "Black & White", name: "Harry", eyeColor: "Brown", age: 1, weight: 8, rowdy: "The terier is a bit rowdy", hunter:"The terier dog is great for hunting");
            Animals.Add(terier);
            terier.MakeSound();
            terier.PrintInfo();
            //Shepherd Class inheritance from dog
            Shepherd shepherd = new Shepherd(color: "Brown", name: "Bell", eyeColor: "Brown", age: 3, weight: 18, rowdy: "The Shepherd is not rowdy", role: "Is a policedog");
            Animals.Add(shepherd);
            shepherd.MakeSound();
            shepherd.PrintInfo();
            //userinput
            Console.WriteLine("Make your own animal!");
            Console.Write("Color: ");
            string animalColor = Console.ReadLine();
            Console.Write("Name: ");
            string animalName = Console.ReadLine();
            Console.Write("Eyecolor: ");
            string animalEyeColor = Console.ReadLine();
            Console.Write("Age: ");
            int animalAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Weight: ");
            int animalWeight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Animal: ");
            string AnimalAnimal = Console.ReadLine();

            //User creates its own animal for class "YourAnimal"
            YourAnimal yourAnimal = new YourAnimal(animalColor, animalName, animalEyeColor, animalAge, animalWeight, AnimalAnimal);
            Animals.Add(yourAnimal);
            yourAnimal.PrintInfo();//Print the input
            
        }
    }
}