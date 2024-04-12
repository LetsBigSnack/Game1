using libs;

class Program
{

    static void Main(string[] args)
    {
        //Setup
        Console.CursorVisible = false;
        GameEngine.Setup();

        // Main game loop
        while (true)
        {
            GameEngine.Render();
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            InputHandler.Instance.HandleKey(keyInfo);
        }
    }
}