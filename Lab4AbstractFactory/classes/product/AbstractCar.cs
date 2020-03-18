using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4AbstractFactory.classes.product {
    abstract class AbstractCar {
        protected int maxSpeed, currentSpeed;
        public abstract void MoveFaster();
        public abstract void MoveSlower();
    }
}
