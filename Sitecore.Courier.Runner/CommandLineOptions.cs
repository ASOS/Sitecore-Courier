﻿using CommandLine;
using CommandLine.Text;

namespace Sitecore.Courier.Runner
{
    // Define a class to receive parsed values
    class Options
    {
        [Option('s', "source", Required = true,
          HelpText = "Source files")]
        public string Source { get; set; }

        [Option('t', "target", Required = true,
          HelpText = "Target files")]
        public string Target { get; set; }

        [Option('o', "output", Required = true,
          HelpText = "Location of update package")]
        public string Output { get; set; }

        [Option('c', "Build Configuration", Required = false,
            HelpText = "Build Configuration to diff")]
        public string Configuration { get; set; }

        [Option('p', "Path to Sitecore Project File", Required = false,
          HelpText = "Path to sitecore project file if excluding for build configuration")]
        public string ScProjFilePath { get; set; }

        [ParserState]
        public IParserState LastParserState { get; set; }

        [HelpOption]
        public string GetUsage()
        {
            return HelpText.AutoBuild(this,
              (HelpText current) => HelpText.DefaultParsingErrorsHandler(this, current));
        }
    }
}
