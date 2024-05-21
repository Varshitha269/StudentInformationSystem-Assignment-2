using Microsoft.Extensions.Configuration;
using SIS_Assignment_C_.Models;
using SIS_Assignment_C_.Main;
using SIS_Assignment_C_.MyExceptions;
using SIS_Assignment_C_.Repositories;
using SIS_Assignment_C_.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS_Assignment_C_.Util 
{
    public static class sqlConnectionutil
    {
        private static IConfiguration _iconfiguration;

        public static string GetConnectionString()
        {
            return _iconfiguration.GetConnectionString("LocalConnectionString");
        }

        private static void GetAppSettingsFile()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("sqlcon.json", optional: false);
            _iconfiguration = builder.Build();
        }



        static sqlConnectionutil()
        {
            GetAppSettingsFile();
        }

    }
}
