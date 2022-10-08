﻿using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console


            Car newImport1 = new Car() { Year = 2007, Make = "Nissan", Model = "GTR 35", EngineNoise = "vicious low pitch growl", HonkNoise = "standard honk", IsDriveable = true};

            newImport1.MakeEngineNoise();
            newImport1.MakeHonkNoise();
            CarLot.ParkingLot.Add(newImport1);
            Car newImport2 = new Car()
            {
                Year = 2019,
                Make = "Acura",
                Model = "RDX GT",
                EngineNoise = "smooth medium-quiet SUV engine",
                HonkNoise = "standard honk",
                IsDriveable = true
            };

            CarLot.ParkingLot.Add(newImport2);
            newImport2.MakeEngineNoise();
            newImport2.MakeHonkNoise();

            var newImport3 = new Car();
            newImport3.Year = 2023;
            newImport3.Make = "Mazda";
            newImport3.Model = "CX-5 (tuner from Hawaii)";
            newImport3.EngineNoise = "agressively loud when accelerating";
            newImport3.HonkNoise = "custom sound from previous owner";
            newImport3.IsDriveable = true;

            newImport3.MakeEngineNoise();
            newImport3.MakeHonkNoise();

            CarLot.ParkingLot.Add(newImport3);

            foreach (var Car in CarLot.ParkingLot)
            {
                Console.WriteLine($"{Car.Year}, {Car.Make}, {Car.Model}");
            }
            Console.ReadLine();

            Car newCar4 = new Car();
            Console.WriteLine($"Cars in the lot: {CarLot.numberOfCars}");

            Car newCar5 = new Car();
            Console.WriteLine($"Cars in the lot: {CarLot.numberOfCars}");

            Car newCar6 = new Car();
            Console.WriteLine($"Cars in the lot: {CarLot.numberOfCars}");

            Console.ReadLine();
        }
    }
}
