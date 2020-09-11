using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercio_Proposto.Entidades {
    class ImportedProduct : Product {

        public double CustomFee { get; set; }

        public ImportedProduct() {

        }

        public ImportedProduct(string name, double price, double customFee)
            : base(name, price) {
            CustomFee = customFee;
        }

        public override string PriceTag(){
            return Name +" $ "+ TotalPrice().ToString("f2",CultureInfo.InvariantCulture) + " ( Custom fee: $ " + CustomFee.ToString("f2", CultureInfo.InvariantCulture) + " )";
        }

        public double TotalPrice() {
            return Price + CustomFee;
        }
    }
}
