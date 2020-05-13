using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CianOReilly_s00187820;

namespace DataMangement
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneData db = new PhoneData();

            using (db)
            {
                Phone p1 = new Phone("Samsung S20", 500, "Android", "/images/android.png", "/images/s20.jpg");
                Phone p2 = new Phone("IPhone 11", 600, "IOS", "/images/apple.png", "/images/iphone11.png");

                db.Phones.Add(p1);
                db.Phones.Add(p1);

                Console.WriteLine("Added Phones to database");

                db.SaveChanges();

                Console.WriteLine("Saved to database");

            }
            

        }
    }
}
