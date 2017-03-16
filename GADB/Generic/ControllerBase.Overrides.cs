using GeneticSharp.Domain.Chromosomes;

namespace GADB
{
    /// <summary>
    /// METHODS TO OVERRIDE
    /// </summary>
    public abstract partial class ControllerBase : IController
    {
        /// <summary>
        /// Finds the fitness and Fine for the chromosome
        /// Function necessary during Fitness.Evaluation()
        /// Function necessary during PostScript printing
        /// Needs to be overriden
        /// </summary>
        /// <param name="r"></param>
        /// <param name="s"></param>
        /// <param name="c"></param>
        public abstract void FillBasic(ref GADataSet.SolutionsRow r);

        /// <summary>
        /// DECODES THE CHROMOSOME DATA CALCULATIONS INTO STRINGS OF TEXT
        /// Fills the Strings Table based on the variableNames
        /// Needs to be overriden
        /// </summary>
        /// <typeparam name="T">DataRow of StringsTable</typeparam>
        /// <param name="r">Solutions row</param>
        /// <param name="s">DataRow of stringsTable to fill, e.g. Strings</param>
        public abstract void FillStrings<T>(ref GADataSet.SolutionsRow r, ref T s);

        /// <summary>
        /// Creates Chromosome. Must be overriden
        /// </summary>
        /// <returns></returns>
        public abstract IChromosome CreateChromosome();
    }
}