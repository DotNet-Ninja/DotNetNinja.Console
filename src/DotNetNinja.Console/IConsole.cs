namespace DotNetNinja.Console
{
    public interface IConsole
    {
        void Write(string value);
        void Write(string format, params object[] args);
        void Write(System.ConsoleColor color, string value);
        void Write(System.ConsoleColor color, string format, params object[] args);
        void WriteLine(string value);
        void WriteLine(string format, params object[] args);
        void WriteLine(System.ConsoleColor color, string value);
        void WriteLine(System.ConsoleColor color, string format, params object[] args);
        void Debug(string value);
        void Debug(string format, params object[] args);
        void DebugLine(string value);
        void DebugLine(string format, params object[] args);
        void Info(string value);
        void Info(string format, params object[] args);
        void InfoLine(string value);
        void InfoLine(string format, params object[] args);
        void Warning(string value);
        void Warning(string format, params object[] args);
        void WarningLine(string value);
        void WarningLine(string format, params object[] args);
        void WarningLine(System.Exception exception, string value);
        void WarningLine(System.Exception exception, string format, params object[] args);
        void Error(string value);
        void Error(string format, params object[] args);
        void ErrorLine(string value);
        void ErrorLine(string format, params object[] args);
        void ErrorLine(System.Exception exception, string value);
        void ErrorLine(System.Exception exception, string format, params object[] args);
    }
}