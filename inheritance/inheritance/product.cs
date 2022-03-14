using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance
{
    internal class product
    {
        public string datetime;
        public byte price;
        public byte count;


        public product(string datetime, byte price, byte count)
        {
            this.datetime = datetime;
            this.price = price;
            this.count = count;
        }


        public void Sell()
        {
            if (count >= 1)
            {    
                
                count--;
                Console.WriteLine(count + "Satis ugurla alindi");
            }
            else
            {
                Console.WriteLine("Kitab qalmayib");
            }
        }
       
    }
}

