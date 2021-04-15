using System;
using System.Text.RegularExpressions;

namespace ProductManagement.Validators
{
    public class ProductInfoValidator
    {
        public string ProductInfoFormatExceptionMessage = "Invalid product info format.";

        private string[] productInfo;

        public ProductInfoValidator(string[] productInfo)
        {
            this.productInfo = productInfo;
        }

        public void Validate()
        {
            ValidateType();
            ValidateName();
            ValidateQuantity();
            ValidatePrice();
        }

        public void ValidateType()
        {
            Regex oneWord = new Regex(@"^[A-Z][a-zA-z]*$");
            Regex twoWords = new Regex(@"^[A-Z][a-zA-z]*\s[a-zA-z]*$");
            Regex threeWords = new Regex(@"^[A-Z][a-zA-z]*\s[a-zA-z]*\s[a-zA-z]*$");
            if (!((oneWord.IsMatch(productInfo[0])) ||
                  (twoWords.IsMatch(productInfo[0])) ||
                  (threeWords.IsMatch(productInfo[0]))))
            {
                throw new FormatException(ProductInfoFormatExceptionMessage);
            }
        }

        public void ValidateName()
        {
            Regex oneWord = new Regex(@"^[A-Z][a-zA-z]*$");
            Regex twoWords = new Regex(@"^[A-Z][a-zA-z]*\s[a-zA-z]*$");
            Regex threeWords = new Regex(@"^[A-Z][a-zA-z]*\s[a-zA-z]*\s[a-zA-z]*$");
            if (!((oneWord.IsMatch(productInfo[1])) || 
                  (twoWords.IsMatch(productInfo[1])) ||
                  (threeWords.IsMatch(productInfo[1]))))
            {
                throw new FormatException(ProductInfoFormatExceptionMessage);
            }
        }

        public void ValidateQuantity()
        {
            if (Int32.Parse(productInfo[2]) <= 0)
            {
                throw new ArgumentOutOfRangeException("quantity");
            }
        }

        public void ValidatePrice()
        {
            if (Double.Parse(productInfo[3]) <= 0)
            {
                throw new ArgumentOutOfRangeException("price");
            }
        }
    }
}
