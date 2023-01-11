using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SAC_ToDoList
{
    public class Commission
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "text")]
        public string Description { get; set; }

        [Required]
        [Column(TypeName ="varchar(50)")]
        public string Status { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }

        public Commission()
        { 
        
        }

        public Commission(string description, string status, DateTime? date = null)
        {
            Description = description;
            Status = status;
            Date = date;
        }










        /*public string GetTaskText()
        {
            return taskText;
        }

        //Setters

        public void SetTaskText(string taskText)
        {
            this.taskText = taskText.Trim();
        }
        public void SetTaskState(bool taskState)
        {
            this.taskState = taskState;
        }

        public void SetTaskDate(DateOnly taskDate)
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

        }*/



    }



}
