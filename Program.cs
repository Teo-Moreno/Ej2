namespace Ej_2;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> inventario = new Dictionary<string, int>();
        Console.WriteLine("Inicializar 3 rescursos.");
        Console.WriteLine(Funciones.agregarItem(inventario, Funciones.ingresarTexto("Ingrese el item."), Funciones.IngresarNum("Ingrese la cantidad.", false)));
        Console.WriteLine(Funciones.agregarItem(inventario, Funciones.ingresarTexto("Ingrese el item."), Funciones.IngresarNum("Ingrese la cantidad.", false)));
        Console.WriteLine(Funciones.agregarItem(inventario, Funciones.ingresarTexto("Ingrese el item."), Funciones.IngresarNum("Ingrese la cantidad.", false)));
        int modo;
        do
        {
            modo = Funciones.ingresarNumConRango(1,5,"Ingrese la opción que va a usar: \n 1. Ver inventario completo\n 2. Actualizar el stock\n 3. Consumir un recurso\n 4. Consultar un recurso\n 5. Salir");
            switch (modo)
            {
                case 1:
                    foreach (string item in inventario.Keys)
                    {
                        Console.WriteLine($"{item}: {inventario[item]}");
                    }
                    break;
                case 2:
                    Console.WriteLine(Funciones.agregarItem(inventario, Funciones.ingresarTexto("Ingrese el item."), Funciones.IngresarNum("Ingrese la cantidad.", false)));
                    break;
                case 3:
                    Console.WriteLine(Funciones.agregarItem(inventario, Funciones.ingresarTexto("Ingrese el item."), Funciones.IngresarNum("Ingrese la cantidad.", false)));
                    break;
                case 4:
                    Console.WriteLine(Funciones.ConsultarClave(inventario, Funciones.ingresarTexto("Ingrese el item.")))
                    break;
            }
            Funciones.Esperar();
            Console.Clear();
        }while(modo != 5);
    }
}
