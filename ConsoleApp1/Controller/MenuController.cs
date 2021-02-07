using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Controller
{
    public static class MenuController
    {
        /// <summary>
        /// Shows the available options on console, and return an object with user's input.
        /// </summary>
        /// <returns>Menu object with users's input.</returns>
        public static Menu ShowOptions()
        {
            var menu = new Menu();
            var algorithmOption = GetAlgorithmOption();
            int controlOrderOption = GetControlOrderOption();

            menu.AlgorithmInput = algorithmOption;
            menu.ControlOrderInput = controlOrderOption;

            return menu;
        }

        /// <summary>
        /// Method used to print the magic square received as parameter.
        /// </summary>
        /// <param name="magicSquare">Magic square to be printed.</param>
        public static void PrintMagicSquare(Report report)
        {
            Console.WriteLine("O algoritmo utilizado foi: {0}", report.AlgorithmName);
            Console.WriteLine("O tempo total gasto em milissegundos pelo algoritmo foi de: {0}", report.ElapsedTime);
            Console.WriteLine("O quadrado mágico encontrado foi: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(report.MagicSquare[i, j] + " | ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Shows the text asking for the control order to be choosen, along with the available options.
        /// </summary>
        /// <returns>The user's valid input.</returns>
        private static int GetControlOrderOption()
        {
            string input;
            var controlOrderOption = -1;
            var invalidOption = false;
            do
            {
                Console.WriteLine(TextResource.MenuText[OptionsEnum.MenuOptions.ControlOrder]);

                var enumValues = Enum.GetValues(typeof(OptionsEnum.ControlOrderOptions));

                foreach (OptionsEnum.ControlOrderOptions enumValue in enumValues)
                {
                    Console.WriteLine(TextResource.ControlOrderText[enumValue]);
                }

                input = Console.ReadLine();

                if (!int.TryParse(input, out controlOrderOption) && !Enum.IsDefined(typeof(OptionsEnum.ControlOrderOptions), controlOrderOption))
                {
                    Console.WriteLine(TextResource.InvalidOptionText);
                    invalidOption = true;
                }

                else
                    invalidOption = false;

            } while (invalidOption);

            return controlOrderOption;
        }

        /// <summary>
        /// Shows the text asking for the algorithm to be choosen, along with the available options.
        /// </summary>
        /// <returns>The user's valid input.</returns>
        private static int GetAlgorithmOption()
        {
            var algorithmOption = -1;
            string input;
            var invalidOption = false;

            do
            {
                Console.WriteLine(TextResource.MenuText[OptionsEnum.MenuOptions.AlgorithmType]);
                var enumValues = Enum.GetValues(typeof(OptionsEnum.AlgorithmOptions));

                foreach (OptionsEnum.AlgorithmOptions enumValue in enumValues)
                {
                    Console.WriteLine(TextResource.AlgorithmText[enumValue]);
                }

                input = Console.ReadLine();

                if (!int.TryParse(input, out algorithmOption) && !Enum.IsDefined(typeof(OptionsEnum.AlgorithmOptions), algorithmOption))
                {
                    Console.WriteLine(TextResource.InvalidOptionText);
                    invalidOption = true;
                }

                else
                    invalidOption = false;

            } while (invalidOption);

            return algorithmOption;
        }
    }
}
