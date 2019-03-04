using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample
{
    public class Product
    {
        //no-arg constructor, empty do nothing constructor
        //public Product() { }

        public Product(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException("Title cannot be null or whitespace");
            }

            if (title.Length > 30)
            {
                throw new ArgumentException("Title cannot be more than 30 characters");
            }
            Title = title;
        }

        public string Title { get; private set; }

        public double Price { get; set; }

        public string Cagetgory { get; set; }

        /// <summary>
        /// Displays all product information separated
        /// with a desired separator
        /// </summary>
        /// <param name="separator">Separates properties</param>
        /// <returns></returns>
        public virtual string GetDisplayText(string separator)
        {
            //interpolated string
            return $"{Title}{separator}{Price:c}"; //colon c makes it currency
        }

        //Expression-bodied method, same as above just newer
        //public string GetDisplay(string separator)
        //    => $"{Title}{separator}{Price}";
    }

    /// <summary>
    /// The Colon is used for inheritance
    /// </summary>
    class Software : Product
    {
        public Software(string t) : base(t)
        {
            
        }

        /// <summary>
        /// A comma separated list of supported operating systems.
        /// </summary>
        public string SupportedOS { get; set; }

        /// <summary>
        /// The company who is developing the software
        /// </summary>
        public string Company { get; set; }
    }

    class Book : Product
    {
        public Book(string title) : base(title)
        {

        }

        public string Author { get; set; }

        public string Publisher { get; set; }

        /// <summary>
        /// ISBN: International Standard Book Number
        /// </summary>
        public string Isbn { get; set; }

        public override string GetDisplayText(string sep)
        {
            return $"{base.GetDisplayText(sep)}{sep}{Isbn}";
        }
    }
}
