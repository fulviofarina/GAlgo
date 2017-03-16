using System;
using System.Data;
using GeneticSharp.Domain.Chromosomes;

namespace GADB
{
    public partial class KnapController : ControllerBase
    {
        public override void FillStrings<T>(ref GADataSet.SolutionsRow r, ref T s)
        {
            for (int i = 0; i < VariableNames.Length; i++)
            {
                string dummy = Aid.DecodeStrings(r.GenesAsInts, ProblemData, VariableNames[i]);
                string field = VariableNames[i] + "String";
                DataRow row = s as DataRow;
                row.SetField(field, dummy); //first
            }
        }

        /// <summary>
        /// Finds the fine for the given solution row, based on the conditions MAX, MIN and FINE TARIF
        /// </summary>
        /// <param name="r"></param>
        /// <param name="conditions"></param>
        /// <param name="variableNames">array of variableNames of problem (columns of KnapData)</param>
        private object[] findFines(ref DataRow r)
        {
            double fine = 0;
            string actualStr = string.Empty;

            for (int j = 0; j < Conditions.Length; j++)
            {
                //find if all parameters are ok
                bool[] varOk = new bool[VariableNames.Length];
                bool ANDS_OK = true;
                for (int i = 0; i < VariableNames.Length; i++)
                {
                    varOk[i] = false;
                    string totalVarStr = VariableNames[i];
                    string maxVarStr = "Max" + VariableNames[i];
                    string minVarStr = "Min" + VariableNames[i];
                    //is the variable within the window given by the condition?
                    double a = r.Field<double>(totalVarStr);
                    double b = Conditions[j].Field<double>(maxVarStr);
                    varOk[i] = (a <= b);
                    a = r.Field<double>(totalVarStr);
                    b = Conditions[j].Field<double>(minVarStr);
                    varOk[i] = varOk[i] && (a >= b);

                    ANDS_OK = ANDS_OK && varOk[i];
                }

                //FIRST LETER T OR F

                //  actualStr = r.Field<string>("Okays");
                for (int i = 0; i < VariableNames.Length; i++)
                {
                    actualStr += varOk[i].ToString()[0] + " ";
                }
                // r.SetField("Okays", actualStr);
                //NOW ASSIGN THE PENALTY / FINE

                if (ANDS_OK)
                {
                    fine += 0; //not to be fined
                }
                else
                {
                    for (int i = 0; i < VariableNames.Length; i++)
                    {
                        if (!varOk[i])
                        {
                            //auxiliars
                            //  string str =  VariableNames[i]; //dataRow.A B or C
                            string maxCondstr = "Max" + VariableNames[i]; //on condition row
                            string fineCondstr = VariableNames[i] + "Fine";

                            //difference value less MAX_VALUE
                            double auxiliarDifference = r.Field<double>(VariableNames[i]) - Conditions[j].Field<double>(maxCondstr);
                            //take TARIF
                            double tariff = Conditions[j].Field<double>(fineCondstr);

                            //FINE i-esim = difference * tariff
                            fine += (auxiliarDifference) * tariff; //excess weight
                        }
                    }
                }
            }

            return new object[] { actualStr, fine };
        }

        /// <summary>
        /// BASIC CALCULATION NECESSARY FOR FITNESS
        /// </summary>
        /// <param name="r"></param>
        /// <param name="c"></param>
        public override void FillBasic(ref GADataSet.SolutionsRow r)
        {
            GADataSet.DataRow d = r.DataAxuliar.NewDataRow();
            r.DataAxuliar.AddDataRow(d);
            //auxiliar data row
            for (int i = 0; i < VariableNames.Length; i++)
            {
                //Field A, B or C
                double dummy = Aid.SetBasic(r.GenesAsInts, ProblemData, VariableNames[i]);
                d.SetField(VariableNames[i], dummy); //first
                                                     //save total in a dataauxiliar Row
            }

            DataRow row = d;

            object[] results = findFines(ref row);
            r.Okays = results[0] as string;
            double fine = Convert.ToDouble(results[1]);
            r.Okays += " " + Decimal.Round(Convert.ToDecimal(fine), 3);
            r.Fitness = d.C;
            r.Fitness /= (1 + fine); //max vol, max value * (1+fine)

            r.Genotype = Aid.SetStrings(r.GenesAsInts);
        }

        /// <summary>
        /// POST CALCULATION TO DECODE
        /// </summary>
        /// <param name="r"></param>

        // //// / / / / / //////// //////////////////////////// AQUI TEMPLATE
        /// <summary>
        /// INITIALIZER
        /// </summary>
        /// <param name="dt"></param>
        public KnapController() : base()
        {
        }

        /// <summary>
        /// NATURAL FUNCTION, COMPULSORY
        /// </summary>
        /// <returns></returns>
        public override IChromosome CreateChromosome()
        {
            KnapChromosome c = new KnapChromosome(SIZE, ProblemData.Length);
            return c;
        }
    }
}