const int precioCaramelo = 2;
const int precioGaseosa = 100;
const int precioAlfajor = 55;
const int precioChocolate = 30;
const double salarioMensual = 15000;
int contadorPedido = 0;
int contadorCliente = 0;
string producto = string.Empty;
int cantidad = 0;

IDictionary<string, int> tablaPrecios = new Dictionary<string, int>();
tablaPrecios.Add("CARAMELO", precioCaramelo);
tablaPrecios.Add("GASEOSA", precioGaseosa);
tablaPrecios.Add("ALFAJOR", precioAlfajor);
tablaPrecios.Add("CHOCOLATE", precioChocolate);
IDictionary<string, int> tablaPedidos = new Dictionary<string, int>();
IDictionary<string, int> tablaVentas = new Dictionary<string, int>();


bool showMenu = true;
while (showMenu)
{
    showMenu = MainMenu();
}

bool MainMenu()
{
    Console.WriteLine("");
    Console.WriteLine("------------------MENU PRINCIPAL--------------------");
    Console.WriteLine("----------------------------------------------------");
    Console.WriteLine("********* Para finalizar presione 0 (Cero) *********");
    Console.WriteLine("\r\nIngrese la opción que desea ejecutar: ");
    Console.WriteLine("1.  Precio Por Producto");
    Console.WriteLine("2.  Realizar Venta Producto");
    Console.WriteLine("3.  Confirmar Compra Del Cliente");
    Console.WriteLine("9.  Proceso Cierre e Informe Aplicativo");
    Console.WriteLine("0.  Salir");
    int opcionMenuPrincipal = Convert.ToInt32(Console.ReadLine());
    switch (opcionMenuPrincipal)
    {
        case 0:
            return false;
        case 1:
            Console.WriteLine("Ingrese Producto: ");
            producto = Console.ReadLine();
            PrecioProducto(producto);
            return true;
        case 2:
            Console.WriteLine("Ingrese Producto: ");
            producto = Console.ReadLine();
            Console.WriteLine($"Ha elegido {producto}, que cantidad desea comprar? ");
            cantidad = Convert.ToInt32(Console.ReadLine());
            VentaProducto(producto, cantidad);
            return true;
        case 3:
            ConfirmarCompraCliente();
            return true;
        case 9:
            MenuReporting();
            return true;
        default:
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Ha ingresado una opción invalida, intentelo nuevamente");
            return true;
    }

}

void PrecioProducto(string producto)
{
    foreach (KeyValuePair<string, int> kvp in tablaPrecios)
    {
        if (producto.Contains(kvp.Key)) 
        {
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($" El precio por cada {kvp.Key}, es: ${kvp.Value}");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }       
    }
}

void VentaProducto(string producto, int cantidad)
{
    int result = 0;
    foreach (KeyValuePair<string, int> kvp in tablaPrecios)
    {
        if (producto.Contains(kvp.Key))
        {
            contadorPedido++;
            result = kvp.Value * cantidad;
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($" El precio total a pagar por {cantidad} {kvp.Key}, es: ${result}");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("-----------------Presione: 1. Para CONFIRMAR pedido.");
            Console.WriteLine("-----------------Presione: 2. Para CANCELAR pedido.");
            Console.BackgroundColor = ConsoleColor.Black;
            int opcionPedido = Convert.ToInt32(Console.ReadLine());
            if (opcionPedido == 1)
            {
                string detallePedido = DateTime.Now.ToString("MM/dd/yyyy") + " Venta" + contadorPedido + ": "  + cantidad + " " + producto ;
                tablaPedidos.Add(detallePedido, result);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("El pedido ha sido grabado correctamente.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("");
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("-----------------Presione: 3. Para confirmar la compra del cliente.");
                Console.WriteLine("-----------------Presione: 2. Para continuar compra con el mismo cliente.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("");

            }
            else if (opcionPedido == 2)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"El pedido de {cantidad} {producto} ha sido cancelado.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("");
            }
        }
    }   
}


void ConfirmarCompraCliente()
{
    contadorCliente++;
    foreach (KeyValuePair<string, int> kvp in tablaPedidos)
    {
        tablaVentas.Add("Cliente" + contadorCliente + " -> " + kvp.Key, kvp.Value);
        Console.WriteLine("");
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("La venta de producto ha sido confirmada!");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine("");
        Console.WriteLine("");
        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("-----------------Seleccione alguna opción del menu para continuar.");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine("");
    }
    tablaPedidos.Clear();
}


void MenuReporting()
{
    Console.WriteLine("");
    Console.WriteLine("");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("----------PROCESO DE CIERRE Y REPORTING-------------");
    Console.WriteLine("----------------------------------------------------");
    Console.WriteLine("********* Para finalizar presione 0 (Cero) *********");
    Console.WriteLine("\r\nIngrese la opción que desea ejecutar: ");
    Console.WriteLine("1.  Imprimir Ventas del Dia");
    Console.WriteLine("2.  Imprimir Ganancia del Dia");
    Console.WriteLine("3.  Salario de Lucas");
    Console.WriteLine("0.  Salir");
    Console.ForegroundColor = ConsoleColor.White;

    int opcionMenuReporting = Convert.ToInt32(Console.ReadLine());
    switch (opcionMenuReporting)
    {
        case 0:
            break;
        case 1:
            ImprimirVentaDiaria();
            break;
        case 2:
            ImprimirGananciaDiaria();
            break;
        case 3:
            ImprimirSalarioEmpleado();
            break;
    }
}


void ImprimirVentaDiaria()
{
    int totalVentas = tablaVentas.Sum(x => x.Value);
    Console.WriteLine("");
    Console.BackgroundColor = ConsoleColor.Red;
    Console.WriteLine($"Venta Total del Dia: ${totalVentas}");
    Console.BackgroundColor = ConsoleColor.Black;
    Console.WriteLine("");
    ImprimirTablaVentas();
}


void ImprimirGananciaDiaria()
{
    int totalVentas = tablaVentas.Sum(x => x.Value);
    double totalGanancia = totalVentas * 0.30;
    Console.WriteLine("");
    Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine($"Ganancia Total del Dia: ${totalGanancia}");
    Console.BackgroundColor = ConsoleColor.Black;
    Console.WriteLine("");
    ImprimirTablaVentas();
}

void ImprimirSalarioEmpleado()
{
    int totalVentas = tablaVentas.Sum(x => x.Value);
    double totalGanancia = totalVentas * 0.30;
    double salarioEmpleado = (salarioMensual / 30) + (totalGanancia * 0.25);
    Console.WriteLine("");
    Console.BackgroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine($"El salario de Lukas hoy es de: ${salarioEmpleado}");
    Console.BackgroundColor = ConsoleColor.Black;
    Console.WriteLine("");
    ImprimirTablaVentas();
}

void ImprimirTablaVentas()
{
    foreach (KeyValuePair<string, int> kvp in tablaVentas)
    {        
        Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);       
    }
}








