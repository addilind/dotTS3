﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codegen
{
    class Program
    {
        public static string[] SpecialExports = {"ts3plugin_name", "ts3plugin_version", "ts3plugin_apiVersion", "ts3plugin_author", "ts3plugin_description",
            "ts3plugin_setFunctionPointers", "ts3plugin_init", "ts3plugin_shutdown", "ts3plugin_commandKeyword", "ts3plugin_infoTitle", "ts3plugin_infoData",
            "ts3plugin_freeMemory", "ts3plugin_initMenus", "ts3plugin_initHotkeys", "ts3plugin_onMenuItemEvent"};
        //These will not be autogenerated, since they need to be handled by manually written code

        static void Main(string[] args)
        {
            var osdk = new OfficialSDK();
            Console.WriteLine("Generating shim ts3plugin interface");
            Generator.Shim(osdk);
            Console.WriteLine("Generating host shim interface");
            Generator.HostShimIF(osdk);
            Console.WriteLine("Generating host mono wrapper");
            Generator.HostMono(osdk);
        }
    }
}
