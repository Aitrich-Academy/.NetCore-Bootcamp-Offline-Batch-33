using Exercise_OOP.Managers;
using Exercise_OOP.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        
        JobSeekerManager.JobSeekerManagers manager = new JobSeekerManager.JobSeekerManagers();
        manager.ShowMainMenu();
    }
}