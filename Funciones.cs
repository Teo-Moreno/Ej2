class Funciones
{
    public static int IngresarNum(string mensaje, bool negativo = true)
    {
        int num = 0;
        bool numCorrect;
        do
        {
            Console.WriteLine(mensaje);
            numCorrect = int.TryParse(Console.ReadLine(), out num);
            if (!numCorrect)
            {
                Console.WriteLine("No se ha ingresado un número correcto. Tiene que ser sin decimales.");
            }
            if (negativo == false && num < 0)
            {
                numCorrect = false;
            }
        }while (numCorrect == false);
        return num;
    } 
    public static int ingresarNumConRango(int min, int max, string mensaje)
    {
        int num;
        do
        {
            num = IngresarNum(mensaje, false);
        } while (num < min || num > max);
        return num;
    } 
    public static string ingresarTexto(string mensaje)
    {
        string texto = "";
        do
        {
            Console.WriteLine(mensaje);
            texto = Console.ReadLine();
            if (texto == "")
            {
                Console.WriteLine("No ha ingresado nada.");
            }
        } while (texto == "");
        return texto;
    }
    public static string agregarItem(Dictionary<string, int> inventario, string item, int cantidad)
    {
        if (inventario.ContainsKey(item) )
        {
            inventario[item] = cantidad;
            return $"Se a agregado {cantidad} a el item {item}, la cantidad actual es {inventario[item]}.";
        }
        else
        {
            inventario.Add(item, cantidad);
            return $"Se agregó el nuevo item {item} correctamente, la cantidad actual es{inventario[item]}.";
        }
    }
    public static void Esperar() 
    { 
        Console.WriteLine("Ingrese enter para continuar.");
        Console.ReadLine();
    }

}