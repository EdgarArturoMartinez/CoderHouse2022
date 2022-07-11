const string codDesodorante = "DES";
const int precioDesodorante = 200;
const string codJabonPolvo = "JP";
const int precioJabonPolvo = 300;
const string codDetergente = "DET";
const int precioDetergente = 250;
const string codFin = "FIN";
const string codCompraExitosa = "COMPRAR";

Console.WriteLine("Bienvenidos a la aplicacion de ventas!");

bool showMenu = true;
while (showMenu)
{
    showMenu = MainMenu();
}

bool MainMenu()
{
    Console.WriteLine("---------------------------------");
    Console.WriteLine("*** Para finalizar presione X ***");
    Console.WriteLine("Ingrese Codigo de Producto");    
    string codIngresado = Console.ReadLine();
    switch (codIngresado)
    {
        case "X" or "x":
            return false;
        case codDesodorante:
            Console.WriteLine("Ingrese cantidad de Desodorantes en Venta");
            int cantidadProducto = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba FIN para informar el monto a abonar.");
            string input = Console.ReadLine();
            if (input.Equals(codFin))
            {
                ProcesarVentaProducto(codIngresado, cantidadProducto);
                return true;   
            }
            else 
            {
                Console.WriteLine("Ha ingresado una orden Incorrecta, debe repetir el proceso");
                return true;
            }
        case codJabonPolvo:
            Console.WriteLine("Ingrese cantidad de Jabones en Polvo en Venta");
            cantidadProducto = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba FIN para informar el monto a abonar.");
            input = Console.ReadLine();
            if (input.Equals(codFin))
            {
                ProcesarVentaProducto(codIngresado, cantidadProducto);
                return true;
            }
            else
            {
                Console.WriteLine("Ha ingresado una orden Incorrecta, debe repetir el proceso");
                return true;
            }
        case codDetergente:
            Console.WriteLine("Ingrese cantidad de Detergente en Venta");
            cantidadProducto = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba FIN para informar el monto a abonar.");
            input = Console.ReadLine();
            if (input.Equals(codFin))
            {
                ProcesarVentaProducto(codIngresado, cantidadProducto);
                return true;
            }
            else
            {
                Console.WriteLine("Ha ingresado una orden Incorrecta, debe repetir el proceso");
                return true;
            }
        default:
            Console.WriteLine($"El codigo {codIngresado} no es valido para realizar una Venta.");
            return true;
    }
}

void ProcesarVentaProducto(string codIngresado, int cantidadProducto)
{
    int totalVenta = 0;
    if (codIngresado == codDesodorante)
    {
        totalVenta = cantidadProducto * precioDesodorante;
        Console.WriteLine($"Total Venta Desodorantes: {totalVenta}");
    }
    else if (codIngresado == codJabonPolvo)
    {
        totalVenta = cantidadProducto * precioJabonPolvo;
        Console.WriteLine($"Total Venta Jabon en Polvo: {totalVenta}");
    }
    else if (codIngresado == codDetergente)
    {
        totalVenta = cantidadProducto * precioDetergente;
        Console.WriteLine($"Total Venta Detergentes: {totalVenta}");
    }
    ConfirmarCompra();
}

void ConfirmarCompra()
{
    Console.WriteLine("Confirmar Compra. -- Para confirmar ingrese COMPRAR de lo contrario el sistema finalizara.");
    string confirmationMessage = Console.ReadLine();
    if (confirmationMessage.Equals(codCompraExitosa))
    {
        Console.WriteLine("Gracias por comprar en nuestra tienda.");
    }
    else
    {
        Console.WriteLine("Sistema Finalizado");
    }
}









