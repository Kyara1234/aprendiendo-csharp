// ============================================================
//  TEMA 4: Bucles (Loops) en C#
//  Autor: Kyara Yactayo
// ============================================================

using System;

class Bucles
{
    static void Main()
    {
        Console.WriteLine("=== BUCLES ===\n");

        // ── while ─────────────────────────────────────────────
        Console.WriteLine("=== while ===");
        // Se ejecuta MIENTRAS la condición sea true
        int vida = 100;
        int ronda = 1;

        while (vida > 0)
        {
            Console.WriteLine($"Ronda {ronda}: Vida = {vida}");
            vida -= 30;
            ronda++;
        }
        Console.WriteLine("¡El jugador murió!\n");

        // ── do-while ──────────────────────────────────────────
        Console.WriteLine("=== do-while ===");
        // Se ejecuta AL MENOS UNA VEZ, luego revisa la condición
        int intentos = 0;

        do
        {
            Console.WriteLine($"Intentando abrir la puerta... (intento {intentos + 1})");
            intentos++;
        } while (intentos < 3);

        Console.WriteLine($"Se necesitaron {intentos} intentos\n");

        // ── for ───────────────────────────────────────────────
        Console.WriteLine("=== for ===");
        // Ideal cuando sabes cuántas veces repetir
        Console.WriteLine("Generando 5 enemigos:");

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"  Enemigo {i} creado");
        }

        // for inverso
        Console.WriteLine("\nCuenta regresiva:");
        for (int i = 3; i >= 1; i--)
        {
            Console.WriteLine($"  {i}...");
        }
        Console.WriteLine("  ¡GO!\n");

        // ── foreach ───────────────────────────────────────────
        Console.WriteLine("=== foreach ===");
        // Ideal para recorrer listas/arrays (muy usado en Unity)
        string[] inventario = { "Espada", "Escudo", "Poción", "Llave" };

        Console.WriteLine("Inventario del jugador:");
        foreach (string item in inventario)
        {
            Console.WriteLine($"  - {item}");
        }

        // foreach con array de enemigos
        int[] vidasEnemigos = { 50, 80, 30, 120 };
        Console.WriteLine("\nEnemigos vivos (vida > 0):");
        foreach (int v in vidasEnemigos)
        {
            if (v > 0)
                Console.WriteLine($"  Enemigo con {v} HP");
        }

        // ── break y continue ──────────────────────────────────
        Console.WriteLine("\n=== break y continue ===");

        Console.WriteLine("Buscando item raro (para cuando lo encuentre, stop):");
        string[] items = { "piedra", "madera", "gema rara", "hierro", "oro" };

        foreach (string item in items)
        {
            if (item == "gema rara")
            {
                Console.WriteLine($"  ¡Encontré: {item}! (break - detengo la búsqueda)");
                break;  // para el bucle
            }
            Console.WriteLine($"  Revisando: {item}...");
        }

        Console.WriteLine("\nSolo mostrando números impares (continue salta los pares):");
        for (int i = 1; i <= 8; i++)
        {
            if (i % 2 == 0)
                continue;  // salta al siguiente i si es par
            Console.WriteLine($"  {i} (impar)");
        }

        // ── Bucles anidados ───────────────────────────────────
        Console.WriteLine("\n=== Bucles Anidados ===");
        Console.WriteLine("Mapa de tiles 3x3:");

        for (int fila = 0; fila < 3; fila++)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.Write($"[{fila},{col}] ");
            }
            Console.WriteLine();  // salto de línea por fila
        }

        Console.WriteLine("\n✅ Tema 4 completado!");
    }
}
