﻿using FileParserTask.Logic;
using ValidationLibrary;
using FileParserTask.UI;
using System.Reflection;
using log4net;
using System;
using System.IO;

namespace FileParserTask.FileParserApp
{
    static class Application
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public static void Run(string[] args)
        {
            var path = @args[0];
            if (File.Exists(path))
            {
                Helper.Help();
                var taskArgs = Console.ReadLine();
                var taskArgsArray = new Parser().GetAppropriateStringArray(taskArgs);

                switch (taskArgsArray.Length)
                {
                    case 1:
                        {
                            Counter counter = new Counter(path);
                            var countStringEnterance = counter.CountStringEnterance(taskArgsArray[0]);
                            Console.WriteLine(countStringEnterance);
                            break;
                        }
                    case 2:
                        {
                            Replacer replacer = new Replacer(path);
                            replacer.ReplaceString(taskArgsArray[0], taskArgsArray[1]);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Ivalid task arguments");
                            log.Warn("Ivalid task arguments");
                            break;
                        }      
                }
            }
            else
            {
                Console.WriteLine($"Can`t find file {path}.");
                log.Warn($"Can`t find file {path}.");
            }
        }
    }
}
