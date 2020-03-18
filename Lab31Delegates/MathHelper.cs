using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab31Delegates {
    public static class MathHelper {
        public delegate double Operation(double value);

        public static double Increment(double value) {
            return value + 1;
        }

        public static double Decrement(double value) {
            return value + 1;
        }

        public static double Pow(double value) {
            return value * value;
        }

        public static double Double(double value) {
            return value * 2;
        }

        public static Operation[] GetRandOperations() {
            Random random = new Random();
            Operation[] operations = new Operation[10];
            for (int i = 0; i < operations.Length; i++)
                operations[i] = GetRandOperation(random);
            return operations;
        }

        private static Operation GetRandOperation(Random random) {
            switch (random.Next(4)) {
                case 0:
                    return Increment;
                case 1:
                    return Decrement;
                case 2:
                    return Pow;
                case 3:
                    return Double;
                default:
                    return null;
            }
        }

        public static Operation[] GetFirstOperationsInstance() {
            Operation[] operations = new Operation[10];
            operations[0] = Increment;
            return operations;
        }
    }
}
