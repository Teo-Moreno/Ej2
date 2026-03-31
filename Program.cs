namespace Ej_2;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> inventario = new Dictionary<string, int>();
        Console.WriteLine("Inicializar 3 rescursos.");
        Console.WriteLine(Funciones.agregarItem(inventario, Funciones.ingresarTexto("Ingrese el item."), Funciones.IngresarNum("Ingrese la cantidad.")));
        Console.WriteLine(Funciones.agregarItem(inventario, Funciones.ingresarTexto("Ingrese el item."), Funciones.IngresarNum("Ingrese la cantidad.")));
        int modo;
        do
        {
            modo = Funciones.ingresarNumConRango(1,5,"");
            switch (modo)
            {
                case 1:
                    
                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
            }
            Funciones.Esperar();
            Console.Clear();
        }while(modo != 5);
    }
}
