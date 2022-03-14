using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance
{
    internal class Book:product
    {
        public string author;
        public string genre;

        public Book (string author, string genre,string datetime,byte price, byte count ):base(datetime,price,count)
        {
            
            this.author = author; 
            this.genre = genre;
        }
        public string ALL()
        {
            return $"Author: {author}, Genre: {genre}, Datatime: {datetime}, Price: {price}, Count: {count}";
        }
    }
}
