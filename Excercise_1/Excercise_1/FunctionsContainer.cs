using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1{
    class FunctionsContainer {
        public delegate void intDelegate(int val);
        Dictionary<string, intDelegate> container = new Dictionary<String, intDelegate>();
        public intDelegate this[string idx]
        {
            get
            {
                return container[idx];
            }
            set
            {
                container[idx] = value;
            }
        }
    }
}
