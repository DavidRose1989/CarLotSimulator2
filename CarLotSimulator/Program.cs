using System;
using System.Security.Cryptography.X509Certificates;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car done
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable done 
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise() done
            //The methods should take one string parameter: the respective noise property done 


            //Now that the Car class is created we can instanciate 3 new cars

            CarLot myCarLot= new CarLot();


            //dot notation
            Car myCar = new Car();
            myCar.Year = 2023;
            myCar.Make = "Tesla";
            myCar.Model = "Model X";

            myCarLot.ListOfCars.Add(myCar);
            


            //object initializer syntax
            Car mySecondCar = new Car() {Year = 2022, Make = "X5", Model = "BMW"   };
            myCarLot.ListOfCars.Add(mySecondCar);

            //custom constructor
            Car myThirdCar = new Car(2022, "Tesla", "Model 3", "silence", "loud", "yes" );
            myCarLot.ListOfCars.Add(myThirdCar);
            

            //Set the properties for each of the cars done

            //Call each of the methods for each car done

            myCar.MakeEngineNoise("The engine noise is loud");

            myCar.MakeHonkNoise("The horn is scary");

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car done



            //*************BONUS X 2*************//

            //Create a CarLot class done 
            //It should have at least one property: a List of cars done 
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list. done 
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");

            foreach (var item in myCarLot.ListOfCars)
            {


                Console.WriteLine(item.Model);
                
                Console.WriteLine(item.Year);
                
                Console.WriteLine(item.Make);
                Console.WriteLine(); 
                Console.WriteLine(); 

            }

        }
    }
}
