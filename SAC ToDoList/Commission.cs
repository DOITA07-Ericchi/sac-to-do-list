using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAC_ToDoList
{
    public class Commission
    {
        private string taskText { get; }
        private bool taskState { get; set; }
        private DateTime? taskDate { get; set; }

        public Commission(string taskText)
        {
            this.taskText = taskText;
        }
        
        //Setters
        public void SetTaskState(bool taskState)
        {
            this.taskState = taskState;
        }

        public void SetTaskDate(DateTime taskDate)
        {
            this.taskDate = taskDate;
        }

        //Funzione che stampa tutti gli elementi conosciuti dell'attività
        public void PrintTaskDetails()
        {
            Console.WriteLine("Testo dell'attività: " + taskText);
            Console.Write("Stato dell'attività: ");
            if(taskState)
            {
                Console.WriteLine("Completato");
            } else
            {
                Console.WriteLine("Non completato");
            }
            Console.Write("Data dell'attività: ");
            if(taskDate != null)
            {
                Console.WriteLine(taskDate.ToString());
            }
            else
            {
                Console.WriteLine("non specificata");

                //ciaone a tutti ciao sto scrivando dal mio computer kekw
            }

        }



    }



}
