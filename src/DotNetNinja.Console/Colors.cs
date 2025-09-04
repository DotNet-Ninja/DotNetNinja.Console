using System;

namespace DotNetNinja.Console
{
    public static class Colors
    {
        public static ConsoleColor Default { get; private set; } = System.Console.ForegroundColor;
        public static ConsoleColor Info { get; set; } = ConsoleColor.Cyan;
        public static ConsoleColor Warning { get; set; } = ConsoleColor.Yellow;
        public static ConsoleColor Error { get; set; } = ConsoleColor.Red;
        public static ConsoleColor Success { get; set; } = ConsoleColor.Green;
        public static ConsoleColor Debug { get; set; } = ConsoleColor.Gray;


        public static void UseMonochrome()
        {
            Colors.Debug = Colors.Default;
            Colors.Info = Colors.Default;
            Colors.Warning = Colors.Default;
            Colors.Error = Colors.Default;
            Colors.Success = Colors.Default;
        }

        public static void UseDefault()
        {
            Colors.Debug = ConsoleColor.Gray;
            Colors.Info = ConsoleColor.Gray;
            Colors.Warning = ConsoleColor.Gray;
            Colors.Error = ConsoleColor.Gray;
            Colors.Success = ConsoleColor.Gray;
        }
    }
}
