using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GADB
{
    public static class Aid
    {
        public static decimal DecimalTxt(double varPower)
        {
            decimal deci1 = Decimal.Round(Convert.ToDecimal(varPower), 1);

            return deci1;
        }

        /// <summary>
        /// FUNCTION TO PERFORM AVERAGE AND HISTOGRAM
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="problema"></param>
        public static void DoStatistics<T>(T problema)
        {
            GADataSet.ProblemsRow currentProblem = problema as GADataSet.ProblemsRow;

            IEnumerable<GADataSet.GARow> gasrows = currentProblem.GetGARows();

            int min = gasrows.Min(o => o.ChromosomeLength);
            int max = gasrows.Max(o => o.ChromosomeLength);

            HashSet<string> hash;
            List<GADataSet.SolutionsRow> list;
            //    List<GADataSet.StringsRow> strs;
            hash = new HashSet<string>();
            list = new List<GADataSet.SolutionsRow>();
            //    strs = new List<GADataSet.StringsRow>();

            //create lamda expression to filter
            Func<GADataSet.SolutionsRow, bool> funcion;
            funcion = FilterByGenotype(ref hash, ref list);

            //iterate min max chromosome lenght for all genetic algorithms
            for (int j = min; j <= max; j++)
            {
                gasrows = currentProblem.GetGARows();

                IEnumerable<GADataSet.GARow> subs = gasrows
                    .Where(o => o.ChromosomeLength == j)
                    .ToList();

                GADataSet.GARow subFirst = subs.FirstOrDefault();
                subFirst.AverageGA(ref subs);

                //select GARow childrens
                IEnumerable<GADataSet.SolutionsRow> knaprows = subs
                    .SelectMany(o => o.GetSolutionsRows()).ToList();

                hash.Clear(); //clear
                list.Clear();//clear

                foreach (GADataSet.SolutionsRow item in knaprows)
                {
                    funcion(item);
                }

                double bestFitness = list.Max(o => o.Fitness);
                subFirst.Fitness = bestFitness;

                int count = knaprows.Count();

                for (int d = knaprows.Count() - 1; d >= 0; d--)
                {
                    GADataSet.SolutionsRow s = knaprows.ElementAt(d);
                    if (s.ShouldDelete)
                    {
                        if (s.StringsRowParent != null) s.StringsRowParent.Delete();
                        s.Delete();
                    }
                    else
                    {
                        s.GAID = subFirst.ID;
                        s.Generations /= s.Counter;
                        s.TimeSpan /= s.Counter;
                    }
                }

                count = subs.Count();
                for (int d = subs.Count() - 1; d >= 1; d--)
                {
                    subs.ElementAt(d).Delete();
                }
            }
        }

        public static Func<GADataSet.SolutionsRow, bool> FilterByGenotype(ref HashSet<string> hs, ref List<GADataSet.SolutionsRow> l)
        {
            Func<GADataSet.SolutionsRow, bool> funcion;

            HashSet<string> genotypesNonRepeated = hs;
            List<GADataSet.SolutionsRow> solutions = l;

            funcion = (o) =>
            {
                string genotype = o.Genotype;
                if (genotypesNonRepeated.Add(genotype)) //add to hashShet
                {
                    solutions.Add(o);//add to indexed list
                                     //   strings.Add(s);
                    return true;
                }
                else
                {
                    int i = solutions.FindIndex(r => r.Genotype.Equals(genotype));

                    double ts = solutions[i].TimeSpan;
                    int gen = solutions[i].Generations;
                    //  int cnt = solutions[i].Counter;

                    ts += o.TimeSpan;

                    gen += o.Generations;

                    //  cnt++;
                    solutions[i].Counter++;

                    solutions[i].Frequency += o.Frequency;
                    solutions[i].TimeSpan = ts;
                    solutions[i].Generations = gen;

                    o.ShouldDelete = true;
                    return false;
                }
            };

            return funcion;
        }

        public static double SetBasic(IList<int> Genes, DataRow[] values, string field)
        {
            double TotalValue = 0;

            for (int i = 0; i < Genes.Count; i++)
            {
                int index = Genes.ElementAt(i);
                if (index != -1)
                {
                    TotalValue += values[index - 1].Field<double>(field);
                }
            }

            return TotalValue;
        }

        /// <summary>
        /// USED BY DRONE CONTROLLER
        /// </summary>
        /// <param name="conditions"></param>
        /// <param name="Genes"></param>
        /// <param name="indexAt"></param>
        /// <param name="values"></param>
        /// <param name="field"></param>
        /// <returns></returns>
        public static double SetDifferences(DataRow conditions, IList<int> Genes, int indexAt, DataRow[] values, string field)
        {
            double difference = 0;

            //geneValue is index of Item in Table
            int geneValue = Genes.ElementAt(indexAt); //get first item

            //first item
            if (indexAt == 0)
            {
                //use value from MIN condition on A, B or C as start point
                double xo = conditions.Field<double>("Min" + field);
                difference = values[geneValue - 1].Field<double>(field) - xo;
            }
            //last item
            else if (indexAt == Genes.Count - 1)
            {
                //use value from MAX condition on A, B or C as end-point
                double xf = conditions.Field<double>("Max" + field);
                geneValue = Genes.ElementAt(indexAt - 1); //get first item
                difference = values[geneValue - 1].Field<double>(field) - xf;
            }
            else
            {
                // when comparing items in the middle...
                int nextGeneValue = Genes.ElementAt(indexAt - 1); //get second item

                //if not junk...
                if (geneValue != -1 && nextGeneValue != -1)
                {
                    difference = values[geneValue - 1].Field<double>(field); //value at index
                    difference -= values[nextGeneValue - 1].Field<double>(field); //value at next
                }
            }

            //    }

            return difference;
        }

        public static string SetStrings(IList<int> Genes)
        {
            // (IList<double> m_values, IList<double> m_weights, IList<double> m_volumes)
            //  IList<Gene> genes = Genes;

            string text = string.Empty;
            for (int i = 0; i < Genes.Count; i++)
            {
                int index = Genes.ElementAt(i);
                //  int index = int.Parse(g.Value.ToString());
                //si está presente, entonces sumo el valor y el peso al contenedor
                if (index != -1)
                {
                    text += (index).ToString();
                }
                else
                {
                    text += "*";
                }
                text += "  ";
            }

            return text;
        }

        public static string SetStrings(IList<double> Genes, int rounding)
        {
            string text = string.Empty;
            for (int i = 0; i < Genes.Count; i++)
            {
                double value = Genes.ElementAt(i);
                text += (Decimal.Round(Convert.ToDecimal(value), rounding)).ToString();
                text += "  ";
            }

            return text;
        }

        public static string DecodeStrings(IList<int> Genes, DataRow[] values, string field)
        {
            string text = string.Empty;

            string ask = "*";
            string space = "  ";

            for (int i = 0; i < Genes.Count; i++)
            {
                int index = Genes[i];
                //si está presente, entonces sumo el valor y el peso al contenedor
                if (index != -1)
                {
                    text += values[index - 1].Field<double>(field).ToString();
                }
                else
                {
                    text += ask;
                }
                text += space;
            }

            return text;
        }
    }
}