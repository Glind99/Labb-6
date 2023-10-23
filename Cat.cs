using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Labb6___OOP_Arv
{
    internal class Cat : Animal //Cat class
    {
        public string _flexibility { get; set; } //propertys 

        public Cat(string color, string name, string eyeColor, int age, int weight, string flexibility) : base(color, name, eyeColor, age, weight) //Constructor 
        {
            _flexibility = flexibility;
        }

        public override void MakeSound() //override method 
        {
            Console.WriteLine("The cat says ¨Meow¨");
        }
        public override void Eat() //override method 
        {
            Console.WriteLine("The Cats favorite food is fish");
        }
        public override void Sleep() //override method 
        {
            Console.WriteLine("The cat likes to sleep in its own bed");
        }
        public void Stealth() //Custom method to specify the ability so stealth 
        {
            Console.WriteLine("This cat likes to stealth and surprise its owner");    
        }
        public override void PrintInfo() //override method
        {
            Console.WriteLine($"Cat" + 
                        $"\nColor of the cat: {_Color}" +
                        $"\nName: {_Name}" +
                        $"\nEyeColor: {_EyeColor}" +
                        $"\nAge: {_Age}" +
                        $"\nWeight: {_Weight}" +
                        $"\nFlexibility: {_flexibility}" +
                        "\n----------------------------------------------------------");
        }

    }
}
