namespace PasswordProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string passwordSetUp = "usSystem-2022";
            int attemps = 0;
            

            while (attemps < 6) 
            {
                Console.WriteLine("Por favor ingrese su contraseña.");
                string passwordReceived = Console.ReadLine();
                if (passwordReceived.Equals(passwordSetUp))
                {
                    Console.WriteLine("Bienvenido al Sistema");
                    break;
                }
                else
                {
                    attemps++;                                
                }              

            }
        }
    }
}