// ============================================================
//  TEMA 1: Variables y Tipos de Datos en C#
//  Autor: Kyara Yactayo
// ============================================================

using System;

class Variables
{
    static void Main()
    {
        Console.WriteLine("=== VARIABLES Y TIPOS DE DATOS ===\n");

        // ── Tipos básicos ──────────────────────────────────────
        int vida = 100;
        float velocidad = 5.5f;
        double distancia = 1234.56;
        bool estaVivo = true;
        char letra = 'K';
        string nombre = "Kyara";

        Console.WriteLine("=== Tipos Básicos ===");
        Console.WriteLine($"Vida (int):         {vida}");
        Console.WriteLine($"Velocidad (float):  {velocidad}");
        Console.WriteLine($"Distancia (double): {distancia}");
        Console.WriteLine($"Esta vivo (bool):   {estaVivo}");
        Console.WriteLine($"Inicial (char):     {letra}");
        Console.WriteLine($"Nombre (string):    {nombre}");

        // ── Constantes ────────────────────────────────────────
        Console.WriteLine("\n=== Constantes ===");
        const int MAX_VIDA = 100;
        const string NOMBRE_JUEGO = "MiJuego";
        Console.WriteLine($"Vida máxima (const): {MAX_VIDA}");
        Console.WriteLine($"Nombre del juego:    {NOMBRE_JUEGO}");

        // ── Inferencia de tipos (var) ──────────────────────────
        Console.WriteLine("\n=== Inferencia con var ===");
        var puntos = 500;        // int
        var mensaje = "Hola!";   // string
        var ratio = 0.75f;       // float
        Console.WriteLine($"Puntos:  {puntos}  → tipo: {puntos.GetType().Name}");
        Console.WriteLine($"Mensaje: {mensaje} → tipo: {mensaje.GetType().Name}");
        Console.WriteLine($"Ratio:   {ratio}   → tipo: {ratio.GetType().Name}");

        // ── Tipos Nullable ────────────────────────────────────
        Console.WriteLine("\n=== Tipos Nullable ===");
        int? vidaNullable = null;
        Console.WriteLine($"Vida nullable sin asignar: {vidaNullable ?? -1}");  // ?? = "si es null, usa -1"
        vidaNullable = 80;
        Console.WriteLine($"Vida nullable asignada: {vidaNullable}");

        // ── Conversiones ──────────────────────────────────────
        Console.WriteLine("\n=== Conversiones ===");
        int dano = 25;
        float danoFloat = dano;          // implícita: int → float
        int danoEntero = (int)5.9f;      // explícita: float → int (pierde decimales)
        Console.WriteLine($"int → float (implícita): {danoFloat}");
        Console.WriteLine($"float → int (explícita): {danoEntero}  (5.9 se convierte en {danoEntero})");

        // ── Alcance (scope) ───────────────────────────────────
        Console.WriteLine("\n=== Alcance de Variables ===");
        int nivelGlobal = 1;
        {
            int bonusBloque = 50;   // solo existe dentro de estas llaves
            Console.WriteLine($"Dentro del bloque - nivel: {nivelGlobal}, bonus: {bonusBloque}");
        }
        // bonusBloque ya no existe aquí
        Console.WriteLine($"Fuera del bloque  - nivel: {nivelGlobal}  (bonus ya no existe)");

        Console.WriteLine("\n✅ Tema 1 completado!");
    }
}
