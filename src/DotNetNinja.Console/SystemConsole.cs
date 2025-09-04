namespace DotNetNinja.Console
{
    public class SystemConsole
    {
        public void Write(string value)
        {
            System.Console.Write(value);
        }

        public void WriteLine(string value)
        {
            System.Console.WriteLine(value);
        }

        public void Write(string format, params object[] args)
        {
            System.Console.Write(string.Format(format, args));
        }

        public void WriteLine(string format, params object[] args)
        {
            System.Console.WriteLine(string.Format(format, args));
        }

        public void Write(System.ConsoleColor color, string value)
        {
            var originalColor = System.Console.ForegroundColor;
            System.Console.ForegroundColor = color;
            try
            {
                System.Console.Write(value);
            }
            finally
            {
                System.Console.ForegroundColor = originalColor;
            }
        }

        public void WriteLine(System.ConsoleColor color, string value)
        {
            var originalColor = System.Console.ForegroundColor;
            System.Console.ForegroundColor = color;
            try
            {
                System.Console.WriteLine(value);
            }
            finally
            {
                System.Console.ForegroundColor = originalColor;
            }
        }

        public void Write(System.ConsoleColor color, string format, params object[] args)
        {
            var originalColor = System.Console.ForegroundColor;
            System.Console.ForegroundColor = color;
            try
            {
                System.Console.Write(string.Format(format, args));
            }
            finally
            {
                System.Console.ForegroundColor = originalColor;
            }
        }

        public void WriteLine(System.ConsoleColor color, string format, params object[] args)
        {
            var originalColor = System.Console.ForegroundColor;
            System.Console.ForegroundColor = color;
            try
            {
                System.Console.WriteLine(string.Format(format, args));
            }
            finally
            {
                System.Console.ForegroundColor = originalColor;
            }
        }

        public void Debug(string value)
        {
            Write(Colors.Debug, value);
        }

        public void Debug(string format, params object[] args)
        {
            Write(Colors.Debug, format, args);
        }

        public void DebugLine(string value)
        {
            WriteLine(Colors.Debug, value);
        }

        public void DebugLine(string format, params object[] args)
        {
            WriteLine(Colors.Debug, format, args);
        }

        public void Info(string value)
        {
            Write(Colors.Info, value);
        }

        public void Info(string format, params object[] args)
        {
            Write(Colors.Info, format, args);
        }

        public void InfoLine(string value)
        {
            WriteLine(Colors.Info, value);
        }

        public void InfoLine(string format, params object[] args)
        {
            WriteLine(Colors.Info, format, args);
        }

        public void Warning(string value)
        {
            Write(Colors.Warning, value);
        }

        public void Warning(string format, params object[] args)
        {
            Write(Colors.Warning, format, args);
        }

        public void WarningLine(string value)
        {
            WriteLine(Colors.Warning, value);
        }

        public void WarningLine(string format, params object[] args)
        {
            WriteLine(Colors.Warning, format, args);
        }

        public void WarningLine(System.Exception exception, string value)
        {
            WriteLine(Colors.Warning, value);
            WriteLine(Colors.Warning, exception.GetType().ToString());
            WriteLine(Colors.Warning, exception.StackTrace ?? "No stack trace available.");
        }

        public void WarningLine(System.Exception exception, string format, params object[] args)
        {
            WriteLine(Colors.Warning, string.Format(format, args));
            WriteLine(Colors.Warning, exception.GetType().ToString());
            WriteLine(Colors.Warning, exception.StackTrace ?? "No stack trace available.");
        }

        public void Error(string value)
        {
            Write(Colors.Error, value);
        }

        public void Error(string format, params object[] args)
        {
            Write(Colors.Error, format, args);
        }

        public void ErrorLine(string value)
        {
            WriteLine(Colors.Error, value);
        }

        public void ErrorLine(string format, params object[] args)
        {
            WriteLine(Colors.Error, format, args);
        }

        public void ErrorLine(System.Exception exception, string value)
        {
            WriteLine(Colors.Error, value);
            WriteLine(Colors.Error, exception.GetType().ToString());
            WriteLine(Colors.Error, exception.StackTrace ?? "No stack trace available.");
        }

        public void ErrorLine(System.Exception exception, string format, params object[] args)
        {
            WriteLine(Colors.Error, string.Format(format, args));
            WriteLine(Colors.Error, exception.GetType().ToString());
            WriteLine(Colors.Error, exception.StackTrace ?? "No stack trace available.");
        }
    }
}