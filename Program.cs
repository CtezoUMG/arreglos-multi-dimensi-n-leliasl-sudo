using System;

// 1. Lectura de datos: Configurada para los Test Cases de GitHub
string? linea1 = Console.ReadLine();
if (string.IsNullOrEmpty(linea1)) return;

int n = int.Parse(linea1);
// Leemos la segunda línea y dividimos por espacios, eliminando vacíos
string[] entrada = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries) ?? Array.Empty<string>();

int[] numeros = new int[n];
for (int i = 0; i < n; i++)
{
    numeros[i] = int.Parse(entrada[i]);
}

// --- INICIO DE LÓGICA DEL ALUMNO ---

using System;

class Program
{
    static void Main()
    {
        string? linea1 = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(linea1)) return;

        int n = int.Parse(linea1);

        string? linea2 = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(linea2)) return;

        string[] entrada = linea2.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        int maximo = int.Parse(entrada[0]);

        for (int i = 1; i < n && i < entrada.Length; i++)
        {
            int numero = int.Parse(entrada[i]);
            if (numero > maximo)
            {
                maximo = numero;
            }
        }

        Console.WriteLine(maximo);
    }
}


