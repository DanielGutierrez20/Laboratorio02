using System;
public class Program
{
    //FUNCIONES
    //Funcion menú principal
    static void MostrarMenu()
    {
        Console.WriteLine("=======================================");
        Console.WriteLine("  SISTEMA DE SOPORTE ACADÉMICO - UPN   ");
        Console.WriteLine("=======================================");
        Console.WriteLine("1. Registrar nueva solicitud");
        Console.WriteLine("2. Mostrar todas las solicitudes");
        Console.WriteLine("3. Salir");
        Console.WriteLine("=======================================");
    }

    //Función validar texto no vacío
    static string ObtenerTextoValido(string mensaje, int minLongitud)
    {
        string entrada;
        do
        {
            Console.Write(mensaje);
            entrada = Console.ReadLine()?.Trim();
            if (string.IsNullOrEmpty(entrada))
                Console.WriteLine(" Error: El campo no puede estar vacío.");
            else if (entrada.Length < minLongitud)
                Console.WriteLine($" Error: Debe ingresar al menos {minLongitud} caracteres.");
        } while (string.IsNullOrEmpty(entrada) || entrada.Length < minLongitud);

        return entrada;
    }
	public static void Main()
	{
		//Estructura
        const int MAX_SOLICITUDES = 3;
        string[] codigos = new string[MAX_SOLICITUDES];
        string[] nombres = new string[MAX_SOLICITUDES];
        string[] tipos = new string[MAX_SOLICITUDES];
        string[] descripciones = new string[MAX_SOLICITUDES];
        string[] prioridades = new string[MAX_SOLICITUDES];
        
        string codigo = ObtenerTextoValido("Ingrese código de estudiante (mín. 5 caract.): ", 5);
	}
}