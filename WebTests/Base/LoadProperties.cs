using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;

namespace WebTests.Base
{
    public static class LoadProperties
    {
        private static readonly Dictionary<string, string> Properties = new Dictionary<string, string>();

        public static string GetProperty(string key)
        {
            if (Properties.ContainsKey(key))
                return Properties[key];

            return null;
        }

        static LoadProperties()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "roperties", "user.properties");
            if (File.Exists(filePath))
            {
                foreach (var line in File.ReadLines(filePath))
                {
                    if (!string.IsNullOrWhiteSpace(line) && !line.StartsWith("#"))
                    {
                        var parts = line.Split('=');
                        if (parts.Length == 2)
                        {
                            var key = parts[0].Trim();
                            var value = parts[1].Trim();
                            Properties[key] = value;
                        }
                    }
                }
            }
        }
    }
}
