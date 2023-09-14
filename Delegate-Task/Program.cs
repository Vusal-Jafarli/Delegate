using Delegate_Task.Classes;

internal class Program
{

    public delegate void MyDelegate();
    private static void Main(string[] args)
    {
        string key;


    start:
        Console.Write("Key daxil edin(basic,pro,expert): "); key = Console.ReadLine();

        if (key == "basic")
        {
            DocumentProgram docProgram = new();
            docProgram.Functions();
            
        }
        else if (key == "pro")
        {
            DocumentProgram docProgram = new ProDocumentProgram();
            docProgram.Functions();
        }
        else if (key == "expert")
        {
            DocumentProgram docProgram = new ExpertDocument();
            docProgram.Functions();

        }
        else
        {
            Console.Clear(); Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Key yanlisdir,yeniden daxil edin..."); Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            Console.Clear();
            goto start;
        }
    }
}
//ByVC
