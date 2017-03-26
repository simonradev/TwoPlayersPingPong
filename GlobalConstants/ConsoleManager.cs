namespace TwoPlayersPingPong.GlobalConstants
{
    using System;

    public static class ConsoleManager
    {
        public static readonly int MinWindowColumns = 0;
        public static readonly int MaxWindowColumns = Console.WindowWidth;
        public static readonly int MinWindowRows = 0;
        public static readonly int MaxWindowRows = Console.WindowHeight;
        
        public static void SetCursorVisability(CursorVisabilities command)
        {
            if (command == CursorVisabilities.Visible)
            {
                Console.CursorVisible = true;
            }
            else
            {
                Console.CursorVisible = false;
            }
        }

        public static void SetConsoleWindowWidthAndHeight()
        {
            Console.BufferHeight = Console.WindowHeight;
        }
    }
}
