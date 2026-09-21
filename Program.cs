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

    //Función tipo de consulta
    static string ObtenerTipoConsulta()
    {
        while (true)
        {
            Console.WriteLine("\nSeleccione el tipo de consulta (1.Matrícula, 2.Pagos, 3.Constancia, 4.Plataforma, 5.Otro): ");
            string op = Console.ReadLine()?.Trim();
            switch (op)
            {
                case "1": return "Matrícula";
                case "2": return "Pagos";
                case "3": return "Constancia";
                case "4": return "Plataforma";
                case "5": return "Otro";
                default: Console.WriteLine(" Opción inválida. Intente de nuevo."); break;
            }
        }
    }

    //Función prioridad
    static string CalcularPrioridad(string tipoConsulta)
    {
        if (tipoConsulta == "Pagos" || tipoConsulta == "Matrícula")
        {
            return "Alta";
        }
        return "Baja";
    }

    //Función resumen
    static void MostrarResumen(string codigo, string nombre, string tipo, string descripcion, string prioridad)
    {
        Console.WriteLine("---------------------------------------");
        Console.WriteLine($" CÓDIGO    : {codigo}");
        Console.WriteLine($" ESTUDIANTE: {nombre}");
        Console.WriteLine($" TIPO      : {tipo}");
        Console.WriteLine($" DESCRIPCIÓN: {descripcion}");
        Console.WriteLine($" PRIORIDAD : {prioridad}");
        Console.WriteLine("---------------------------------------");
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
        int totalRegistrados = 0;
        bool continuar = true;
        while (continuar)
        {
            MostrarMenu();
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    if (totalRegistrados < MAX_SOLICITUDES)
                    {
                        Console.WriteLine($"\n--- REGISTRO DE SOLICITUD N° {totalRegistrados + 1} ---");
                        string codigo = ObtenerTextoValido("Ingrese código de estudiante (mín. 5 caract.): ", 5);
                        string nombre = ObtenerTextoValido("Ingrese nombre del estudiante: ", 2);
                        string tipo = ObtenerTipoConsulta();
                        string descripcion = ObtenerTextoValido("Ingrese descripción breve de la consulta: ", 5);
                        string prioridad = CalcularPrioridad(tipo);

                        codigos[totalRegistrados] = codigo;
                        nombres[totalRegistrados] = nombre;
                        tipos[totalRegistrados] = tipo;
                        descripciones[totalRegistrados] = descripcion;
                        prioridades[totalRegistrados] = prioridad;

                        totalRegistrados++;

                        Console.WriteLine("\n¡Solicitud registrada con éxito!");
                        MostrarResumen(codigo, nombre, tipo, descripcion, prioridad);
                    }
                    else
                    {
                        Console.WriteLine("\n[Límite alcanzado] Se han registrado las 3 solicitudes máximas de la sesión.");
                    }
                    break;

                case "2":
                    Console.WriteLine("\n=== RESUMEN DE TODAS LAS ATENCIONES REGISTRADAS ===");    
                    break;

                case "3":
                    continuar = false;
                    Console.WriteLine("\nSaliendo del sistema de Soporte Académico...");
                    break;

                default:
                    Console.WriteLine("\n[Error] Opción inválida. Por favor, seleccione una opción válida.");
                    break;
            }
	    }
	}
}