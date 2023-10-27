using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Norboev_Asilbek_HW4.Models
{
    public class Product
    {
        public Int32 ProductID { get; set; }

        public String Name { get; set; }

        public String? Description { get; set; }

        [DisplayFormat(DataFormatString = "{0:c2}")]
        public Decimal Price { get; set; }

    }
}
