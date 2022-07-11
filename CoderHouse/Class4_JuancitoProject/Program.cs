// See https://aka.ms/new-console-template for more information

bool showMenu = true;
while (showMenu)
{
    showMenu = MainMenu();
}

bool MainMenu()
{
    Console.WriteLine("Ingrese un numero");
    int num = Convert.ToInt32(Console.ReadLine());

    switch (num) 
    {
        case 0:
            return false;
        case < 0:
            LengthNum(num);
            return true;
        case > 10:
            Sumatoria(num);
            return true;
        case <= 10 and > 0:
            ListaNumeros(num);
            return true;
        default:
            return true;
    }        
}

void LengthNum(int num)
{
    string stringNumber = Convert.ToString(num);
    int digits = stringNumber.Length - 1;
    Console.WriteLine($"Numero de caracteres: {digits}");
}

void Sumatoria(int num)
{
    int totalSumatoria = 0;
    for (int i = num; i >= 0; i--)
    {
       totalSumatoria += i;
    }
    Console.WriteLine($"Sumatoria de numero: {totalSumatoria}");
}

void ListaNumeros(int num)
{
    int list = 0;
    for (int i = 0; i <= num; i++)
    {
        list = i;
        Console.WriteLine($"Lista de numeros hasta el digito ingresado: {i}");
    }
}



