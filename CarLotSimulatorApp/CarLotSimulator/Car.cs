using System;
namespace CarLotSimulator
{
    public class Car : CarLot 
    {
        public Car()
        {
            CarLot.numberOfCars++;
        }

        public int Year {get; set;}
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise()
        {
            Console.WriteLine(EngineNoise);
        }
            
       public void MakeHonkNoise()
        {
            Console.WriteLine(HonkNoise);
        }
    }
}

