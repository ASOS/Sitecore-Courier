﻿namespace Sitecore.Courier.Runner
{
    using Sitecore.Update;
    using Sitecore.Update.Engine;
    using System;

    /// <summary>
    /// Defines the program class.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Mains the specified args.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            var options = new Options();
            if (CommandLine.Parser.Default.ParseArguments(args, options))
            {
                if (options.Source.StartsWith(":"))
                    options.Source = options.Source.Substring(1);

                if (options.Target.StartsWith(":"))
                    options.Target = options.Target.Substring(1);

                if (options.Output.StartsWith(":"))
                    options.Output = options.Output.Substring(1);
                Console.WriteLine("Source: {0}", options.Source);
                Console.WriteLine("Target: {0}", options.Target);
                Console.WriteLine("Output: {0}", options.Output);
                var diff = new DiffInfo(
                    DiffGenerator.GetDiffCommands(options.Source, options.Target),
                    "Sitecore Courier Package",
                    string.Empty,
                    string.Format("Diff between serialization folders '{0}' and '{1}'.", options.Source, options.Target));

                PackageGenerator.GeneratePackage(diff, string.Empty, options.Output);
            }
            else
            {
                Console.WriteLine(options.GetUsage());
            }
        }
    }
}
