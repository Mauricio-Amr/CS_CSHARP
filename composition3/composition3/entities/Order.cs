using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using composition3.entities.Enum



namespace composition3.entities
{
    internal class Order
    {
        public DateTime moment { get; set; } 
        public OrderStatus status { get; set; }


    }
}
