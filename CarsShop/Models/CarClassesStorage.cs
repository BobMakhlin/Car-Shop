using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsShop.Models
{
    [Serializable]
    class CarClassesStorage : List<string>
    {
        public CarClassesStorage()
        {
            this.Add("A");
            this.Add("B");
            this.Add("C");
            this.Add("D");
            this.Add("E");
            this.Add("F");
            this.Add("J");
            this.Add("M");
            this.Add("S");
        }
    }
}
