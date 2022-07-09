using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using heranca_ex1.Entities;
using System.Globalization;


namespace heranca_ex1.Entities
{
    internal class ImportedProduct : Product

     {

        public double CustomFee { get; set; }


      
        public ImportedProduct()
        {

        }


        public ImportedProduct(string name, double price, double customFee) 
            : base(name, price)
        {
            CustomFee = customFee;
        }

        public  double Totalprice()
        { 
            return Price + CustomFee;
        }


        public override string PriceTag()
        {
          
            return Name
                +"$ "
                +Totalprice().ToString("F2", CultureInfo.InvariantCulture)
                +"(Customs fee : $ "
                +CustomFee
                +
                " )";
        }

    }
}
