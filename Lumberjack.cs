using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _8_Lumberjacks_Eat_Flapjacks
{
    public enum Flapjack
    {
        crispy,
        soggy,
        browned,
        banana
    }
    class Lumberjack
    {
        private string name;
        public string Name { get { return name; } }
        private Stack<Flapjack> meal;
        public Lumberjack(string name)
        {
            this.name = name;
            meal = new Stack<Flapjack>();
        }
        public int FlapjackCount { get { return meal.Count; } }
        public void TakeFlapjacks(Flapjack Food, int HowMany)
        {
            for (int i = 0; i < HowMany; i++)
            {
                this.meal.Push(Food);
            }
        }

        public void EatFlapjacks()
        {
            Console.WriteLine($"{this.name} 's eating flapjacks");
            while (this.meal.Count > 0)
            {
                Flapjack currentFlapjack = this.meal.Pop();
                Console.WriteLine($"{this.name} ate a {currentFlapjack}");
            }
        }
    }
}

