using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Singleton {
    class MySingleton {
        private MySingleton() {
        }

        public static MySingleton GetInstance() {
            return MySingletonHolder.INSTANCE;
        }

        private class MySingletonHolder {
            public static readonly MySingleton INSTANCE = new MySingleton();
        }
    }
}
