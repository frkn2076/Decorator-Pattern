using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Entity {
    public interface IBeverage
    {
        string GetDescription();
        int GetCost();
    }

    public class Espresso : IBeverage
    {
        public string GetDescription() {
            return "Decaf";
        }

        public int GetCost() {
            return 7;
        }
    }

    public class Decaf : IBeverage
    {
        public string GetDescription()
        {
            return "Espresso";
        }

        public int GetCost()
        {
            return 5;
        }
    }
}
