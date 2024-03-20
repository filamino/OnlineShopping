namespace OnlineShopping.Models
{
    public class ShoppingCartItem
    {
        public int ProductId { get; set; }
        public string Quantity { get; set; }

        public ShoppingCartItem(int productId, string quantity)
        {
            ProductId = productId;
            Quantity = quantity;
        }
    }


    public class ShoppingCart
    {
        public List<ShoppingCartItem>? Items { get;set; }
    }
}
