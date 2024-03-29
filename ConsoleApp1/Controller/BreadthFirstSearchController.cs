﻿using ConsoleApp1.Model;
using ConsoleApp1.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ConsoleApp1.Controller
{
    public static class BreadthFirstSearchController
    {
        /// <summary>
        /// Execute the breadth-first search to find a magicsquare. If not able to find a magic square, is going to return null.
        /// </summary>
        /// <param name="controlOrder">Parameter used to control if the values used to fill the magic square, is going to be on ascending or descending order.</param>
        /// <returns>A magic square if succeded or null otherwise.</returns>
        public static Report Execute(OptionsEnum.ControlOrderOptions controlOrder)
        {
            var watch = Stopwatch.StartNew();
            var tree = new Tree();
            tree.Root = new Node();
            var valuesRow = new List<int>();
            var openNodes = new List<Node>();
            var closedNodes = new List<Node>();

            //The values are added in ascending order.
            for (int i = 1; i < 10; i++)
                valuesRow.Add(i);

            //If the control order is descendent, order the list by descendent.
            if (controlOrder == OptionsEnum.ControlOrderOptions.DescendentOrder)
                valuesRow = valuesRow.OrderByDescending(x => x).ToList();

            foreach (var value in valuesRow)
                tree.Root.Childs.Add(CreateNode(valuesRow, value));

            openNodes = tree.Root.Childs;

            while (openNodes.Any())
            {
                //Always pick the first item from the list.
                var openNode = openNodes.First();
                openNodes = openNodes.Where(x => x != openNode).ToList();
                closedNodes.Add(openNode);

                if (!MagicSquareUtils.VerifyRules(openNode.MagicSquare, out var success))
                    continue;

                if (success)
                {
                    tree.Success = success;
                    watch.Stop();
                    return new Report 
                    { 
                        AlgorithmName = "Bredth-First Search",
                        ElapsedTime = watch.ElapsedMilliseconds,
                        MagicSquare = openNode.MagicSquare
                    };
                }

                foreach (var value in openNode.ValuesRow)
                {
                    //Clone the magic square so it will not alter the original.
                    var magicSquare = (int[,])openNode.MagicSquare.Clone();
                    var nodeValuesRow = openNode.ValuesRow.Where(x => x != value).ToList();
                    var node = CreateNode(nodeValuesRow, value, magicSquare);
                    openNode.Childs.Add(node);
                    openNodes.Add(node);
                }
            }

            return null;
        }

        /// <summary>
        /// Method to create a node to be added on the tree.
        /// </summary>
        /// <param name="valuesRow">List of possible values for the node childs.</param>
        /// <param name="value">Value to be added on the magic square.</param>
        /// <param name="magicSquare">Magic square generated by the node.</param>
        /// <returns>The node created.</returns>
        private static Node CreateNode(List<int> valuesRow, int value, int[,] magicSquare = null)
        {
            magicSquare = MagicSquareUtils.AddsValueToMagicSquare(value, magicSquare);
            var node = new Node(magicSquare, valuesRow.Where(x => x != value).ToList());
            return node;
        }
    }
}
