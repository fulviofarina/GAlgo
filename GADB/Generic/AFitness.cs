using System;
using GeneticSharp.Domain.Chromosomes;
using GeneticSharp.Domain.Fitnesses;

namespace GADB
{
    /// <summary>
    /// Ghostwriter fitness.
    /// </summary>
    public class AFitness : IFitness
    {
        public Func<IChromosome, double> FitnessFuncToPass { private get; set; }

        /// <summary>
        /// Performs the evaluation against the specified chromosome.
        /// </summary>
        /// <param name="chromosome">The chromosome to be evaluated.</param>
        /// <returns>The fitness of the chromosome.</returns>
        public double Evaluate(IChromosome chromosome)
        {
            return FitnessFuncToPass(chromosome);
        }
    }
}