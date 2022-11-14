namespace CsharpOOP.SuperShopApp
{
    internal class Product
    {
        public string ProductID { get; set; }
        public int Quantity { get; set; }

        public Product(string productID, int quantity)
        {
            ProductID = productID;
            Quantity = quantity;
        }
        public string GetProductInfo()
        {
            return $"Product ID : {this.ProductID}   Quantity : {this.Quantity}";
        }
    }
}
