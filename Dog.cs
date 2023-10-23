using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Labb6___OOP_Arv
{
    internal class Dog : Animal //Dog class that inheritance from Animal
    {
        public string _rowdy { get; set; } // Property to store information about dog
                                           
        // Constructor to initialize Dog object with specific properties
        public Dog(string color, string name, string eyeColor, int age, int weight, string rowdy) : base(color, name, eyeColor, age, weight)
        {
            _rowdy = rowdy;
        }
        public override void MakeSound()    // Override method to specify the sound a dog makes

        {
            Console.WriteLine("The dog says ¨Voff¨!");
        }
        public override void Eat() // Override method
        {
            Console.WriteLine("The dolf likes to eat meatballs");
        }
        public override void Sleep() // Override method
        {
            Console.WriteLine("The dog sleeps with its owner in the bed");
        }
        public void NoseWork()    // Custom method specific to dogs for nose work training

        {
            Console.WriteLine("Everyone monday dog does noseworktraining");
        }
        public override void PrintInfo() //override method 
        {
            Console.WriteLine($"\nDog" +
                        $"\nColor of the dog: {_Color}" +
                        $"\nName: {_Name}" +
                        $"\nEyeColor: {_EyeColor}" +
                        $"\nAge: {_Age}" +
                        $"\nWeight: {_Weight}" +
                        $"\nRowdy: {_rowdy}" +
                       "\n----------------------------------------------------------");
        }
    }
    class Terier : Dog // Terier class inheriting from Dog class
    {
        public string _hunter { get; set; }     // Property to store information about the terrier's hunting capabilities

        // Constructor to initialize Terrier object with specific properties
        public Terier(string color, string name, string eyeColor, int age, int weight, string rowdy, string hunter) : base(color, name, eyeColor, age, weight, rowdy)
        {
            _hunter = hunter;
        }
        public void Hunter()     // Custom method specific to terriers for hunting

        {
            Console.WriteLine("The terier dog is good for hunting");
        }
        public override void MakeSound() //override method
        {
            Console.WriteLine("The terierdog also says ¨Voff¨!");
        }
        public override void PrintInfo() //override method
        {
            Console.WriteLine($"\nTerier" +
                        $"\nColor of the terier: {_Color}" +
                        $"\nName: {_Name}" +
                        $"\nEyeColor: {_EyeColor}" +
                        $"\nAge: {_Age}" +
                        $"\nWeight: {_Weight}" +
                        $"\nRowdy: {_rowdy}" +
                        $"\nHunter: {_hunter}" +
                        "\n----------------------------------------------------------");
        }
    }
    class Shepherd : Dog // Shepherd class inheriting from Dog class

    {
        public string _role { get; set; } //property for Shepherd
                                        
        // Constructor to initialize Shepherd object with specific properties
        public Shepherd(string role, string color, string name, string eyeColor, int age, int weight, string rowdy) : base(color, name, eyeColor, age, weight, rowdy)
        {
            _role = role;
        }
        public override void MakeSound() //override method
        {
            Console.WriteLine("The Shepherd also says ¨Voff¨ but a bit louder and more scary");
        }
        public void PoliceDog()    // Custom method specific to shepherds for police dog duties

        {
            Console.WriteLine("The shepherd works as a policedog");
        }
        public override void PrintInfo() //override method
        {
            Console.WriteLine($"Sheepherd" +
                        $"\nColor of the shepherd: {_Color}" +
                        $"\nName: {_Name}" +
                        $"\nEyeColor: {_EyeColor}" +
                        $"\nAge: {_Age}" +
                        $"\nWeight: {_Weight}" +
                        $"\nRowdy: {_rowdy}" +
                        $"\nRole: {_role}" +
                        "\n----------------------------------------------------------");
        }
    }
}
