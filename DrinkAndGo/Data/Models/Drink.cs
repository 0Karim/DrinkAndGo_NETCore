using DrinkAndGo.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo.Data.Models
{
    public class Drink : BaseClass
    {
        public int DrinkId { set; get; }

        public string Name { set; get; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { set; get; }

        public string ImageThumbnailUrl { set; get; }

        public int InStock { set; get; }

        public int CategoryId { set; get; }

        public virtual Category Category { set; get; }
    }
}
