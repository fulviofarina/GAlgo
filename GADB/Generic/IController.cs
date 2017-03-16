using System;
using GeneticSharp.Domain;
using GeneticSharp.Domain.Chromosomes;
using GeneticSharp.Domain.Fitnesses;

namespace GADB
{
    public interface IController
    {
        GADataSet.GARow GARow
        {
            get;

            set;
        }

        void SetControllerFor(ref GADataSet.ProblemsRow p, int size);

        Action SaveCallBack { get; set; }
        Action CallBack { get; set; }
        Action FinalCallBack { get; set; }
        GeneticAlgorithm GA { get; set; }
        bool StopResume(bool stop);
        /// <summary>
        /// Creates the fitness.
        /// </summary>
        /// <returns>The fitness.</returns>
        IFitness CreateFitness();

        /// <summary>
        /// Creates the chromosome.
        /// </summary>
        /// <returns>The chromosome.</returns>
        IChromosome CreateChromosome();

        Probabilities Probabilities { set; get; }
        Configuration Config { set; get; }
        void RunConfiguration();

        void PostScript(bool bkgWork);
    }
}