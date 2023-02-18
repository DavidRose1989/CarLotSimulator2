using System;
using System.Runtime.CompilerServices;

namespace CarLotSimulator
{
    public class Car
    {
        public Car() //default constructor
        {
            CarLot.numberOfCars++; //Whenever you reference something static you need class name and Static Member
        }

        public Car(int year, string make, string model, string engineNoise, string honkNoise, string isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }

        public string HonkNoise { get; set; }

        public string IsDriveable { get; set; }


        public void MakeEngineNoise(string noise)
        {
            Console.WriteLine($"The engine noise sounds like {noise}");
        }


        public void MakeHonkNoise(string noise)
        { 
        Console.WriteLine($"The honk noise sounds like {noise}");
        }
    }
}


//Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
//Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise() 