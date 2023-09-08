using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    /*
        Un prodotto è caratterizzato da:
        codice (numero intero)
        nome
        descrizione
        prezzo
        iva
        */

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
            this._productCode = random.Next(10000000, 100000000);
            this._name = name;
            this._description = description;
            this._price = price;
            this._vat = vat;
        }

        // Properties
        public int ProductCode
        {
            get { return _productCode; }
            set { _productCode = value; }

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
            return $"{this.ProductCode}{this.Name}";
        }




    }
}
