using System;

namespace Task1
{
    public struct Worker
    {
        public int Id { get; set; }
        public DateTime TimeToAdd { get; set; }
        public string FIO { get; set; }
        public int Age { get; set; }
        public float Height { get; set; }
        public DateTime Birthday { get; set; }
        public string PlaceToBorn { get; set; }

        public Worker(int id, DateTime timeToAdd, string fio, int age, float height, DateTime birthday, string placeToBorn) 
        {
            Id = id;
            TimeToAdd = timeToAdd;
            FIO = fio;
            Age = age;
            Height = height;
            Birthday = birthday;
            PlaceToBorn = placeToBorn;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Id}, {TimeToAdd}, {FIO}, {Age}, {Height}см , {Birthday}, г.{PlaceToBorn} ");
        }
    }
}


