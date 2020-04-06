﻿using System.Collections.Generic;

namespace GeneticSolver
{
    public interface IGenomeEvalautor<T>
    {
        IEnumerable<FitnessResult<T>> GetFitnessResults(IEnumerable<T> genomes);
    }
}