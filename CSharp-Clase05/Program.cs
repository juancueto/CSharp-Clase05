// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.WriteLine("====== EJERCICIO 1 =====");
// Ejercicio 1

Console.WriteLine("Ingrese nombre:");
string nombre = Console.ReadLine();
Console.WriteLine("Ingrese email:");
string email = Console.ReadLine();
Console.WriteLine("Ingrese cupon:");
string? cupon = Console.ReadLine();

double precioInicial = 1500;

Console.WriteLine($"Precio inicial producto A: {precioInicial}");

if (!string.IsNullOrEmpty(cupon))
{
    Console.WriteLine("Tiene un cupon de descuento del 10%");
    Console.WriteLine($"Precio final: {precioInicial * 0.9}");
}
else
{
    Console.WriteLine("No tiene un cupon de descuento del 10%");
    Console.WriteLine($"Precio final: {precioInicial}");
}

// Ejercicio 2
Console.WriteLine("====== EJERCICIO 2 =====");

string[] lenguajes = new string[] {
    "C#", "Java", "C++", "Python", "Ruby"
};

for (int i = 0; i< lenguajes.Length; i++)
{
    Console.WriteLine($"{i+1}. {lenguajes[i]}");
}


Console.WriteLine("Seleccione un lenguaje:");

int index = int.Parse(Console.ReadLine());
string lenguajeSeleccionado = "";
switch (index)
{
    case 1:
        lenguajeSeleccionado = lenguajes[0];
        break;
    case 2:
        lenguajeSeleccionado = lenguajes[1];
        break;
    case 3:
        lenguajeSeleccionado = lenguajes[2];
        break;
    case 4:
        lenguajeSeleccionado = lenguajes[3];
        break;
    case 5:
        lenguajeSeleccionado = lenguajes[4];
        break;
    default:
        break;
}

if (lenguajeSeleccionado == "")
{
    Console.WriteLine($"No se ha seleccionad un lenguaje");
}
else {
    Console.WriteLine($"Lenguaje seleccionado: {lenguajeSeleccionado}");
}


// FIN
Console.ReadLine();