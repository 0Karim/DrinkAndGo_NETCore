using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo.Data.Common
{
    public class BaseClass
    {
        public int CreatedBy { get; set; }

        public DateTime? CreatedDate { set; get; }

        public int ModifiedBy { set; get; }

        public DateTime? ModifiedDate { set; get; }
    }
}
