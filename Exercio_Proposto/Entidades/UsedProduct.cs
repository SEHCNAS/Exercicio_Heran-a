using System;
using System.Globalization;

namespace Exercio_Proposto.Entidades {
    class UsedProduct : Product{
        public DateTime ManufactureDate { get; set; }

        public UsedProduct() {

        }

        public UsedProduct(string name, double price, DateTime manufactureDate) 
            :base(name, price){
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag() {
            return Name + " (USED) $ " + Price.ToString("f2",CultureInfo.InvariantCulture) + " ( Manufacture date:" + ManufactureDate.ToString("dd/MM/yyyy") + " )";
        }
    }
}
