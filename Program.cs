using System;
using Examen_25._1_Promedio_1.Models;


namespace Examen_25._1_Promedio_1
{
    class Program
    {
        static void Main()
        {
            Board board = new Board(5,5);
            int money = 1000;

            while (true)
            {
                Console.WriteLine("\nDinero actual: $" + money);
                Console.WriteLine("1. Construir Casa ($100)");
                Console.WriteLine("2. Construir Fábrica ($300)");
                Console.WriteLine("3. Construir Departamento ($250)");
                Console.WriteLine("4. Construir Escuela ($400)");
                Console.WriteLine("5. Mostrar tablero");
                Console.WriteLine("6. Pasar turno");
                Console.WriteLine("7. Salir");
                Console.Write("Opción: ");
                string? input = Console.ReadLine();

                if (input == "1")
                {
                    Construir(new House(), "Casa");
                }
                else if (input == "2")
                {
                    Construir(new Factory(), "Fábrica");
                }
                else if (input == "3")
                {
                    Construir(new Apartment(), "Departamento");
                }
                else if (input == "4")
                {
                    Construir(new School(), "Escuela");
                }
                else if (input == "5")
                {
                    board.ShowBoard();
                }
                else if (input == "6")
                {
                    int income = board.GetTotalIncome();
                    int upkeep = board.GetTotalUpkeep();
                    int net = income - upkeep;
                    Console.WriteLine($"\nIngreso total: ${income} - Mantenimiento: ${upkeep} = Ganancia neta: ${net}");
                    money += net;
                }
                else if (input == "7")
                {
                    break;
                }

                void Construir(Building building, string tipo)
                {
                    if (money >= building.Cost)
                    {
                        Console.Write("Ingrese un ID para la ubicación (ej: A1): ");
                        string? id = Console.ReadLine();

                        if (!string.IsNullOrEmpty(id) && board.PlaceBuilding(id, building))
                        {
                            money -= building.Cost;
                            Console.WriteLine($"{tipo} construida exitosamente.");
                        }
                        else
                        {
                            Console.WriteLine("Ubicación inválida o ya ocupada.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No tienes suficiente dinero.");
                    }
                }
            }
        }
    }
}
