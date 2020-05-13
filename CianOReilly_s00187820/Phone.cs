using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CianOReilly_s00187820
{
    public class Phone
    {
        //prop
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string OperatingSystem { get; set; }
        public string OS_Image { get; set; }
        public string Phone_Image { get; set; }

        //method
        public void IncreasePrice(decimal amount)
        {
            Price += amount;
        }

    }
}
