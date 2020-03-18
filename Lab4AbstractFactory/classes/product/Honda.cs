using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4AbstractFactory.classes.product {
    class Honda : AbstractCar {
        public Honda() {
            maxSpeed = 200;
            currentSpeed = 100;
        }

        public override void MoveFaster() {
            while (currentSpeed < maxSpeed)
                Console.WriteLine("Honda ускоряется: " + (currentSpeed += 10));
        }

        public override void MoveSlower() {
            while (currentSpeed > 0)
                Console.WriteLine("Honda замедляется: " + (currentSpeed -= 10));
        }
    }
}
