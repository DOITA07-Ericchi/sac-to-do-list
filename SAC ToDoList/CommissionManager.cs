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
                    Console.WriteLine("Inserisci il testo dell'attività: ");
                    string taskText = Console.ReadLine();
                    Console.WriteLine("L'attività è già in lavorazione? s/N");
                    bool taskBool = Utilities.Convalida();
                    Commission commission = new Commission(taskText, taskBool);

                    commissions.Add(commission);
                    Console.WriteLine("Attività aggiunta con successo!");

                    break;
                case "3":
                    for(int i=0; i<commissions.Count; i++)
                    {
                        Console.WriteLine("Indice " + i + "; Testo attività: " + commissions[i].GetTaskText());
                    }
                    Console.WriteLine("Inserisci l'indice dell'attività da rimuovere");
                    uint indexToCheck = Utilities.ControllaUint(Console.ReadLine());
                    if(indexToCheck > commissions.Count())
                    {
                        Console.WriteLine("Indice non trovato");
                    } else
                    {
                        commissions.Remove(commissions[Int32.Parse(indexToCheck.ToString())]);
                    }
                    //AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
                    break;
                case "4":
                    for (int i = 0; i < commissions.Count; i++)
                    {
                        Console.WriteLine("Indice " + i + "; Testo attività: " + commissions[i].GetTaskText());
                    }
                    Console.WriteLine("Inserisci l'indice dell'attività da modificare");
                    uint textIndexToCheck = Utilities.ControllaUint(Console.ReadLine());
                    if (textIndexToCheck > commissions.Count())
                    {
                        Console.WriteLine("Indice non trovato");
                    }
                    else
                    {
                        Console.WriteLine("Inserisci il testo sostitutivo: ");
                        string newText = Console.ReadLine();

                        commissions[Int32.Parse(textIndexToCheck.ToString())].SetTaskText(newText);
                    }
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
