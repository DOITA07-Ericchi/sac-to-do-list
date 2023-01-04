using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAC_ToDoList
{
    public class CommissionManager
    {
        List<Commission> commissions;

        public static void ShowMenu()
        {
            Console.WriteLine("1 - Visualizza lista attività");
            Console.WriteLine("2 - Aggiungi nuova attività");
            Console.WriteLine("3 - Rimuovi attività");
            Console.WriteLine("4 - Modifica testo attività");
            Console.WriteLine("5 - Modifica stato attività");
            Console.WriteLine("6 - Aggiungi/modifica data attività");
            Console.WriteLine("7 - Visualizza solo attività da fare");
            Console.WriteLine("0 - Chiudi programma");
        }

        public void UserInput()
        {
            Console.WriteLine("Scegli un'opzione:");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    foreach(Commission element in commissions) {
                        element.PrintTaskDetails();
                    }
                    break;
                case "2":
                    // Aggiungi nuova attività
                    break;
                case "3":
                    // Rimuovi attività
                    break;
                case "4":
                    // Modifica testo attività
                    break;
                case "5":
                    // Modifica stato attività
                    break;
                case "6":
                    // Aggiungi/modifica data attività
                    break;
                case "7":
                    // Visualizza solo attività da fare (opzionale)
                    break;
                case "0":
                    // Chiudi programma
                    break;
                default:
                    Console.WriteLine("Opzione non valida. Scegli un'opzione valida.");
                    break;
            }
        }
    }
}
