namespace ConsoleApp4
{
    public class Item
    {
        public int article;
        public string name;
        public double price;
        public ItemType type;
        
        public Item() {}
        public Item(int article, string name, double price, ItemType type)
        {
            this.article = article;
            this.name = name;
            this.price = price;
            this.type = type;
        }
    }
}