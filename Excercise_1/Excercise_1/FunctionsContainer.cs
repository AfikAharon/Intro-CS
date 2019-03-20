using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1{
    class FunctionsContainer {
        public delegate double doubleDelegate(double val);
        private Dictionary<string, doubleDelegate> container 
                     = new Dictionary<String, doubleDelegate>();
        HashSet<string> functionsNames = new HashSet<string>();

        public doubleDelegate this[string idx] {
            get {
                if (container.ContainsKey(idx)) {
                    return container[idx];
                } else {
                    //If the container not contain the idx, insert Id function insted.
                    container[idx] = x => x;
                    // Add the key to a list, for getAllMissions().
                    functionsNames.Add(idx);
                    return container[idx];
                }
            }
            set {
                container[idx] = value;
                // Add the key to a list, for getAllMissions().
                functionsNames.Add(idx);
            }
        }

        // The function return the keys values.
        public HashSet<string> getAllMissions() {
            return functionsNames;
        }
    }
}
