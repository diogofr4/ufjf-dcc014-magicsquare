using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Model
{
    public class Tree
    {
        /// <summary>
        /// Tree's root node.
        /// </summary>
        public Node Root { get; set; }

        /// <summary>
        /// Indicator to be used when the algorithm succeeded.
        /// </summary>
        public bool Success { get; set; }
    }
}
