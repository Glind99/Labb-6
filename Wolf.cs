using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6___OOP_Arv
{
    internal class Wolf : Animal
    {
        // Property to store information about scars on the wolf
        public string _Scar { get; set; }

        // Constructor to initialize the Wolf object with specific properties
        public Wolf(string color, string name, string eyeColor, int age, int weight, string scar) : base(color, name, eyeColor, age, weight)
        {
            _Scar = scar;
        }
        
        public override void MakeSound()    // Override method to make a sound specific to a wolf

        {
            Console.WriteLine("The wolf howls!");
        }
        public override void Eat()    // Override method to specify the eating behavior of a wolf

        {
            Console.WriteLine("The wolf eats meat");
        }
        public override void Sleep()
        {
            Console.WriteLine("The wolf sleeps in the forest");
        }
        public void IsLeader()    // Method to determine if the wolf is a leader

        {
            Console.WriteLine("The wolf is a leader!");
        }
        public override void PrintInfo()     // Override method to print information about the wolf

        {
            Console.WriteLine($"Wolf" + 
                        $"\nColor of the wolf: {_Color}" +
                        $"\nName: {_Name}" +
                        $"\nEyeColor: {_EyeColor}" +
                        $"\nAge: {_Age}" +
                        $"\nWeight: {_Weight}" +
                        $"\nScars: {_Scar}" +
                        "\n----------------------------------------------------------");                        

        }
    }
}
