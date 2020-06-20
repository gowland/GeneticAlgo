﻿using System.Collections.Generic;
using GeneticSolver;
using GeneticSolver.GenomeProperty;
using GeneticSolver.RequiredInterfaces;

namespace DungeonCardsGeneticAlgo.Support.Multipliers
{
    public class GameAgentMultipliersDescription : IGenomeDescription<GameAgentMultipliers>
    {
        private readonly IRandom _random;
        private readonly double _minChange = -15;
        private readonly double _maxChange = 15;
        private int _minMultiplierValue = -100;
        private int _maxMultiplierValue = 100;

        public GameAgentMultipliersDescription(IRandom random)
        {
            _random = random;
        }

        public IEnumerable<IGenomeProperty<GameAgentMultipliers>> Properties => new[]
        {
            new DoubleGenomeProperty<GameAgentMultipliers>(g => g.GoldScoreMultiplier[0], (g, val) => g.GoldScoreMultiplier[0] = val, _minMultiplierValue, _maxMultiplierValue, _minChange, _maxChange, _random),
            new DoubleGenomeProperty<GameAgentMultipliers>(g => g.GoldScoreMultiplier[1], (g, val) => g.GoldScoreMultiplier[1] = val, _minMultiplierValue, _maxMultiplierValue, _minChange, _maxChange, _random),
            new DoubleGenomeProperty<GameAgentMultipliers>(g => g.GoldScoreMultiplier[2], (g, val) => g.GoldScoreMultiplier[2] = val, _minMultiplierValue, _maxMultiplierValue, _minChange, _maxChange, _random),
            new DoubleGenomeProperty<GameAgentMultipliers>(g => g.MonsterWhenPossessingWeaponScoreMultiplier[0], (g, val) => g.MonsterWhenPossessingWeaponScoreMultiplier[0] = val, _minMultiplierValue, _maxMultiplierValue, _minChange, _maxChange, _random),
            new DoubleGenomeProperty<GameAgentMultipliers>(g => g.MonsterWhenPossessingWeaponScoreMultiplier[1], (g, val) => g.MonsterWhenPossessingWeaponScoreMultiplier[1] = val, _minMultiplierValue, _maxMultiplierValue, _minChange, _maxChange, _random),
            new DoubleGenomeProperty<GameAgentMultipliers>(g => g.MonsterWhenPossessingWeaponScoreMultiplier[2], (g, val) => g.MonsterWhenPossessingWeaponScoreMultiplier[2] = val, _minMultiplierValue, _maxMultiplierValue, _minChange, _maxChange, _random),
            new DoubleGenomeProperty<GameAgentMultipliers>(g => g.MonsterWhenNotPossessingWeaponScoreMultiplier[0], (g, val) => g.MonsterWhenNotPossessingWeaponScoreMultiplier[0] = val, _minMultiplierValue, _maxMultiplierValue, _minChange, _maxChange, _random),
            new DoubleGenomeProperty<GameAgentMultipliers>(g => g.MonsterWhenNotPossessingWeaponScoreMultiplier[1], (g, val) => g.MonsterWhenNotPossessingWeaponScoreMultiplier[1] = val, _minMultiplierValue, _maxMultiplierValue, _minChange, _maxChange, _random),
            new DoubleGenomeProperty<GameAgentMultipliers>(g => g.MonsterWhenNotPossessingWeaponScoreMultiplier[2], (g, val) => g.MonsterWhenNotPossessingWeaponScoreMultiplier[2] = val, _minMultiplierValue, _maxMultiplierValue, _minChange, _maxChange, _random),
            new DoubleGenomeProperty<GameAgentMultipliers>(g => g.WeaponWhenPossessingWeaponScoreMultiplier[0], (g, val) => g.WeaponWhenPossessingWeaponScoreMultiplier[0] = val, _minMultiplierValue, _maxMultiplierValue, _minChange, _maxChange, _random),
            new DoubleGenomeProperty<GameAgentMultipliers>(g => g.WeaponWhenPossessingWeaponScoreMultiplier[1], (g, val) => g.WeaponWhenPossessingWeaponScoreMultiplier[1] = val, _minMultiplierValue, _maxMultiplierValue, _minChange, _maxChange, _random),
            new DoubleGenomeProperty<GameAgentMultipliers>(g => g.WeaponWhenPossessingWeaponScoreMultiplier[2], (g, val) => g.WeaponWhenPossessingWeaponScoreMultiplier[2] = val, _minMultiplierValue, _maxMultiplierValue, _minChange, _maxChange, _random),
            new DoubleGenomeProperty<GameAgentMultipliers>(g => g.WeaponWhenPossessingNotWeaponScoreMultiplier[0], (g, val) => g.WeaponWhenPossessingNotWeaponScoreMultiplier[0] = val, _minMultiplierValue, _maxMultiplierValue, _minChange, _maxChange, _random),
            new DoubleGenomeProperty<GameAgentMultipliers>(g => g.WeaponWhenPossessingNotWeaponScoreMultiplier[1], (g, val) => g.WeaponWhenPossessingNotWeaponScoreMultiplier[1] = val, _minMultiplierValue, _maxMultiplierValue, _minChange, _maxChange, _random),
            new DoubleGenomeProperty<GameAgentMultipliers>(g => g.WeaponWhenPossessingNotWeaponScoreMultiplier[2], (g, val) => g.WeaponWhenPossessingNotWeaponScoreMultiplier[2] = val, _minMultiplierValue, _maxMultiplierValue, _minChange, _maxChange, _random),
        };
    }
}