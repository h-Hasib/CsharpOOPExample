namespace CsharpOOP.SuperShopApp
{
    internal class Shop
    {
        public string Name { get; set; }
        public string Address { get; set; }
        private List<Product> ProductList { get; set; }

        public Shop()
        {
            ProductList = new List<Product>();
        }
        public Shop(string name, string address) : this()
        {
            this.Name = name;
            this.Address = address;
        }
        public bool UpdateQuantity(Product Product)
        {
            if (Product.Quantity > 0)
            {
                foreach (Product item in ProductList)
                {
                    if (item.ProductID == Product.ProductID)
                    {
                        item.Quantity += Product.Quantity;
                        return true;
                    }
                }
            }
            return false;
        }
        public bool MatchProductId(Product Product)
        {
            foreach (Product item in ProductList)
            {
                if (Product.ProductID == item.ProductID)
                {
                    return true;
                }
            }
            return false;
        }

        public string AddProduct(Product Product)
        {
            if (Product != null)
            {
                if (MatchProductId(Product))
                {
                    if (UpdateQuantity(Product))
                    {
                        return "Updated";
                    }
                    else
                    {
                        return "sorry";
                    }
                }
                else
                {
                    this.ProductList.Add(Product);
                    return "Added";
                }
            }
            else
            {
                return "sorry";
            }
        }

        public string GetInfo()
        {
            string message = "Shop Information: " + Environment.NewLine;
            message += $"Name: {this.Name}  Address: {this.Address} {Environment.NewLine}";
            if (this.ProductList.Count > 0)
            {
                foreach (Product item in ProductList)
                {
                    message += item.GetProductInfo() + Environment.NewLine;
                }
            }
            return message;
        }
    }
}
