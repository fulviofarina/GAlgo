using GeneticSharp.Domain.Chromosomes;
using GeneticSharp.Domain.Randomizations;

namespace GADB
{
    public sealed class KnapChromosome : ChromosomeBase
    {
        private int numberOfGenes;

        /// <summary>
        ///
        /// </summary>
        /// <param name="sizeOfChromosome"></param>
        /// <param name="numOfGenes"></param>
        public KnapChromosome(int sizeOfChromosome, int numOfGenes) : base(sizeOfChromosome)
        {
            numberOfGenes = numOfGenes; // do I need the values? nope I think, only indexes

            for (int i = 0; i < sizeOfChromosome; i++)
            {
                ReplaceGene(i, GenerateGene(i));
            }
        }

        /// <summary>
        /// THIS WORKS THE BEST, HIGH PROB OF JUNK GENE
        /// </summary>
        /// <param name="geneIndex"></param>
        /// <returns></returns>
        public override Gene GenerateGene(int geneIndex)
        {
            int randIndex = 0;
            int initial = 0;

            randIndex = RandomizationProvider.Current.GetInt(initial, numberOfGenes * 10);

            if (randIndex > numberOfGenes || randIndex == 0) randIndex = -1;

            return new Gene(randIndex);
        }

        /// <summary>
        /// OPTION B
        /// </summary>
        /// <param name="geneIndex"></param>
        /// <returns></returns>
        public Gene GenerateGeneB(int geneIndex)
        {
            int randIndex = 0;
            int initial = 0;

            randIndex = RandomizationProvider.Current.GetInt(initial, numberOfGenes);

            if (randIndex == 0) randIndex = -1;

            return new Gene(randIndex);
        }

        /// <summary>
        /// OPTION A
        /// </summary>
        /// <param name="geneIndex"></param>
        /// <returns></returns>
        public Gene GenerateGeneA(int geneIndex)
        {
            int randIndex = 0;
            int initial = 0;

            //makes 1 gene with a random index from 0 to m_values as MAX
            initial = 1;

            randIndex = RandomizationProvider.Current.GetInt(initial, numberOfGenes);

            if (randIndex > numberOfGenes) randIndex = -1;

            return new Gene(randIndex);
        }

        /// <summary>
        /// Creates a new chromosome using the same structure of this.
        /// </summary>
        /// <returns>The new chromosome.</returns>
        public override IChromosome CreateNew()
        {
            return new KnapChromosome(this.Length, numberOfGenes);
        }

        /// <summary>
        /// Creates a clone.
        /// </summary>
        /// <returns>The chromosome clone.</returns>
        public override IChromosome Clone()
        {
            return base.Clone();
        }
    }
}