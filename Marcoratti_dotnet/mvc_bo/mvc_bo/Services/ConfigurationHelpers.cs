using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace mvc_bo.Services
{
    public static class ConfigurationHelpers
    {
        public static IConfigurationRoot GetConfiguration(string path, string enviromentName = null)
        {
            var builder = new ConfigurationBuilder().SetBasePath(path).AddJsonFile("appsettings.json",
                optional: true, reloadOnChange: true);

            if (!String.IsNullOrWhiteSpace(enviromentName))
            {
                builder = builder.AddJsonFile($"appsettings.{enviromentName}.json", optional: true);
            }

            builder = builder.AddEnvironmentVariables();

            return builder.Build();
        }

    }
}
