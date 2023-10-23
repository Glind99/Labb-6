using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6___OOP_Arv
{
    internal class YourAnimal : Animal //Users own class
    {
        public string _Name;
        public string _color;
        public string _Eyecolor;
        public int _Age;
        public int _weight;
        public string _Animal;

        public YourAnimal(string color, string name, string eyecolor, int age, int weight, string animal) : base(color, name, eyecolor, age, weight)
        {
            _Name = name;
            _Color = color;
            _Eyecolor = eyecolor;
            _Age = age;
            _Weight = weight;
            _Animal = animal;

        }
        public override void PrintInfo() //override method
        {
            Console.WriteLine($"\nThis is your animal" + 
                       $"\nColor of the animal:{_Color} " +
                       $"\nName: {_Name}" +
                       $"\nEyeColor: {_EyeColor}" +
                       $"\nAge: {_Age}" +
                       $"\nWeight: {_Weight}" +
                       $"\nAnimal: {_Animal}" + 
                        "\n----------------------------------------------------------");
        }

    }
}
