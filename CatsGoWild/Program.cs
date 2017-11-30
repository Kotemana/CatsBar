using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatsGoWild
{
    class Program
    {
        static void Main(string[] args)
        {
            var namesList = new List<string>();
            namesList.Add("Tom");
            namesList.Add("Joe");
            namesList.Add("Dexter");
            namesList.Add("Topa");
            namesList.Add("Bublic-Genadich");
            var colorList = new List<string>();
            colorList.Add("Black");
            colorList.Add("Red");
            colorList.Add("Green");
            colorList.Add("White");
            colorList.Add("Orange");
            var softDrinksList = new List<string>();
            softDrinksList.Add("Beer");
            softDrinksList.Add("Honeymoon");
            softDrinksList.Add("Ale");
            var mediumDrinksList = new List<string>();
            mediumDrinksList.Add("Vino");
            mediumDrinksList.Add("Martinka");
            mediumDrinksList.Add("Shampoosik");
            var strongDrinksList = new List<string>();
            strongDrinksList.Add("Vodka");
            strongDrinksList.Add("Samogon");
            strongDrinksList.Add("ROM");
            var bar = new Bar();
            bar.Name = "Domik";
            bar.LightDrinks = new List<Drink>();
            bar.MediumDrinks = new List<Drink>();
            bar.StrongDrinks = new List<Drink>();
            var rnd = new Random();
            for (int i = 0; i < 3; i++) 
            {
                var lightDrink = new Drink();
                lightDrink.Name = softDrinksList[i];
                lightDrink.VolumeMl = rnd.Next(3, 10)*100;
                lightDrink.AlcoholVolumePrc = rnd.Next(30, 69) / 10;
                bar.LightDrinks.Add(lightDrink);
                var mediumDrink = new Drink();
                mediumDrink.Name = mediumDrinksList[i];
                mediumDrink.VolumeMl = rnd.Next(4, 12) * 25;
                mediumDrink.AlcoholVolumePrc = rnd.Next(90, 200)*0.1;
                bar.MediumDrinks.Add(mediumDrink);
                var strongDrink = new Drink();
                strongDrink.Name = strongDrinksList[i];
                strongDrink.VolumeMl = rnd.Next(4, 12) * 10;
                strongDrink.AlcoholVolumePrc = rnd.Next(35, 55);
                bar.StrongDrinks.Add(strongDrink);
                
            }
            var catList = new List<Cat>();
            for (int i = 0; i < 5; i++)
            {
                var cat = new Cat();
                cat.Health = rnd.Next(35, 150);
                cat.Name = namesList[rnd.Next(namesList.Count)];
                cat.Color = colorList[rnd.Next(colorList.Count)];
                catList.Add(cat);
            }
            foreach (var cat in catList) 
            {
                cat.Drink(bar.LightDrinks[rnd.Next(bar.LightDrinks.Count)]);
                cat.Drink(bar.MediumDrinks[rnd.Next(bar.MediumDrinks.Count)]);
                cat.Drink(bar.StrongDrinks[rnd.Next(bar.StrongDrinks.Count)]);
            }
            Console.WriteLine("Cats who are alive");
            foreach (var cat in catList)
            {
                if (cat.Health > 0)
                {
                    cat.Report();
                }

            }
            Console.WriteLine("Dead List");
            foreach (var cat in catList)
            {
                if (cat.Health <= 0)
                {
                    cat.Report();
                }
            }
            Console.ReadLine();
        }
    }
}
