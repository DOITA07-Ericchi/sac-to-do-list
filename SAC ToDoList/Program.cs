
using SAC_ToDoList;

CommissionManager menuManager = new CommissionManager();

//RICORDATEVI DI PULLARE PRIMA DI FARE QUALSIASI COSA O VI VENGO A PICCHIARE PERSONALMENTE

Console.WriteLine("Inizio programma");
menuManager.ShowMenu();
while (!menuManager.GetCloseProgramBool())
{
    menuManager.UserInput();
}