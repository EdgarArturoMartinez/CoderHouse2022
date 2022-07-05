namespace Desafio1EdgarMartinez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1
            string name = "Edgar Arturo";
            string lastName = "Martinez";
            int DNI = 80172454;
            int age = 40;
            double height = 1.78;
            Console.WriteLine("Nombre: " + name);
            Console.WriteLine("Apellido: " + lastName);
            Console.WriteLine("DNI: " + DNI);
            Console.WriteLine("Edad: " + age);
            Console.WriteLine("Altura: " + height);


            //Ejercicio 2
            Console.Write("\r\n Ingrese Numero 1:");
            string snum1 = Console.ReadLine();
            int num1 = Int32.Parse(snum1);

            Console.Write("\r\n Ingrese Numero 2:");
            string snum2 = Console.ReadLine();
            int num2 = Int32.Parse(snum2);

            int result = num1 + num2;
            Console.WriteLine("El resultado de la suma de los numeros es: " + result);


            //Ejercicio 3
            string alias = "Arthur";

            //Console.WriteLine("Mi nombre es : " + name + " " + "\"" + alias + "\"" + " " + lastName);
            Console.WriteLine($"Mi nombre es: {name} \"{alias}\" {lastName} ");

        }
    }
}