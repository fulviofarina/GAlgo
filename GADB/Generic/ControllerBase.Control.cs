using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using GeneticSharp.Domain;
using GeneticSharp.Domain.Chromosomes;
using GeneticSharp.Domain.Crossovers;
using GeneticSharp.Domain.Fitnesses;
using GeneticSharp.Domain.Mutations;
using GeneticSharp.Domain.Populations;
using GeneticSharp.Domain.Selections;
using GeneticSharp.Domain.Terminations;
using GeneticSharp.Infrastructure.Threading;

namespace GADB
{
    /// <summary>
    /// THESE WORK BY DEFAULT BUT THE USER CAN OVERRIDE THEM
    /// </summary>
    public abstract partial class ControllerBase : IController
    {

        public bool StopResume(bool stop)
        {
            if (stop) GA.Stop();
            else GA.Resume();
            return !GA.IsRunning; //true if stoppped, false if running
        }

        /// <summary>
        /// Creates the fitness. Must be overriden
        /// </summary>
        /// <returns>
        /// The fitness
        /// </returns>
        public virtual IFitness CreateFitness()
        {
            AFitness f = new AFitness();


            f.FitnessFuncToPass = c =>
            {



                GADataSet.SolutionsDataTable sols = new GADataSet.SolutionsDataTable();
                GADataSet.SolutionsRow currentSolution = sols.NewSolutionsRow();
                // GADataSet.SolutionsDataTable sols = new GADataSet.SolutionsDataTable();

                // GADataSet.SolutionsRow currentSolution = sols.NewSolutionsRow();

                currentSolution.Initialize(c.GetGenes());
                currentSolution.ProblemID = PROBLEMID;

              //  initializeRows(ref currentSolution, ref c);

                FillBasic(ref currentSolution);

                double fit = currentSolution.Fitness; //STORE THE VALUE OF FITNESS
                sols.Dispose();
             

                return fit;
            };

            return f;
        }

        /// <summary>
        /// Configure the Genetic Algorithm
        /// </summary>
        public virtual void RunConfiguration()
        {
            //  Initialize(); //IMPORTANT

        
            // crossover = new CycleCrossover();
            IChromosome adam = CreateChromosome();

            IPopulation population = new Population(probabilities.minPop, probabilities.maxPop, adam);
            population.GenerationStrategy = new PerformanceGenerationStrategy();
            //population.GenerationStrategy = new TrackingGenerationStrategy();
            IFitness fitness = CreateFitness();
            GeneticAlgorithm ga;
            ga = new GeneticAlgorithm(population, fitness, config.Selection, config.Crossover, config.Mutation);
                      
            ga.Termination = config.Termination;
            if (config.Reinsertion!=null) ga.Reinsertion = config.Reinsertion;
            //   ga.Termination = new GenerationNumberTermination(probabilities.maxPop);
            ga.MutationProbability = probabilities.mutationProb;
            ga.CrossoverProbability = probabilities.crossProb;

            ga.TaskExecutor = new SmartThreadPoolTaskExecutor()
            {
                MinThreads = 10,
                MaxThreads = 70
            };


            GARow.Initialize(ref ga); //initialize
            GARow.ConfigTypes(ref config); // types ids
            GARow.ConfigTypesNames(ref ga); // types names, change with ids only
      

            GA = ga;
        }

        /// <summary>
        /// Does Post processing stuff after configuration
        /// Like stablishing the background worker
        /// </summary>
        public virtual void PostScript(bool bkgWorker)
        {
            //LIST OF NON REPEATED VALUES
            hashListOfGenotypes = new HashSet<string>();
            //NORMAL LIST TO ACCOMPANY, BECAUSE  A LIST IS INDEXED
            //AND A HASHSET IS NOT
            listOfSolutions = new List<GADataSet.SolutionsRow>();

            //listOfStrings = new List<GADataSet.StringsRow>();
            if (bkgWorker)
            {
                BackgroundWorker w = new BackgroundWorker();
                w.DoWork += workerDoWork;

                w.WorkerReportsProgress = true;
                w.ProgressChanged += workerProgressChanged;

                w.RunWorkerCompleted += workerRunWorkerCompleted;

                w.RunWorkerAsync();
            }
            else
            {
                GA.GenerationRan += delegate
                {
                    workerProgressChanged(null, null);
                };

                GA.Start();

                workerRunWorkerCompleted(null, null);
            }
        }

        public virtual void SetControllerFor(ref GADataSet.ProblemsRow p, int size)
        {
            if (p == null) throw new Exception("No Problem ID given");
            //DETERMINE CONDITIONS from PROBLEM ID
            conditions = p.GetConditionsRows();
            if (conditions == null)
            {
                throw new Exception("No Problem Conditions given");
            }

            problemData = p.GetKnapDataRows();

            if (problemData.Length == 0)
            {
                throw new Exception("No Problem Variables and Values given");
            }

            SIZE = size;

            PROBLEMID = p.ProblemID;

            variableNames = problemData.FirstOrDefault()
                .Table.Columns.OfType<DataColumn>()
                .Where(o => !o.ColumnName.Contains("ID"))
                .Select(o => o.ColumnName).ToArray();
        }
    }
}