using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4AbstractFactory.classes.product {
    class Toyota : AbstractCar {
        public Toyota() {
            maxSpeed = 250;
            currentSpeed = 100;
        }

        public override void MoveFaster() {
            int delta = 12;
            while (currentSpeed + delta < maxSpeed)
                Console.WriteLine("Toyota ускоряется: "+(currentSpeed += delta));
        }

        public override void MoveSlower() {
            int delta = 12;
            while (currentSpeed - delta > 0)
                Console.WriteLine("Toyota замедляется: "+(currentSpeed -= delta));
        }
    }
}