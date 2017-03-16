using System;
using System.Collections.Generic;
using System.Data;
using GeneticSharp.Domain;

namespace GADB
{
    /// <summary>
    /// the generic fiels, works great
    /// </summary>
    public abstract partial class ControllerBase : IController
    {
        public int SIZE = 6;

        public DataRow[] Conditions
        {
            get
            {
                return conditions;
            }

            set
            {
                conditions = value;
            }
        }

        public GADataSet.GARow GARow
        {
            get
            {
                return gARow;
            }

            set
            {
                gARow = value;
            }
        }

        public Action CallBack
        {
            get
            {
                return callBack;
            }

            set
            {
                callBack = value;
            }
        }

        public Action FinalCallBack
        {
            get
            {
                return finalCallBack;
            }

            set
            {
                finalCallBack = value;
            }
        }

        public Action SaveCallBack
        {
            get
            {
                return saveCallBack;
            }

            set
            {
                saveCallBack = value;
            }
        }

        private int PROBLEMID = 0; //important!!!

        /// <summary>
        /// Gets the Genetic Algorithm.
        /// </summary>
        /// <value>The Genetic Algorithm.</value>
        ///
        public GeneticAlgorithm GA { get; set; }

        public Probabilities Probabilities
        {
            get
            {
                return probabilities;
            }

            set
            {
                probabilities = value;
            }
        }
        Configuration config = null;
        public Configuration Config
        {
            get
            {
              
                return config;
            }

            set
            {
                config = value;
            }
        }
        public DataRow[] ProblemData
        {
            get
            {
                return problemData;
            }

            set
            {
                problemData = value;
            }
        }

        public string[] VariableNames
        {
            get
            {
                return variableNames;
            }

            set
            {
                variableNames = value;
            }
        }

        private DataRow[] problemData = null;
        private string[] variableNames;
        private Probabilities probabilities;
        private Action finalCallBack = null;
        private HashSet<string> hashListOfGenotypes = null;

        private List<GADataSet.SolutionsRow> listOfSolutions = null;
        private GADataSet.GARow gARow = null;
        private DataRow[] conditions = null;
        private Action callBack = null;
        private Action saveCallBack = null;
    }
}