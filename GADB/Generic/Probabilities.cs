using GeneticSharp.Domain.Crossovers;
using GeneticSharp.Domain.Mutations;
using GeneticSharp.Domain.Reinsertions;
using GeneticSharp.Domain.Selections;
using GeneticSharp.Domain.Terminations;

namespace GADB
{

    public class Configuration
    {

        public ISelection Selection;
        public ICrossover Crossover;
        public IMutation Mutation;
        public ITermination Termination;
        public IReinsertion Reinsertion;


        public int SelectionID;
        public int CrossoverID;
        public int MutationID;
        public int TerminationID;
        public int ReinsertionID;
        public  Configuration(int selectionType, int crossType, int mutaType, int reinsertionType, int terminationType)
        {
            //  Initialize(); //IMPORTANT

            SelectionID = selectionType;
            Selection = new TournamentSelection();
            if (selectionType == 1) Selection = new EliteSelection();
            else if (selectionType == 2) Selection = new RouletteWheelSelection();
            else if (selectionType == 3) Selection = new StochasticUniversalSamplingSelection();
            else if (selectionType == 4) Selection = new TournamentSelection(); //check options

            CrossoverID = crossType;
            Crossover = new UniformCrossover(0.5f);
            if (crossType == 1) Crossover = new CutAndSpliceCrossover();
            else if (crossType == 2) Crossover = new CycleCrossover();
            else if (crossType == 3) Crossover = new OnePointCrossover(); //options swapPoint
            else if (crossType == 4) Crossover = new OrderBasedCrossover();
            else if (crossType == 5) Crossover = new OrderedCrossover();
            else if (crossType == 6) Crossover = new PartiallyMappedCrossover();
            else if (crossType == 7) Crossover = new ThreeParentCrossover();
            else if (crossType == 8) Crossover = new TwoPointCrossover(); //options SwapPoint
            else if (crossType == 9) Crossover = new UniformCrossover(0.5f); //mix probability is 5

            MutationID = mutaType;
             Mutation = new UniformMutation(true);
            if (mutaType == 1) Mutation = new ReverseSequenceMutation();
            else if (mutaType == 2) Mutation = new TworsMutation();
            else if (mutaType == 3) Mutation = new UniformMutation(true); //options

            ReinsertionID = reinsertionType;
            Reinsertion = null;
            if (reinsertionType == 1) Reinsertion = new ElitistReinsertion();
            else if (reinsertionType == 2) Reinsertion = new FitnessBasedReinsertion();
            else if (reinsertionType == 3) Reinsertion = new PureReinsertion();
            else if (reinsertionType == 4) Reinsertion = new UniformReinsertion();
            else if (reinsertionType == 5) Reinsertion = null;


            TerminationID = terminationType;

            Termination = new TimeEvolvingTermination();
            if (terminationType == 1) Termination = new GenerationNumberTermination();
            else if (terminationType == 2) Termination = new TimeEvolvingTermination(new System.TimeSpan(0, 3, 0));
            else if (terminationType == 3) Termination = new FitnessStagnationTermination(200); //options
            else if (terminationType == 4) Termination = new FitnessThresholdTermination();// expected fitness
            else if (terminationType == 5) Termination = new AndTermination();
            else if (terminationType == 6) Termination = new OrTermination();

            
        }
    }
    /// <summary>
    /// AUXILIAR CLASS TO STORE TEMPORARILY THE PREFERENCES
    /// </summary>
    public class Probabilities
    {
        public Probabilities(int MinPop, int MaxPop, float MutationProb, float CrossProb)
        {
            mutationProb = MutationProb;
            crossProb = CrossProb;
            minPop = MinPop;
            maxPop = MaxPop;
        }

        public float mutationProb, crossProb;
        public int minPop, maxPop;
    }
}