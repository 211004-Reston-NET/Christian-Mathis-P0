using System;

namespace Models
{
    public class Products
    //The product model is suppposed to hold the data concerning a customer.
    {
        private string _name;
        //when implemented with SQL DB change String to Decimal for price
        private decimal _price;
        private string _description;
        private string _brand;
        private string _category;
        public int ProductId { get; set; }
         public string Name {

            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public decimal Price {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
        public string Description {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
        public string Brand {
            get
            {
                return _brand;
            }
            set
            {
                _brand = value;
            }
        }
        public string Category {
            get
            {
                return _category;
            }
            set
            {
                _category = value;
            }
        }
        public override string ToString(){
            return $"Brand: {Brand} \nName: {Name} \nPrice: {Price} \nDescription: {Description} \nCategory: {Category}";
    }
}

}