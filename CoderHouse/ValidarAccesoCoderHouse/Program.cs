// See https://aka.ms/new-console-template for more information
const int storedPassword = 12345678;

Console.WriteLine("Validando Acceso");
Console.WriteLine("Por favor ingrese su contraseña: ");
int password = Convert.ToInt32(Console.ReadLine());

if (password == storedPassword)
{
    Console.WriteLine("Bienvenido a la aplicación");
}
else
{
    Console.WriteLine("Contraseña Incorrecta!, reinicie la aplicación.");
    password = Convert.ToInt32(Console.ReadLine());
    int digits = (int)Math.Floor(Math.Log10(password) + 1);
    if (password == storedPassword && digits == 8)
    {
        Console.WriteLine("Bienvenido a la aplicación");
        Console.WriteLine($"Number of digits: {digits}");
    }
    else
    {
        Console.WriteLine("Contraseña Incorrecta!, reinicie la aplicación.");
        Console.WriteLine($"Number of digits: {digits}");
    }
}
