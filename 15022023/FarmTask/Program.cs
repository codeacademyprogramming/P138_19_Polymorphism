using System;

namespace FarmTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Farm eleddininFermasi = new Farm();

            eleddininFermasi.AddAnimal(new Sheep());
            eleddininFermasi.AddAnimal(new Horse() { Country = "Qazagistan"});
            eleddininFermasi.AddAnimal(new Sheep());
            eleddininFermasi.AddAnimal(new Sheep());

            Console.WriteLine("Fermadaki qoyunlarin sayi: "+eleddininFermasi.GetSheepCount());
            Console.WriteLine("Fermadaki atlarin sayi: "+ eleddininFermasi.GetHorseCount());

        }
    }
}
