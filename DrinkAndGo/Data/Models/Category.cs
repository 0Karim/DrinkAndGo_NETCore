using DrinkAndGo.Data.Common;
using System.Collections.Generic;

namespace DrinkAndGo.Data.Models
{
    public class Category : BaseClass
    {
        public int CategoryId { set; get; }

        public string CategoryName { set; get; }

        public string Description { set; get; }

        public List<Drink> Drinks { set; get; }

    }
}