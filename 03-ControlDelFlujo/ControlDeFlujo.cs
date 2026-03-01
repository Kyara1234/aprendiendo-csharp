// ============================================================
//  TEMA 3: Control de Flujo en C#
//  Autor: Kyara Yactayo
// ============================================================

using System;

class ControlDeFlujo
{
    static void Main()
    {
        Console.WriteLine("=== CONTROL DE FLUJO ===\n");

        // ── if / else if / else ───────────────────────────────
        Console.WriteLine("=== if / else if / else ===");
        int vida = 35;

        if (vida > 70)
            Console.WriteLine("Estado: Saludable 💚");
        else if (vida > 30)
            Console.WriteLine("Estado: Herido 💛");
        else
            Console.WriteLine("Estado: Crítico ❤️");

        // ── if anidados ───────────────────────────────────────
        Console.WriteLine("\n=== if Anidados ===");
        bool tieneArmadura = true;
        int defensa = 20;

        if (tieneArmadura)
        {
            if (defensa >= 20)
                Console.WriteLine("Armadura fuerte: bloquea todo el daño");
            else
                Console.WriteLine("Armadura débil: bloquea parte del daño");
        }
        else
        {
            Console.WriteLine("Sin armadura: recibe daño completo");
        }

        // ── switch-case clásico ───────────────────────────────
        Console.WriteLine("\n=== switch-case ===");
        string arma = "espada";

        switch (arma)
        {
            case "espada":
                Console.WriteLine("Arma: Espada - Daño: 30");
                break;
            case "arco":
                Console.WriteLine("Arma: Arco - Daño: 20 (a distancia)");
                break;
            case "baston":
                Console.WriteLine("Arma: Bastón - Daño: 25 (mágico)");
                break;
            default:
                Console.WriteLine("Arma desconocida");
                break;
        }

        // ── switch expression (C# 8+) ─────────────────────────
        Console.WriteLine("\n=== switch expression (C# 8+) ===");
        int nivel = 3;

        string rango = nivel switch
        {
            1 => "Principiante",
            2 => "Aprendiz",
            3 => "Intermedio",
            4 => "Avanzado",
            5 => "Maestro",
            _ => "Nivel desconocido"
        };
        Console.WriteLine($"Nivel {nivel} → Rango: {rango}");

        // ── Pattern Matching ──────────────────────────────────
        Console.WriteLine("\n=== Pattern Matching ===");
        object objeto = 42;

        string descripcion = objeto switch
        {
            int n when n > 100  => "Número grande",
            int n when n > 0    => "Número positivo",
            int                 => "Cero o negativo",
            string s            => $"Es un string: {s}",
            _                   => "Tipo desconocido"
        };
        Console.WriteLine($"El objeto es: {descripcion}");

        // ── Guardias en switch (when) ─────────────────────────
        Console.WriteLine("\n=== Guardias con when ===");
        int dano = 85;

        string resultado = dano switch
        {
            int d when d >= 100 => "¡GOLPE CRÍTICO!",
            int d when d >= 70  => "Golpe fuerte",
            int d when d >= 40  => "Golpe normal",
            int d when d > 0    => "Golpe débil",
            _                   => "Falló el ataque"
        };
        Console.WriteLine($"Daño {dano} → {resultado}");

        Console.WriteLine("\n✅ Tema 3 completado!");
    }
}
