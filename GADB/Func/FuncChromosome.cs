using GeneticSharp.Domain.Chromosomes;
using GeneticSharp.Domain.Randomizations;

namespace GADB
{
    public sealed class FuncChromo : ChromosomeBase
    {
        private int numberOfGenes;

        // private HashSet<int> nonRepeated;
        private int maxEQNumber = 0;

        /// <summary>
        ///
        /// </summary>
        /// <param name="sizeOfChromosome"></param>
        /// <param name="numOfGenes"></param>
        public FuncChromo(int numOfGenes, int numberEqs) : base(numOfGenes + 1)
        {
            // nonRepeated = new HashSet<int>();

            numberOfGenes = numOfGenes; // do I need the values? nope I think, only indexes

            maxEQNumber = numberEqs;

            for (int i = 0; i < numberOfGenes + 1; i++)
            {
                Gene g = GenerateGene(i);
                ReplaceGene(i, g);
            }
        }

        public override Gene GenerateGene(int geneIndex)
        {
            object o = 0;
            if (geneIndex == 0) o = RandomizationProvider.Current.GetInt(0, maxEQNumber);
            else o = RandomizationProvider.Current.GetDouble(-1, 1);

            return new Gene(o);
        }

        /// <summary>
        /// Creates a new chromosome using the same structure of this.
        /// </summary>
        /// <returns>The new chromosome.</returns>
        public override IChromosome CreateNew()
        {
            return new FuncChromo(this.numberOfGenes, this.maxEQNumber);
        }

        /// <summary>
        /// Creates a clone.
        /// </summary>
        /// <returns>The chromosome clone.</returns>
        public override IChromosome Clone()
        {
            FuncChromo c = base.Clone() as FuncChromo;
            c.numberOfGenes = this.numberOfGenes;
            c.maxEQNumber = this.maxEQNumber;
            return c;
        }
    }
}