using GeneticSharp.Domain.Chromosomes;
using GeneticSharp.Domain.Randomizations;

namespace GADB
{
    public sealed class DroneChromosome : ChromosomeBase
    {
        private int numberOfGenes;

        // private HashSet<int> nonRepeated;
        private int maxEmpty = 0;

        /// <summary>
        ///
        /// </summary>
        /// <param name="sizeOfChromosome"></param>
        /// <param name="numOfGenes"></param>
        public DroneChromosome(int sizeOfChromosome, int numOfGenes, int maxJunk) : base(sizeOfChromosome)
        {
            // nonRepeated = new HashSet<int>();

            numberOfGenes = numOfGenes; // do I need the values? nope I think, only indexes

            maxEmpty = maxJunk;
            var citiesIndexes = RandomizationProvider.Current.GetUniqueInts(numberOfGenes, 1, numberOfGenes + 1);

            for (int i = 0; i < numberOfGenes; i++)
            {
                int valor = citiesIndexes[i];
                //   if (valor > numberOfGenes) valor = -1;
                Gene g = new Gene(valor);
                ReplaceGene(i, g);
            }
        }

        public override Gene GenerateGene(int geneIndex)
        {
            int valor = RandomizationProvider.Current.GetInt(1, numberOfGenes + 1);
            //   if (valor > numberOfGenes) valor = -1;
            return new Gene(valor);
        }


        /// <summary>
        /// Creates a new chromosome using the same structure of this.
        /// </summary>
        /// <returns>The new chromosome.</returns>
        public override IChromosome CreateNew()
        {
            return new DroneChromosome(this.Length, this.numberOfGenes, this.maxEmpty);
        }

        /// <summary>
        /// Creates a clone.
        /// </summary>
        /// <returns>The chromosome clone.</returns>
        public override IChromosome Clone()
        {
             DroneChromosome c = base.Clone() as DroneChromosome;
            c.numberOfGenes = this.numberOfGenes;
            c.maxEmpty = this.maxEmpty;
            return c;
        }
    }
}