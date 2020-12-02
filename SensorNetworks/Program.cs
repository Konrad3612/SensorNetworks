﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorNetworks
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<int, int>();
            dict.Add(20, 25);
            dict.Add(30, 25);
            dict.Add(40, 25);
            dict.Add(10, 25);
            var generator = new TestDataGenerator(dict, 50);
            generator.GenerateData();
            var loader = new ConfigLoader();
            var parameters = loader.LoadAlgorithmParameters();
            var routing = new Routing();
            foreach (var param in parameters)
            {
                routing.FindPath(param);
            }    
            Console.ReadKey();
        }
    }
}