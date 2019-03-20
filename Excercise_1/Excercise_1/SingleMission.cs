using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1 {
    class SingleMission : IMission {
        private string name;
        private string type;
        FunctionsContainer.doubleDelegate function;

        public SingleMission(FunctionsContainer.doubleDelegate func, string name) {
            this.name = name;
            this.function = func;
            this.type = "Single";
        }

        public string Name => name;

        public string Type => type;

        public event EventHandler<double> OnCalculate;

        public double Calculate(double value) {
            double result = function(value);
            if (OnCalculate != null)
                OnCalculate.Invoke(this, result);
            return result;
        }
    }
}
