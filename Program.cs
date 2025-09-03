
namespace first_oop_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello to maze game!!");
            Console.WriteLine("use the keyboardarrows to move the player");
            maze imaze = new maze(20,50);
            while (true)
            {
                imaze.drowmaze();
                imaze.moveplayer();
            }
        }
    }
}
