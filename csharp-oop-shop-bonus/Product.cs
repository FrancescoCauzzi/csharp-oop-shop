using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_bonus
{
    public class Product
    {
        // private fields
        private int _productCode;
        private string _name;

        private string _description;

        private decimal _price;

        private decimal _vat;

        // constructor

        public Product(string name, string description, decimal price, decimal vat)
        {
            Random random = new Random();
            this._productCode = random.Next(0, 1000000);
            this._name = name;
            this._description = description;
            this._price = price;
            this._vat = vat;
        }

        // Properties
        public int ProductCode
        {
            get { return _productCode; }
            // the product code is readonly
            // set { _productCode = value; }

        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public decimal Price
        {
            // this get method in the property exposes the basic price
            get { return _price; }
            set { _price = value; }
        }

        public decimal Vat
        {
            get { return _vat; }
            set { _vat = value; }
        }

        public decimal GetGrossPrice()
        {
            decimal grossPrice = this.Price + (this.Price * this.Vat); ;
            return Math.Round(grossPrice, 2);
        }

        public string GetFullName()
        {
            return $"{this.PadProductCode(this.ProductCode)}{this.Name}";
        }

        // bonus: create un metodo che restituisca il codice con un pad left di 0 per arrivare a 8 caratteri (ad esempio codice 91 diventa 00000091, mentre codice 12344556 resta come è
        public string PadProductCode(int code)
        {
            string codeString = code.ToString();
            string paddedCodeString = codeString.PadLeft(8, '0');
            return paddedCodeString;
        }




    }
}
