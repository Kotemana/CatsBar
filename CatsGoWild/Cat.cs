using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatsGoWild
{
   public class Cat
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public double Health { get; set; }

        public void Drink(Drink drink)
        {
            Health -= drink.AlcoholVolumePrc * drink.VolumeMl / 100;
            Console.WriteLine($"{Name}, the {Color} cat drinks {drink.VolumeMl} ml of {drink.Name} ({drink.AlcoholVolumePrc}%). Now it is {Health} health.");

        }
        
        public void Report()
        {
            Console.WriteLine($"{Name} ({Color}) - {Health}");
        }
    }

}
