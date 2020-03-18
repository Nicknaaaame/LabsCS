using Lab4AbstractFactory.classes.product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4AbstractFactory.classes {
    class Car {
        private AbstractCar car;

        public Car(ICarFactory carFactory) {
            this.car = carFactory.CreateCar();
        }

        public void Faster() {
            car.MoveFaster();
        }

        public void Slower() {
            car.MoveSlower();
        }
    }
}
