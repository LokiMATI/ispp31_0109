using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lection0312
{
    public class BasePizza : IPizza
    {
        public int GetCost() => 100;

        public string GetDescription() => "основа";
    }

    public abstract class PizzaIngredient : IPizza
    {
        protected readonly IPizza _pizza;

        protected PizzaIngredient(IPizza pizza)
        {
            _pizza = pizza;
        }

        public abstract int GetCost();

        public abstract string GetDescription();
    }

    public class Tomato : PizzaIngredient
    {
        public Tomato(IPizza pizza) : base(pizza) {}

        public override int GetCost() => _pizza.GetCost() + 50;

        public override string GetDescription() => $"{_pizza.GetDescription()} томаты";
    }

    public class Pepperoni : PizzaIngredient
    {
        public Pepperoni(IPizza pizza) : base(pizza) { }

        public override int GetCost() => _pizza.GetCost() + 200;

        public override string GetDescription() => $"{_pizza.GetDescription()} пепперони";
    }

    public class Cheese : PizzaIngredient
    {
        public Cheese(IPizza pizza) : base(pizza) { }

        public override int GetCost() => _pizza.GetCost() + 150;

        public override string GetDescription() => $"{_pizza.GetDescription()} csh";
    }
}