using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca3.Entities
{
    internal class OutsourcedEmployee : Employee
        
    {
        public double AddictionalCharge { get; set; }

        public OutsourcedEmployee()
        {

        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour,double addictionalCharge) 
            : base (name ,hours, valuePerHour)
        {
            AddictionalCharge = addictionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AddictionalCharge;
        }

    }
}
