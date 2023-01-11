namespace SAC_ToDoList
{
    public class CommissionManager
    {


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
                    using (CommissionContext db = new CommissionContext())
                    {
                        List<Commission> taskList = db.Commissions.ToList<Commission>();


                        if (taskList.Count == 0)
                        {
                            Console.WriteLine("Nessuna attività trovata.");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("---------------------------");
                            foreach (Commission element in taskList)
                            {
                                Console.WriteLine(element.Description);
                                Console.WriteLine(element.Status);
                                if (element.Date != null) {
                                    Console.WriteLine(element.Date);
                                }
                                else {
                                    Console.WriteLine("Data non inserita!");
                                }
                                Console.WriteLine("---------------------------");
                            }
                            Console.WriteLine("---------------------------");
                            Console.WriteLine();
                        }
                    }
                    break;
                case "2":
                    Console.Write("Inserisci il testo dell'attività: ");
                    string taskText = Console.ReadLine();
                    Console.Write("Inserisci lo stato dell'attività: ");
                    string taskStatus = Console.ReadLine();
                    Commission commission = new Commission(taskText, taskStatus);
                    try
                    {
                        using (CommissionContext db = new CommissionContext())
                        {

                            db.Commissions.Add(commission);
                            db.SaveChanges();

                            Console.WriteLine("Attivita aggiunta con successo!");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Database error: " + e);
                    };


                    break;
                case "3":
                    using (CommissionContext db = new CommissionContext())
                    {
                        List<Commission> taskList = db.Commissions.ToList<Commission>();
                        for (int i = 0; i < taskList.Count; i++)
                        {
                            //Console.WriteLine("Indice " + (i+1) + "; Testo attività: " + commissions[i].GetTaskText());
                        }
                        Console.Write("Inserisci l'indice dell'attività da rimuovere: ");
                        uint indexToCheck = Utilities.ControllaUint(Console.ReadLine());
                        if (indexToCheck > taskList.Count() || indexToCheck == 0)
                        {
                            Console.WriteLine("Indice non trovato.");
                        }
                        else
                        {
                            taskList.Remove(taskList[(Int32.Parse(indexToCheck.ToString())) - 1]);
                        }
                        //AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
                    }
                    break;
                case "4":
                    using (CommissionContext db = new CommissionContext())
                    {
                        List<Commission> taskList = db.Commissions.ToList<Commission>();
                        for (int i = 0; i < taskList.Count; i++)
                        {
                            //Console.WriteLine("Indice " + (i+1) + "; Testo attività: " + commissions[i].GetTaskText());
                        }
                        Console.Write("Inserisci l'indice dell'attività da modificare: ");
                        uint textIndexToCheck = Utilities.ControllaUint(Console.ReadLine());
                        if (textIndexToCheck > taskList.Count() || textIndexToCheck == 0)
                        {
                            Console.WriteLine("Indice non trovato.");
                        }
                        else
                        {
                            Console.Write("Inserisci il testo sostitutivo: ");
                            string newText = Console.ReadLine();

                            //commissions[(Int32.Parse(textIndexToCheck.ToString())) - 1].SetTaskText(newText);
                        }
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
