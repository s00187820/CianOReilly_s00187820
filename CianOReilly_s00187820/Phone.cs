using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CianOReilly_s00187820
{
    public class Phone 
    {
        //public Phone(string v1, int v2, string v3, string v4, string v5)
        //{
        //}

        //prop
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string OperatingSystem { get; set; }
        public string OS_Image { get; set; }
        public string Phone_Image { get; set; }

        
        
        public List<Phone> Phones { get; set; }
      


        //method
        public void IncreasePrice(decimal amount)
        {
            Price += amount;
        }

    }

    public class PhoneData : DbContext
    {
        public PhoneData() : base("MyPhoneData") { }
        public DbSet<Phone> Phones { get; set; }
    }
}
