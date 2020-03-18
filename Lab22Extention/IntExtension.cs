using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab22Extension {
    public static class IntExtension {
        public static bool IsPalindrome(this int value) {
            string num = value.ToString();
            int lenght = num.Length;

            for(int i = 0; i< lenght / 2; ++i)
                if (!num[i].Equals(num[lenght - i - 1]))
                    return false;

            return true;
        }
    }
}
