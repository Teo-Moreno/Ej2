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
                Console.WriteLine($"No se ha ingresado un número correcto. Tiene que ser sin decimales. {(!negativo ? "" : "No puede ser negativo")}");            
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
            if (cantidad < 0 && cantidad * -1 > inventario[item])
            {
                return $"Estas consumiendo más de lo que tenes, del item {item} tenes {inventario[item]} unidades.";
            }
            if (cantidad < 0 && cantidad * -1 == inventario[item])
            {
                inventario[item] += cantidad;
                return $"Se a consumido todo del item {item}, la nueva cantidad es 0.";
            }
            inventario[item] += cantidad;
            return $"Se actualizó el stock del item {item} por {cantidad}, la cantidad actual es {inventario[item]}.";
        }
        else
        {
            if (cantidad > 0)
            {
                inventario.Add(item, cantidad);
                return $"Se agregó el nuevo item {item} correctamente, la cantidad actual es {inventario[item]}.";
            }
            return "No tenes ese item, ¿qué intentas consumir?";
        }
    }
    public static string ConsultarClave(Dictionary<string, int> inventario, string clave)
    {
        if (inventario.ContainsKey(clave) )
        {
            return $"Hay {inventario[clave]} del item {clave} .";
        }
        return "No existe ese item";
    }
    public static void Esperar() 
    { 
        Console.WriteLine("Ingrese enter para continuar.");
        Console.ReadLine();
    }

}