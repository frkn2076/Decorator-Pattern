using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Entity;

namespace DecoratorPattern {
    public class MilkDecorator : Decorator
    {
        public MilkDecorator(IBeverage beverage) : base(beverage)
        {
            description += " with Milk";
            cost += 2;
        }
    }

    public class SugarDecorator : Decorator
    {
        public SugarDecorator(IBeverage beverage) : base(beverage)
        {
            description += " with Sugar";
            cost += 1;
        }
    }
}
