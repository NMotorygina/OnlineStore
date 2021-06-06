namespace ConsoleApp4
{
    public class RequestItem
    {
        public Item item;
        public int count;
        
        public RequestItem() {}
        public RequestItem(Item item, int count)
        {
            this.item = item;
            this.count = count;
        }
    }
}