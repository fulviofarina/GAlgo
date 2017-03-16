using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using GeneticSharp.Domain;
using GeneticSharp.Domain.Chromosomes;

namespace GADB
{
    /// <summary>
    /// The generic engine, works great
    /// </summary>
    public abstract partial class ControllerBase : IController
    {
        private void fillStrings()
        {
            GADataSet ds = GARow.Table.DataSet as GADataSet;

            for (int i = 0; i < listOfSolutions.Count; i++)
            {
                GADataSet.SolutionsRow currentSolution = listOfSolutions.ElementAt(i);

                GADataSet.StringsRow currentString;
                currentString = ds.Strings.NewStringsRow();
                currentString.Initialize();
                ds.Strings.AddStringsRow(currentString);

                currentString.GAID = currentSolution.GAID;
                currentString.ProblemID = currentSolution.ProblemID;
                currentString.SolutionID = currentSolution.ID;

                currentSolution.Counter = 1;

                //decode
                FillStrings(ref currentSolution, ref currentString);

              //  GNUPLOT(ref currentSolution);
                //assign string ID... //this should be better
            }
        }

        /// <summary>
        /// Main postcript function to store best results
        /// </summary>
        private void workerProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                IChromosome bestChromosome = GA.Population.BestChromosome;

                //BASIC
                GADataSet ds = GARow.Table.DataSet as GADataSet;
                GADataSet.SolutionsRow currentSolution;
                currentSolution = ds.Solutions.NewSolutionsRow();

                currentSolution.Initialize(bestChromosome.GetGenes());
                currentSolution.ProblemID = PROBLEMID;

             
                //this is the most important function to override, does the fitness calc
                FillBasic(ref currentSolution);

                GeneticAlgorithm ga = GA;
                //fill GA data to row
                GARow.Update(ref ga); //report GA stuff

                //define filter function by genotype
                Func<GADataSet.SolutionsRow, bool> funcion;
                funcion = Aid.FilterByGenotype(ref hashListOfGenotypes, ref listOfSolutions);
                //execute filter function by genotype
                funcion(currentSolution);
                //the listOfSolutions contains the list of rows that need to be added
                //these rows are flagged ShouldDelete = false
                if (!currentSolution.ShouldDelete)
                {
                    ds.Solutions.AddSolutionsRow(currentSolution);
                    GARow.FillGADataToSolution(ref currentSolution);
                }

                //callBack MEthod to Form or User Control

                CallBack.Invoke();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void workerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SaveCallBack();

            fillStrings();

            FinalCallBack.Invoke();
        }

        /// <summary>
        /// Generic Do Work for the background worker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void workerDoWork(object sender, DoWorkEventArgs e)
        {
            GA.GenerationRan += delegate
            {
                BackgroundWorker w = sender as BackgroundWorker;
                w.ReportProgress(0); //should I put a percentage?
            };

            GA.Start();
        }

        /// <summary>
        /// Generic RunWorker Completed for the background worker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

   
   

        private static void GNUPLOT(ref GADataSet.SolutionsRow s)
        {
            string script = "set grid\n";
            script += "set title 'Trajectories'\n";
            script += "set xlabel 'X'\n";
            script += "set ylabel 'Y'\n";

            GADataSet.DataRow[] data = s.ProblemsRow.GetKnapDataRows();
            double min = data.Min(o => o.A);
            double max = data.Max(o => o.A);

            script += "set xrange[" + (min - 1) + ":" + (max + 1) + "]\n";
            min = data.Min(o => o.B);
            max = data.Max(o => o.B);
            script += "set yrange[" + (min - 1) + ":" + (max + 1) + "]\n";

            script += "set terminal gif animate delay 100\n";
            script += "set output FILENAME\n";

            //get genotype string
            string[] a = s.Genotype.Split(' ');

            //clean nulls
            a = a.Where(o => !string.IsNullOrEmpty(o)).ToArray();

            //make a data .txt file with A,B,C points
            for (int i = 0; i < a.Length; i++)
            {
                // if (string.IsNullOrEmpty(a[i])) continue;
                string aa = data.ElementAt(Convert.ToInt32(a[i]) - 1).A + "\t";
                aa += data.ElementAt(Convert.ToInt32(a[i]) - 1).B + "\t";
                aa += data.ElementAt(Convert.ToInt32(a[i]) - 1).C;
                // string fileindex = i;
                script += "plot '" + i + ".txt' using 1:2:3 with points palette pointsize 2 pointtype 5\n";
                System.IO.File.WriteAllText(i + ".txt", aa);
            }

            //make gnuplot script file
            string scriptFile = Guid.NewGuid().ToString().Substring(0, 6);
            System.IO.File.WriteAllText(scriptFile + ".gp", script);

            //execute gnuplot
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "gnuplot";
            p.StartInfo.Arguments = "-e \"FILENAME='" + scriptFile + ".gif'\" " + scriptFile + ".gp";
            p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            p.Start();
            p.WaitForExit();

            //add image to Chromosome
            s.Chromosome = System.IO.File.ReadAllBytes(scriptFile + ".gif");
        }
    }
}