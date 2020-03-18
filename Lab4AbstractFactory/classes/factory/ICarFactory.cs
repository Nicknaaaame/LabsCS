using Lab4AbstractFactory.classes.product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4AbstractFactory.classes {
    interface ICarFactory {
        AbstractCar CreateCar();
    }
}
