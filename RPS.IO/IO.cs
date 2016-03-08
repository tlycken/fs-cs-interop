using System;
using System.Collections.Generic;
using System.Linq;

namespace RPS.IO
{
    public static class IO
    {
        public static string Prompt(string query, params string[] options)
        {
            Console.WriteLine(query);
            if (options.Length > 0)
            {
                Console.Write($"[{string.Join("/", options)}]");
            }
            Console.Write("> ");

            var input = Console.ReadLine().Trim().ToLowerInvariant();

            while (!input.IsValid(options))
            {
                if (input.IsDefault(options))
                {
                    return options.Default().Trim().ToLowerInvariant();
                }

                input = Prompt($"Valid options are {string.Join(", ", options)}");
            }

            return input;
        }
    }

    internal static class StringExtensions
    {
        internal static bool IsValid(this string input, IEnumerable<string> options)
        {
            return options.Any()
                ? options.Select(o => o.Trim().ToLowerInvariant()).Contains(input)
                : input.Length > 0;
        }

        internal static bool IsDefault(this string input, IEnumerable<string> options)
        {
            return input.Length == 0 && options.HasDefault();
        }

        internal static bool HasDefault(this IEnumerable<string> options)
        {
            return options.Count(o => o.ToUpperInvariant() == o) == 1;
        }

        internal static string Default(this IEnumerable<string> options)
        {
            return options.Count(o => o == o.ToUpperInvariant()) == 1
                ? options.Single(o => o == o.ToUpperInvariant())
                : null;
        }
    }
}
