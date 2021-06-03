namespace ClassExample
{
    class Product
    {
        public string ProductName;
        public double ProductPrice;
        public double ProductQuantity;
        public bool Active;


        public Product(string productName)
        {
            ProductName = productName;
        }

        public Product(string productName, double productPrice) : this(productName)
        {
            ProductPrice = productPrice;
        }

        public Product(string productName, double productPrice, double productQuantity) : this(productName, productPrice)
        {
            ProductQuantity = productQuantity;
        }

        public Product(string productName, double productPrice, double productQuantity, bool active) : this(productName, productPrice, productQuantity)
        {
            Active = active;
        }
    }
}
