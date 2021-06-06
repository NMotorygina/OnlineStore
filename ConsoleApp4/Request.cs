using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    public class Request
    {
        public int article;
        public Client client;
        public DateTime date;
        public List<RequestItem> items;
        public PayType type;
        public double sum;
        public double GetSum()
        {
            sum = 0;
            foreach (RequestItem it in items)
            {
                sum += it.item.price * it.count;
            }
            return sum;
        }
        
        public Request() {}
        public Request(int article, Client client, DateTime date)
        {
            this.article = article;
            this.client = client;
            this.date = date;
        }
    }
}