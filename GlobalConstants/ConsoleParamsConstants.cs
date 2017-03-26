namespace TwoPlayersPingPong.GlobalConstants
{
    using System;

    public static class ConsoleParamsConstants
    {
        public static readonly int MinWindowColumns = 0;
        public static readonly int MaxWindowColumns = Console.WindowHeight;
        public static readonly int MinWindowRows = 0;
        public static readonly int MaxWindowRows = Console.WindowWidth;
        
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
