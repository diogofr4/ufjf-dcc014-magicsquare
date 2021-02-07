using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Model
{
    public class OptionsEnum
    {
        /// <summary>
        /// Possible questions to be asked.
        /// </summary>
        public enum MenuOptions 
        {
            AlgorithmType,
            ControlOrder
        }

        /// <summary>
        /// Possible algorithm options for the user to choose.
        /// </summary>
        public enum AlgorithmOptions 
        {
            BreadthFirstSearch
        }

        /// <summary>
        /// Possible control order options for the user to choose.
        /// </summary>
        public enum ControlOrderOptions
        {
            AscendentOrder,
            DescendentOrder
        }
    }
}
