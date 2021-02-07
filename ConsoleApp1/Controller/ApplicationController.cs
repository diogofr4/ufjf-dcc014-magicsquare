using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Controller
{
    public class ApplicationController
    {
        /// <summary>
        /// Start the application, showing menu options and executing the chosen algorithm.
        /// </summary>
        public void Start()
        {
            var menu = MenuController.ShowOptions();
            var report = new Report();
            switch ((OptionsEnum.AlgorithmOptions)menu.AlgorithmInput)
            {
                case OptionsEnum.AlgorithmOptions.BreadthFirstSearch:
                    report = BreadthFirstSearchController.Execute((OptionsEnum.ControlOrderOptions)menu.ControlOrderInput);
                    break;

                default:
                    break;
            }

            MenuController.PrintMagicSquare(report);
        }
    }
}
