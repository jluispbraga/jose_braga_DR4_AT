using System;
using System.Collections.Generic;
using System.IO;

namespace AgenciaTurismo.Domain.Utils
{
    public static class Logger
    {
        private static readonly List<string> MemLog = new();

        public static void LogToConsole(string message)
        {
            Console.WriteLine($"[Console] {message}");
        }

        public static void LogToFile(string message)
        {
            var logPath = Path.Combine(AppContext.BaseDirectory, "log.txt");
            File.AppendAllText(logPath, $"[File] {DateTime.Now:G} - {message}{Environment.NewLine}");
        }

        public static void LogToMemory(string message)
        {
            MemLog.Add($"[Memory] {DateTime.Now:G} - {message}");
        }

        public static IEnumerable<string> GetMemoryLogs() => MemLog.AsReadOnly();
    }
}