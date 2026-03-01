// ============================================================
//  TEMA 2: Operadores en C#
//  Autor: Kyara Yactayo
// ============================================================

using System;

class Operadores
{
    static void Main()
    {
        Console.WriteLine("=== OPERADORES ===\n");

        // ── Aritméticos ───────────────────────────────────────
        Console.WriteLine("=== Aritméticos ===");
        int a = 10, b = 3;
        Console.WriteLine($"{a} + {b} = {a + b}");
        Console.WriteLine($"{a} - {b} = {a - b}");
        Console.WriteLine($"{a} * {b} = {a * b}");
        Console.WriteLine($"{a} / {b} = {a / b}  (división entera)");
        Console.WriteLine($"{a} % {b} = {a % b}  (módulo: resto de la división)");

        // Ejemplo de juego: saber si un número es par con módulo
        int ronda = 4;
        Console.WriteLine($"\nRonda {ronda} es par: {ronda % 2 == 0}");

        // ── Comparación ───────────────────────────────────────
        Console.WriteLine("\n=== Comparación ===");
        int vida = 80;
        int vidaMaxima = 100;
        Console.WriteLine($"vida == vidaMaxima  → {vida == vidaMaxima}");
        Console.WriteLine($"vida != vidaMaxima  → {vida != vidaMaxima}");
        Console.WriteLine($"vida > 50           → {vida > 50}");
        Console.WriteLine($"vida < 50           → {vida < 50}");
        Console.WriteLine($"vida >= 80          → {vida >= 80}");
        Console.WriteLine($"vida <= 100         → {vida <= 100}");

        // ── Lógicos ───────────────────────────────────────────
        Console.WriteLine("\n=== Lógicos ===");
        bool tieneEspada = true;
        bool tieneMana = false;
        Console.WriteLine($"tieneEspada && tieneMana  → {tieneEspada && tieneMana}  (AND: los dos deben ser true)");
        Console.WriteLine($"tieneEspada || tieneMana  → {tieneEspada || tieneMana}  (OR: al menos uno true)");
        Console.WriteLine($"!tieneEspada              → {!tieneEspada}              (NOT: invierte)");

        // ── Asignación ────────────────────────────────────────
        Console.WriteLine("\n=== Asignación ===");
        int puntos = 100;
        puntos += 50;   Console.WriteLine($"puntos += 50  → {puntos}");
        puntos -= 20;   Console.WriteLine($"puntos -= 20  → {puntos}");
        puntos *= 2;    Console.WriteLine($"puntos *= 2   → {puntos}");
        puntos /= 4;    Console.WriteLine($"puntos /= 4   → {puntos}");

        // ── Incremento y Decremento ───────────────────────────
        Console.WriteLine("\n=== Incremento / Decremento ===");
        int contador = 5;
        Console.WriteLine($"Original: {contador}");
        contador++;
        Console.WriteLine($"contador++  → {contador}");
        contador--;
        Console.WriteLine($"contador--  → {contador}");

        // ── Operador Ternario ─────────────────────────────────
        Console.WriteLine("\n=== Operador Ternario ===");
        int vidaJugador = 30;
        string estado = vidaJugador > 50 ? "Saludable" : "En peligro";
        Console.WriteLine($"Vida: {vidaJugador} → Estado: {estado}");

        // ── Coalescencia Nula (??) ────────────────────────────
        Console.WriteLine("\n=== Coalescencia Nula ?? ===");
        string? nombreJugador = null;
        string mostrar = nombreJugador ?? "Jugador Anónimo";
        Console.WriteLine($"Nombre: {mostrar}  (era null, usó el valor por defecto)");
        nombreJugador = "Kyara";
        mostrar = nombreJugador ?? "Jugador Anónimo";
        Console.WriteLine($"Nombre: {mostrar}  (ya tenía valor, lo usó)");

        // ── Operadores Bit a Bit (Flags) ──────────────────────
        Console.WriteLine("\n=== Operadores Bit a Bit (Flags) ===");
        // Muy útiles para estados en videojuegos
        int puedeCorrer  = 0b0001;  // 1
        int puedeSaltar  = 0b0010;  // 2
        int puedeAtacar  = 0b0100;  // 4

        int habilidades = puedeCorrer | puedeSaltar;  // activa correr Y saltar
        Console.WriteLine($"Tiene correr:  {(habilidades & puedeCorrer) != 0}");
        Console.WriteLine($"Tiene saltar:  {(habilidades & puedeSaltar) != 0}");
        Console.WriteLine($"Tiene atacar:  {(habilidades & puedeAtacar) != 0}");

        Console.WriteLine("\n✅ Tema 2 completado!");
    }
}
