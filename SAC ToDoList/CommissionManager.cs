﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAC_ToDoList
{
    public class CommissionManager
    {
        List<Commission> commissions = new();

        private bool closeProgram = false;

        public bool GetCloseProgramBool()
        {
            return closeProgram;
        }

        public void ShowMenu()
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
            Console.Write("Scegli un'opzione: ");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    if(commissions.Count == 0) { 
                    Console.WriteLine("Nessuna attività trovata.");
                    }
                    else
                    {
                        foreach (Commission element in commissions)
                        {
                            Console.WriteLine("----------------------");
                            //element.PrintTaskDetails();
                            Console.WriteLine("----------------------");
                        }
                    }

                    break;
                case "2":
                    Console.Write("Inserisci il testo dell'attività: ");
                    string taskText = Console.ReadLine();
                    Console.Write("L'attività è già in lavorazione? s/N: ");
                    bool taskBool = Utilities.Convalida();
                    //Commission commission = new Commission(taskText, taskBool);

                    //commissions.Add(commission);
                    Console.WriteLine("Attività aggiunta con successo!");

                    break;
                case "3":
                    for(int i=0; i<commissions.Count; i++)
                    {
                        //Console.WriteLine("Indice " + (i+1) + "; Testo attività: " + commissions[i].GetTaskText());
                    }
                    Console.Write("Inserisci l'indice dell'attività da rimuovere: ");
                    uint indexToCheck = Utilities.ControllaUint(Console.ReadLine());
                    if(indexToCheck > commissions.Count() || indexToCheck == 0)
                    {
                        Console.WriteLine("Indice non trovato.");
                    } else
                    {
                        commissions.Remove(commissions[(Int32.Parse(indexToCheck.ToString())) - 1]);
                    }
                    //AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
                    break;
                case "4":
                    for (int i = 0; i < commissions.Count; i++)
                    {
                        //Console.WriteLine("Indice " + (i+1) + "; Testo attività: " + commissions[i].GetTaskText());
                    }
                    Console.Write("Inserisci l'indice dell'attività da modificare: ");
                    uint textIndexToCheck = Utilities.ControllaUint(Console.ReadLine());
                    if (textIndexToCheck > commissions.Count() || textIndexToCheck == 0)
                    {
                        Console.WriteLine("Indice non trovato.");
                    }
                    else
                    {
                        Console.Write("Inserisci il testo sostitutivo: ");
                        string newText = Console.ReadLine();

                        //commissions[(Int32.Parse(textIndexToCheck.ToString())) - 1].SetTaskText(newText);
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
                    closeProgram = true;
                    break;
                default:
                    Console.Write("Opzione non valida. Premi Invio per continuare...");
                    Console.ReadLine();
                    break;
            }

            //Console.Clear();
            //ShowMenu();
        }
    }
}
