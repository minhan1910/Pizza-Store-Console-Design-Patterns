using MinPizzaN.models.ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinPizzaN.models.Pizzas
{
    public abstract class Pizza
    {
        protected string _name;
        protected IDough _dough;
        protected ISauce _sauce;
        protected List<IVeggies> _veggies;
        protected ICheese _cheese;
        protected IPepperoni _pepperoni;
        protected IClams _clam;

        public abstract void Prepare();

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 450");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public abstract string Name { get; }

        public virtual double Cost
        {
            get
            {
                return _dough.Cost + _cheese.Cost + _clam.Cost +
                       _pepperoni.Cost + _sauce.Cost + _veggies.AsEnumerable()
                                                                .Sum(v => v.Cost);
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
