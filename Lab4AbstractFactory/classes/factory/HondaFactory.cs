using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab4AbstractFactory.classes.product;

namespace Lab4AbstractFactory.classes.factory {
    class HondaFactory : ICarFactory {
        public AbstractCar CreateCar() {
            return new Honda();
        }
    }
}
