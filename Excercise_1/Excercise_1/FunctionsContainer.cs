using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1{
    class FunctionsContainer {
        public delegate double doubleDelegate(double val);
        private Dictionary<string, doubleDelegate> container = new Dictionary<String, doubleDelegate>();
        HashSet<string> functionsNames = new HashSet<string>();

        public doubleDelegate this[string idx] {
            get {
                if (container.ContainsKey(idx)) {
                    return container[idx];
                } else {
                    container[idx] = x => x;
                    
                    functionsNames.Add(idx);
                    return container[idx];
                }
            }
            set {
                container[idx] = value;
                functionsNames.Add(idx);
            }
        }
        public HashSet<string> getAllMissions() {
            return functionsNames;
        }
    }
}
