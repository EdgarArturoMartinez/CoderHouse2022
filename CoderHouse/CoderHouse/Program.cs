using System;

namespace CoderHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Name = "Test";
            Console.WriteLine($"Hello ");
        }
    }

    class Persona
    {
        public string Name { get; set; }
    }

}
