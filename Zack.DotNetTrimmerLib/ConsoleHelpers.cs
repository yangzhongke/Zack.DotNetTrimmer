namespace Zack.DotNetTrimmerLib
{
    public static class ConsoleHelpers
    {
        public static void WriteInfo(string message)
        {
            Console.ResetColor();
            Console.WriteLine(message);
        }

        public static void WriteWarning(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void WriteError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
