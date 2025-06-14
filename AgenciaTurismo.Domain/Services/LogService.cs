using System;
using System.Collections.Generic;
using System.IO;

namespace AgenciaTurismo.Domain.Services
{
    public static class Logger
    {
        private static List<string> _memoryLogs = new();

        public static void LogToConsole(string mensagem)
        {
            Console.WriteLine($"[Console] {mensagem}");
        }

        public static void LogToFile(string mensagem)
        {
            string filePath = "log.txt";
            File.AppendAllText(filePath, $"[File] {DateTime.Now}: {mensagem}{Environment.NewLine}");
        }

        public static void LogToMemory(string mensagem)
        {
            _memoryLogs.Add($"[Memory] {DateTime.Now}: {mensagem}");
        }

        public static IEnumerable<string> GetMemoryLogs()
        {
            return _memoryLogs;
        }
    }
}