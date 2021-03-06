﻿using System;
using System.IO;
using System.Linq;
using GeneticSolver;
using GeneticSolver.RequiredInterfaces;

namespace DungeonCardsGeneticAlgo.Support
{
    public class GameAgentSolverLogger : ISolverLogger<GameAgentMultipliers, double>
    {
        private StreamWriter _logFile;
        private readonly Guid _runId;

        public GameAgentSolverLogger()
        {
            _runId = Guid.NewGuid();
        }
        public void Start()
        {
            Console.WriteLine($"Starting {_runId}");
            _logFile = new StreamWriter($"log_{_runId}.csv");
        }

        public void LogStartGeneration(int generationNumber)
        {
        }

        public void LogGenerationInfo(IGenerationResult<GameAgentMultipliers, double> generationResult)
        {
            Console.WriteLine($"{_runId},{generationResult.GenerationNumber},{generationResult.FittestGenome.Fitness}");
            _logFile.WriteLine($"{_runId},{generationResult.GenerationNumber},{generationResult.FittestGenome.Fitness}");
        }

        public void LogGeneration(IGenerationResult<GameAgentMultipliers, double> generation)
        {
            using (var resultFile = new StreamWriter($"results_{_runId}.csv"))
            {
                var best = generation.FittestGenome.GenomeInfo.Genome;
                resultFile.WriteLine($"Gold multipliers              {string.Join(", ", best.GoldScoreMultiplier.Select(d => $"{d:0.0000}"))}");
                resultFile.WriteLine($"Monster w/ weapon multipliers {string.Join(", ", best.MonsterWhenPossessingWeaponScoreMultiplier.Select(d => $"{d:0.0000}"))}");
                resultFile.WriteLine($"Monster no weapon multipliers {string.Join(", ", best.MonsterWhenNotPossessingWeaponScoreMultiplier.Select(d => $"{d:0.0000}"))}");
                resultFile.WriteLine($"Weapon w/ weapon multipliers  {string.Join(", ", best.WeaponWhenPossessingWeaponScoreMultiplier.Select(d => $"{d:0.0000}"))}");
                resultFile.WriteLine($"Weapon no weapon multipliers  {string.Join(", ", best.WeaponWhenPossessingNotWeaponScoreMultiplier.Select(d => $"{d:0.0000}"))}");
                resultFile.Close();
            }
        }

        public void End()
        {
            Console.WriteLine($"Fin {_runId}");

            _logFile.Flush();
            _logFile.Close();
            _logFile = null;
        }
    }
}