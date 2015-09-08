﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Sitecore.Courier.Runner
{
    // Reads the scproj file for excludedfiles and returns them for processing.
    public static class ExclusionReader
    {
        public static List<string> GetExcludedItems(string projectFilePath, string buildConfiguration)
        {
            var excludedItems = new List<string>();

            var reader = XmlReader.Create(projectFilePath);
            reader.MoveToContent();
            while (reader.Read())
            {
                // do stuff

            }


            return excludedItems;
        }
    }
}
