﻿using System;
using System.Linq;
using GeneticAlgo.Values;
using GeneticSolver;

namespace GeneticAlgo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var solver = new Solver<Values.Values, int>(new ValuesGenerationFactory(), new ValuesGenomeEvaluator(), new ValuesGenomeDescription(), new ValuesSolverLogger());
            ConsoleKeyInfo key = new ConsoleKeyInfo(' ', ConsoleKey.A, false, false, false);
            while (key.Key != ConsoleKey.X && key.Key != ConsoleKey.Q && key.Key != ConsoleKey.Escape)
            {
                var best = solver.Solve(100, 1000);

                Console.WriteLine($"Best = {best.Sum}");
                key = Console.ReadKey();
            }
        }
    }
}