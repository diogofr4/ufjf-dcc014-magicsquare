using ConsoleApp1.Controller;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var application = new ApplicationController();
            application.Start();
        }
    }
}
