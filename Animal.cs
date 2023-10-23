using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6___OOP_Arv
{
    internal abstract class Animal //Base class
    {
        // Properties to store common characteristics of animals
        public string _Color { get; set; }
        public string _Name { get; set; }
        public string _EyeColor { get; set; }
        public int _Age { get; set; }
        public int _Weight { get; set; }

        public Animal(string color, string name, string eyeColor, int age, int weight)     // Constructor to initialize the properties of the animal

        {
            _Color = color;
            _Name = name;
            _EyeColor = eyeColor;
            _Age = age;
            _Weight = weight;
        }

        public virtual void MakeSound()    // Virtual method for eating behavior (can be overridden by derived classes)

        {
            Console.WriteLine("Animal does a strange sound");
        }
        public virtual void Eat() 
        {
            Console.WriteLine("Animal eats its favorite food");
        }
        public virtual void Sleep()
        {
            Console.WriteLine("Animal sleeps on the floor");
        }

        public abstract void PrintInfo();    // Abstract method to be implemented by derived classes for printing animal information

    }
}
