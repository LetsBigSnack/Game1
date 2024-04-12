namespace libs;

public class InputHandler{
// Static variable for the singleton instance
    private static InputHandler instance;

    // Private constructor to prevent instantiation from outside
    private InputHandler() { }

    // Public property to get the instance
    public static InputHandler Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new InputHandler();
            }
            return instance;
        }
    }

    // Method to handle keyboard input
    public void HandleKey(ConsoleKeyInfo keyInfo)
    {
        GameObject focusedObject = GameEngine.GetFocusedObject();

        if (focusedObject != null)
        {
            // Handle keyboard input to move the player
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    focusedObject.Move(0, -1);
                    break;
                case ConsoleKey.DownArrow:
                    focusedObject.Move(0, 1);
                    break;
                case ConsoleKey.LeftArrow:
                    focusedObject.Move(-1, 0);
                    break;
                case ConsoleKey.RightArrow:
                    focusedObject.Move(1, 0);
                    break;
                default:
                    break;
            }
        }
    }
   
}