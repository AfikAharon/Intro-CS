﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1 {
    class ComposedMission : IMission {
        private string name;
        private string type;
        private List<FunctionsContainer.doubleDelegate> functions 
                  = new List<FunctionsContainer.doubleDelegate>();

        public ComposedMission(string name) {
            this.name = name;
            this.type = "Composed";
        }

        public string Name => name;

        public string Type => type;

        public event EventHandler<double> OnCalculate;

        public double Calculate(double value) {
            double result = value;
            // The loop activates the functions.
            foreach (var func in functions) {
                result = func(result);
            }
            // invoke the OnCalculate EventHandler
            if (OnCalculate != null)
                OnCalculate.Invoke(this, result);
            return result;
        }
        /*
         * Add a mission function.
         */
        public ComposedMission Add(FunctionsContainer.doubleDelegate func) {
            functions.Add(func);
            return this;
        }
    }
}
