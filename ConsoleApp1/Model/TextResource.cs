using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Model
{
    public static class TextResource
    {
        /// <summary>
        /// Text to be used for each menu option.
        /// </summary>
        public static Dictionary<OptionsEnum.MenuOptions, string> MenuText = new Dictionary<OptionsEnum.MenuOptions, string>()
        {
            {OptionsEnum.MenuOptions.AlgorithmType, "Escolha o algoritmo à ser utilizado: " },
            {OptionsEnum.MenuOptions.ControlOrder, "Escolha qual será a ordem de controle à ser utilizada:" }
        };

        /// <summary>
        /// Text to be used for each algorithm option.
        /// </summary>
        public static Dictionary<OptionsEnum.AlgorithmOptions, string> AlgorithmText = new Dictionary<OptionsEnum.AlgorithmOptions, string> 
        {
            {OptionsEnum.AlgorithmOptions.BreadthFirstSearch, (int)OptionsEnum.AlgorithmOptions.BreadthFirstSearch + ". Breadth-First Search" }
        };

        /// <summary>
        /// Text to be used for each control order option.
        /// </summary>
        public static Dictionary<OptionsEnum.ControlOrderOptions, string> ControlOrderText = new Dictionary<OptionsEnum.ControlOrderOptions, string> 
        { 
            {OptionsEnum.ControlOrderOptions.AscendentOrder, (int)OptionsEnum.ControlOrderOptions.AscendentOrder + ". Ordem Crescente" },
            {OptionsEnum.ControlOrderOptions.DescendentOrder, (int)OptionsEnum.ControlOrderOptions.DescendentOrder+ ". Ordem Decrescente" },
        };

        /// <summary>
        /// Text to be used when a invalid option was choosed by the user.
        /// </summary>
        public static string InvalidOptionText = "Opção selecionada inválida.";
    }
}
