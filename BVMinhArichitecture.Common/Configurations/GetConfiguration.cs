using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace BVMinhArichitecture.Common.Configurations
{
    public class GetConfiguration
    {
        public static IConfiguration _configuration;
        public static string GetConnectString()
        {
            return _configuration.GetConnectionString("MariaDB");
        }

        public static string GetConnectString(string name)
        {
            return _configuration.GetConnectionString(name);
        }

        public static string GetAppSettings(string name)
        {
            try
            {
                return _configuration.GetSection(name).Value ?? string.Empty;
            }
            catch
            {
                return string.Empty;
            }
        }

        public static string GetAppSettings(string name, string subName)
        {
            try
            {
                return _configuration.GetSection(name).GetSection(subName).Value ?? string.Empty;
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
