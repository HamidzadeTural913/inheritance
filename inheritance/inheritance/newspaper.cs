using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance
{
    internal class Newspaper : product
    {
        public string adverstiement;
        public string article;

        public Newspaper(string adverstiement, string article, string datetime, byte price, byte count) : base(datetime, price, count)
        {
            this.adverstiement = adverstiement;
            this.article = article;
        }

        public string ALL1()
        {
            return $"Adverstiement: {adverstiement}," +
                   $" Article: {article}," +
                   $" Datatime: {datetime}, " +
                   $"Price: {price}," +
                   $" Count: {count}";
        }

    }
}
