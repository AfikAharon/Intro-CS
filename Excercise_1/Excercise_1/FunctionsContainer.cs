using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1{
    class FunctionsContainer {
        public delegate void doubleDelegate(int val);
        private Dictionary<string, doubleDelegate> container = new Dictionary<String, doubleDelegate>();
        public doubleDelegate this[string idx] {
            get {
                return container[idx];
            }
            set {
                container[idx] = value;
            }
        }
    }
}
