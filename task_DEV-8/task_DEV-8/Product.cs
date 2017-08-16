using System;
using System.Text;
using ProductManagement.Validators;

namespace ProductManagement
{
    public class Product
    {
        private string type;
        private string name;
        private int quantity;
        private double price;

        public Product(string[] productInfo)
        {
            ProductInfoValidator validator = new ProductInfoValidator(productInfo);
            validator.Validate();

            type = productInfo[0];
            name = productInfo[1];
            quantity = Int32.Parse(productInfo[2]);
            price = Double.Parse(productInfo[3]);
        }

        public string Type
        {
            get
            {
                return type;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
        }

        public override string ToString()
        {
            StringBuilder productInfo = new StringBuilder();
            productInfo.Append("Type: ");
            productInfo.Append(type);
            productInfo.Append("\nName: ");
            productInfo.Append(name);
            productInfo.Append("\nQuantity: ");
            productInfo.Append(quantity);
            productInfo.Append("\nPrice: ");
            productInfo.Append(price);
            return productInfo.ToString();
        }
    }
}
