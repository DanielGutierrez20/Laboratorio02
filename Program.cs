using System;
public class Program
{
    //FUNCIONES
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
	public static void Main()
	{
		// COMMIT REQ 1: Estrutura base de datos
        const int MAX_SOLICITUDES = 3;
        string[] codigos = new string[MAX_SOLICITUDES];
        string[] nombres = new string[MAX_SOLICITUDES];
        string[] tipos = new string[MAX_SOLICITUDES];
        string[] descripciones = new string[MAX_SOLICITUDES];
        string[] prioridades = new string[MAX_SOLICITUDES];
	}
}